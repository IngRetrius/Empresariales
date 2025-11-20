package co.unibague.agropecuario.insumos.service;

import co.unibague.agropecuario.insumos.dto.request.InsumoRequestDTO;
import co.unibague.agropecuario.insumos.dto.response.InsumoResponseDTO;
import co.unibague.agropecuario.insumos.dto.response.IntegridadResponseDTO;
import co.unibague.agropecuario.insumos.exception.InsumoAlreadyExistsException;
import co.unibague.agropecuario.insumos.exception.InsumoNotFoundException;
import co.unibague.agropecuario.insumos.exception.MicroserviceClientException;
import co.unibague.agropecuario.insumos.exception.ValidationException;
import co.unibague.agropecuario.insumos.model.Insumo;
import co.unibague.agropecuario.insumos.repository.InsumoJpaRepository;
import co.unibague.agropecuario.insumos.utils.Constantes;
import co.unibague.agropecuario.insumos.utils.InsumoMapper;
import co.unibague.agropecuario.insumos.utils.Validador;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.reactive.function.client.WebClient;
import reactor.core.publisher.Mono;

import java.time.Duration;
import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

/**
 * Implementación del servicio de Insumos
 * Universidad de Ibagué - Microservicio C
 */
@Service
@Transactional
public class InsumoServiceImpl implements InsumoService {

    private static final Logger logger = LoggerFactory.getLogger(InsumoServiceImpl.class);

    @Autowired
    private InsumoJpaRepository repository;

    @Autowired
    private IdGeneratorService idGenerator;

    @Autowired
    private WebClient.Builder webClientBuilder;

    @Value("${app.microservicio-ab.base-url}")
    private String microservicioABUrl;

    @Value("${app.microservicio-ab.timeout:5000}")
    private int timeout;

    // ===== OPERACIONES CRUD =====

    @Override
    public InsumoResponseDTO crearInsumo(InsumoRequestDTO request) {
        logger.info("Iniciando creación de insumo: {}", request.getNombre());

        try {
            // 1. Validaciones de negocio
            Validador.validarNombre(request.getNombre());
            Validador.validarProductoId(request.getProductoId());
            Validador.validarCantidad(request.getCantidad());
            Validador.validarCostoUnitario(request.getCostoUnitario());
            Validador.validarTipoInsumo(request.getTipo());
            Validador.validarProveedor(request.getProveedor());

            // 2. Verificar integridad referencial con Microservicio A-B
            logger.debug("Verificando existencia de producto: {}", request.getProductoId());
            IntegridadResponseDTO verificacion = verificarExistenciaProducto(request.getProductoId());

            if (!verificacion.getExiste()) {
                logger.warn("Producto no encontrado: {}", request.getProductoId());
                throw new ValidationException(
                        String.format(Constantes.ERROR_PRODUCTO_NO_EXISTE_INTEGRIDAD, request.getProductoId())
                );
            }

            // 3. Convertir DTO a entidad
            Insumo insumo = InsumoMapper.toEntity(request);

            // 4. Generar ID único
            String nuevoId = idGenerator.generarIdInsumo();
            insumo.setId(nuevoId);

            // 5. Guardar en base de datos
            Insumo insumoGuardado = repository.save(insumo);

            logger.info("Insumo creado exitosamente: {}", insumoGuardado.getId());
            return InsumoMapper.toResponseDTO(insumoGuardado);

        } catch (ValidationException | MicroserviceClientException e) {
            logger.error("Error de validación al crear insumo: {}", e.getMessage());
            throw e;
        } catch (Exception e) {
            logger.error("Error inesperado al crear insumo: {}", e.getMessage(), e);
            throw new RuntimeException("Error al crear insumo", e);
        }
    }

    @Override
    @Transactional(readOnly = true)
    public Optional<InsumoResponseDTO> obtenerInsumoPorId(String id) {
        logger.debug("Buscando insumo por ID: {}", id);

        Validador.validarInsumoId(id);

        return repository.findById(id)
                .map(InsumoMapper::toResponseDTO);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerTodosLosInsumos() {
        logger.debug("Obteniendo todos los insumos");

        List<Insumo> insumos = repository.findAll();
        logger.info("Se encontraron {} insumos", insumos.size());

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    public InsumoResponseDTO actualizarInsumo(String id, InsumoRequestDTO request) {
        logger.info("Actualizando insumo: {}", id);

        try {
            // 1. Validar ID
            Validador.validarInsumoId(id);

            // 2. Buscar insumo existente
            Insumo insumoExistente = repository.findById(id)
                    .orElseThrow(() -> InsumoNotFoundException.porId(id));

            // 3. Validaciones de negocio
            if (request.getNombre() != null) {
                Validador.validarNombre(request.getNombre());
            }
            if (request.getCantidad() != null) {
                Validador.validarCantidad(request.getCantidad());
            }
            if (request.getCostoUnitario() != null) {
                Validador.validarCostoUnitario(request.getCostoUnitario());
            }
            if (request.getTipo() != null) {
                Validador.validarTipoInsumo(request.getTipo());
            }

            // 4. Si se cambia el producto, verificar integridad
            if (request.getProductoId() != null &&
                !request.getProductoId().equals(insumoExistente.getProductoId())) {

                Validador.validarProductoId(request.getProductoId());
                IntegridadResponseDTO verificacion = verificarExistenciaProducto(request.getProductoId());

                if (!verificacion.getExiste()) {
                    throw new ValidationException(
                            String.format(Constantes.ERROR_PRODUCTO_NO_EXISTE_INTEGRIDAD, request.getProductoId())
                    );
                }
            }

            // 5. Actualizar campos
            InsumoMapper.updateEntityFromDTO(insumoExistente, request);

            // 6. Guardar cambios
            Insumo insumoActualizado = repository.save(insumoExistente);

            logger.info("Insumo actualizado exitosamente: {}", id);
            return InsumoMapper.toResponseDTO(insumoActualizado);

        } catch (InsumoNotFoundException | ValidationException | MicroserviceClientException e) {
            logger.error("Error al actualizar insumo: {}", e.getMessage());
            throw e;
        } catch (Exception e) {
            logger.error("Error inesperado al actualizar insumo: {}", e.getMessage(), e);
            throw new RuntimeException("Error al actualizar insumo", e);
        }
    }

    @Override
    public void eliminarInsumo(String id) {
        logger.info("Eliminando insumo: {}", id);

        try {
            Validador.validarInsumoId(id);

            if (!repository.existsById(id)) {
                throw InsumoNotFoundException.porId(id);
            }

            repository.deleteById(id);
            logger.info("Insumo eliminado exitosamente: {}", id);

        } catch (InsumoNotFoundException e) {
            logger.error("Error al eliminar insumo: {}", e.getMessage());
            throw e;
        } catch (Exception e) {
            logger.error("Error inesperado al eliminar insumo: {}", e.getMessage(), e);
            throw new RuntimeException("Error al eliminar insumo", e);
        }
    }

    // ===== BÚSQUEDAS POR CRITERIO =====

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerInsumosPorProducto(String productoId) {
        logger.debug("Obteniendo insumos del producto: {}", productoId);

        Validador.validarProductoId(productoId);

        List<Insumo> insumos = repository.findByProductoId(productoId);
        logger.info("Se encontraron {} insumos para el producto {}", insumos.size(), productoId);

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerInsumosPorTipo(String tipo) {
        logger.debug("Obteniendo insumos del tipo: {}", tipo);

        Validador.validarTipoInsumo(tipo);

        List<Insumo> insumos = repository.findByTipo(tipo);
        logger.info("Se encontraron {} insumos del tipo {}", insumos.size(), tipo);

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerInsumosPorProveedor(String proveedor) {
        logger.debug("Obteniendo insumos del proveedor: {}", proveedor);

        if (proveedor == null || proveedor.trim().isEmpty()) {
            throw new ValidationException("El proveedor no puede estar vacío");
        }

        List<Insumo> insumos = repository.findByProveedorContainingIgnoreCase(proveedor);
        logger.info("Se encontraron {} insumos del proveedor {}", insumos.size(), proveedor);

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerInsumosPorRangoFechas(LocalDateTime inicio, LocalDateTime fin) {
        logger.debug("Obteniendo insumos entre {} y {}", inicio, fin);

        if (inicio == null || fin == null) {
            throw new ValidationException("Las fechas de inicio y fin son obligatorias");
        }
        if (inicio.isAfter(fin)) {
            throw new ValidationException("La fecha de inicio debe ser anterior a la fecha de fin");
        }

        List<Insumo> insumos = repository.findByFechaCompraBetween(inicio, fin);
        logger.info("Se encontraron {} insumos en el rango de fechas", insumos.size());

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> buscarInsumosPorNombre(String nombre) {
        logger.debug("Buscando insumos por nombre: {}", nombre);

        if (nombre == null || nombre.trim().isEmpty()) {
            throw new ValidationException("El nombre no puede estar vacío");
        }

        List<Insumo> insumos = repository.findByNombreContainingIgnoreCase(nombre);
        logger.info("Se encontraron {} insumos con el nombre '{}'", insumos.size(), nombre);

        return InsumoMapper.toResponseDTOList(insumos);
    }

    // ===== OPERACIONES DE NEGOCIO =====

    @Override
    @Transactional(readOnly = true)
    public boolean existeInsumo(String id) {
        return repository.existsById(id);
    }

    @Override
    @Transactional(readOnly = true)
    public int contarInsumosPorProducto(String productoId) {
        Validador.validarProductoId(productoId);
        return repository.countByProductoId(productoId);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerInsumosConStockBajo(int cantidadMinima) {
        logger.debug("Obteniendo insumos con stock menor a: {}", cantidadMinima);

        List<Insumo> insumos = repository.findInsumosConStockBajo(cantidadMinima);
        logger.info("Se encontraron {} insumos con stock bajo", insumos.size());

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    @Transactional(readOnly = true)
    public List<InsumoResponseDTO> obtenerInsumosProximosAVencer(int diasAntes) {
        logger.debug("Obteniendo insumos que vencen en los próximos {} días", diasAntes);

        LocalDateTime fechaLimite = LocalDateTime.now().plusDays(diasAntes);
        List<Insumo> insumos = repository.findInsumosProximosAVencer(fechaLimite);
        logger.info("Se encontraron {} insumos próximos a vencer", insumos.size());

        return InsumoMapper.toResponseDTOList(insumos);
    }

    @Override
    @Transactional(readOnly = true)
    public Double calcularCostoTotalPorProducto(String productoId) {
        logger.debug("Calculando costo total de insumos para producto: {}", productoId);

        Validador.validarProductoId(productoId);

        Double costoTotal = repository.calcularCostoTotalPorProducto(productoId);
        logger.info("Costo total de insumos para producto {}: ${}", productoId, costoTotal);

        return costoTotal != null ? costoTotal : 0.0;
    }

    // ===== INTEGRIDAD REFERENCIAL =====

    @Override
    public IntegridadResponseDTO verificarExistenciaProducto(String productoId) {
        logger.debug("Verificando existencia de producto en Microservicio A-B: {}", productoId);

        try {
            WebClient webClient = webClientBuilder.baseUrl(microservicioABUrl).build();

            // Llamar al endpoint de verificación del Microservicio A-B
            Mono<IntegridadResponseDTO> responseMono = webClient
                    .get()
                    .uri("/api/productos/verificar/{productoId}", productoId)
                    .retrieve()
                    .bodyToMono(IntegridadResponseDTO.class)
                    .timeout(Duration.ofMillis(timeout))
                    .onErrorResume(error -> {
                        logger.error("Error al verificar producto en Microservicio A-B: {}", error.getMessage());
                        return Mono.error(new MicroserviceClientException(
                                "Microservicio A-B",
                                Constantes.ERROR_MICROSERVICIO_AB_NO_DISPONIBLE,
                                error
                        ));
                    });

            IntegridadResponseDTO response = responseMono.block();

            if (response != null) {
                logger.info("Verificación completada para producto {}: existe={}", productoId, response.getExiste());
            }

            return response;

        } catch (Exception e) {
            logger.error("Error al comunicarse con Microservicio A-B: {}", e.getMessage());
            throw new MicroserviceClientException(
                    "Microservicio A-B",
                    Constantes.ERROR_MICROSERVICIO_AB_NO_DISPONIBLE,
                    e
            );
        }
    }
}
