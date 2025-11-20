package co.unibague.agropecuario.insumos.controller;

import co.unibague.agropecuario.insumos.dto.request.InsumoRequestDTO;
import co.unibague.agropecuario.insumos.dto.response.ApiResponseDTO;
import co.unibague.agropecuario.insumos.dto.response.InsumoResponseDTO;
import co.unibague.agropecuario.insumos.service.InsumoService;
import co.unibague.agropecuario.insumos.utils.Constantes;
import co.unibague.agropecuario.insumos.utils.ResponseBuilder;
import jakarta.validation.Valid;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Map;
import java.util.Optional;

/**
 * Controlador REST para gestión de Insumos (Clase C)
 * Universidad de Ibagué - Desarrollo de Aplicaciones Empresariales
 * Microservicio C - Puerto 8082
 */
@RestController
@RequestMapping("/api/insumos")
@CrossOrigin(origins = "*")
public class InsumoController {

    private static final Logger logger = LoggerFactory.getLogger(InsumoController.class);

    @Autowired
    private InsumoService service;

    // ===== ENDPOINTS DE PRUEBA =====

    @GetMapping("/test")
    public ResponseEntity<String> test() {
        return ResponseEntity.ok("InsumoController funcionando correctamente - Puerto 8082");
    }

    @GetMapping("/estadisticas")
    public ResponseEntity<ApiResponseDTO<Object>> obtenerEstadisticas() {
        try {
            List<InsumoResponseDTO> insumos = service.obtenerTodosLosInsumos();

            Map<String, Object> estadisticas = Map.of(
                    "totalInsumos", insumos.size(),
                    "servidor", "Insumo Microservice - Oracle DB",
                    "version", "1.0.0",
                    "timestamp", LocalDateTime.now()
            );

            return ResponseEntity.ok(ResponseBuilder.success("Estadísticas del sistema", estadisticas));
        } catch (Exception e) {
            return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR)
                    .body(ResponseBuilder.error("Error al obtener estadísticas: " + e.getMessage()));
        }
    }

    // ===== CRUD COMPLETO =====

    @PostMapping
    public ResponseEntity<ApiResponseDTO<InsumoResponseDTO>> crearInsumo(
            @Valid @RequestBody InsumoRequestDTO request) {
        try {
            logger.info("POST /api/insumos - Creando insumo: {}", request.getNombre());
            InsumoResponseDTO insumo = service.crearInsumo(request);
            return ResponseEntity.status(HttpStatus.CREATED)
                    .body(ResponseBuilder.success(Constantes.EXITO_CREAR_INSUMO, insumo));
        } catch (Exception e) {
            logger.error("Error al crear insumo: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> listarTodos() {
        try {
            logger.info("GET /api/insumos - Listando todos los insumos");
            List<InsumoResponseDTO> insumos = service.obtenerTodosLosInsumos();
            return ResponseEntity.ok(ResponseBuilder.success(Constantes.EXITO_LISTAR_INSUMOS, insumos));
        } catch (Exception e) {
            logger.error("Error al listar insumos: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping("/{id}")
    public ResponseEntity<ApiResponseDTO<InsumoResponseDTO>> obtenerPorId(@PathVariable String id) {
        try {
            logger.info("GET /api/insumos/{} - Obteniendo insumo", id);
            Optional<InsumoResponseDTO> insumo = service.obtenerInsumoPorId(id);

            if (insumo.isPresent()) {
                return ResponseEntity.ok(ResponseBuilder.success(Constantes.EXITO_OBTENER_INSUMO, insumo.get()));
            } else {
                return ResponseEntity.status(HttpStatus.NOT_FOUND)
                        .body(ResponseBuilder.error(String.format(Constantes.ERROR_INSUMO_NO_ENCONTRADO, id)));
            }
        } catch (Exception e) {
            logger.error("Error al obtener insumo: {}", e.getMessage());
            throw e;
        }
    }

    @PutMapping("/{id}")
    public ResponseEntity<ApiResponseDTO<InsumoResponseDTO>> actualizar(
            @PathVariable String id,
            @Valid @RequestBody InsumoRequestDTO request) {
        try {
            logger.info("PUT /api/insumos/{} - Actualizando insumo", id);
            InsumoResponseDTO insumo = service.actualizarInsumo(id, request);
            return ResponseEntity.ok(ResponseBuilder.success(Constantes.EXITO_ACTUALIZAR_INSUMO, insumo));
        } catch (Exception e) {
            logger.error("Error al actualizar insumo: {}", e.getMessage());
            throw e;
        }
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<ApiResponseDTO<Void>> eliminar(@PathVariable String id) {
        try {
            logger.info("DELETE /api/insumos/{} - Eliminando insumo", id);
            service.eliminarInsumo(id);
            return ResponseEntity.ok(ResponseBuilder.success(Constantes.EXITO_ELIMINAR_INSUMO, null));
        } catch (Exception e) {
            logger.error("Error al eliminar insumo: {}", e.getMessage());
            throw e;
        }
    }

    // ===== BÚSQUEDAS CON PARÁMETROS =====

    @GetMapping(params = "tipo")
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> buscarPorTipo(
            @RequestParam("tipo") String tipo) {
        try {
            logger.info("GET /api/insumos?tipo={}", tipo);
            List<InsumoResponseDTO> insumos = service.obtenerInsumosPorTipo(tipo);
            String mensaje = String.format("Se encontraron %d insumos del tipo '%s'", insumos.size(), tipo);
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al buscar por tipo: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping(params = "proveedor")
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> buscarPorProveedor(
            @RequestParam("proveedor") String proveedor) {
        try {
            logger.info("GET /api/insumos?proveedor={}", proveedor);
            List<InsumoResponseDTO> insumos = service.obtenerInsumosPorProveedor(proveedor);
            String mensaje = String.format("Se encontraron %d insumos del proveedor '%s'", insumos.size(), proveedor);
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al buscar por proveedor: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping(params = "nombre")
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> buscarPorNombre(
            @RequestParam("nombre") String nombre) {
        try {
            logger.info("GET /api/insumos?nombre={}", nombre);
            List<InsumoResponseDTO> insumos = service.buscarInsumosPorNombre(nombre);
            String mensaje = String.format("Se encontraron %d insumos con el nombre '%s'", insumos.size(), nombre);
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al buscar por nombre: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping(params = {"fechaInicio", "fechaFin"})
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> buscarPorRangoFechas(
            @RequestParam("fechaInicio") @DateTimeFormat(iso = DateTimeFormat.ISO.DATE_TIME) LocalDateTime inicio,
            @RequestParam("fechaFin") @DateTimeFormat(iso = DateTimeFormat.ISO.DATE_TIME) LocalDateTime fin) {
        try {
            logger.info("GET /api/insumos?fechaInicio={}&fechaFin={}", inicio, fin);
            List<InsumoResponseDTO> insumos = service.obtenerInsumosPorRangoFechas(inicio, fin);
            String mensaje = String.format("Se encontraron %d insumos en el rango de fechas", insumos.size());
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al buscar por rango de fechas: {}", e.getMessage());
            throw e;
        }
    }

    // ===== ENDPOINTS PARA RELACIÓN CON PRODUCTO =====

    @GetMapping("/producto/{productoId}")
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> obtenerInsumosPorProducto(
            @PathVariable String productoId) {
        try {
            logger.info("GET /api/insumos/producto/{}", productoId);
            List<InsumoResponseDTO> insumos = service.obtenerInsumosPorProducto(productoId);
            String mensaje = String.format("Se encontraron %d insumos para el producto '%s'", insumos.size(), productoId);
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al obtener insumos del producto: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping("/producto/{productoId}/count")
    public ResponseEntity<ApiResponseDTO<Integer>> contarInsumosPorProducto(
            @PathVariable String productoId) {
        try {
            logger.info("GET /api/insumos/producto/{}/count", productoId);
            int cantidad = service.contarInsumosPorProducto(productoId);
            return ResponseEntity.ok(ResponseBuilder.success(
                    "Total de insumos del producto " + productoId, cantidad));
        } catch (Exception e) {
            logger.error("Error al contar insumos: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping("/producto/{productoId}/costo-total")
    public ResponseEntity<ApiResponseDTO<Double>> calcularCostoTotalPorProducto(
            @PathVariable String productoId) {
        try {
            logger.info("GET /api/insumos/producto/{}/costo-total", productoId);
            Double costoTotal = service.calcularCostoTotalPorProducto(productoId);
            return ResponseEntity.ok(ResponseBuilder.success(
                    "Costo total de insumos del producto " + productoId, costoTotal));
        } catch (Exception e) {
            logger.error("Error al calcular costo total: {}", e.getMessage());
            throw e;
        }
    }

    // ===== ENDPOINTS DE ALERTAS =====

    @GetMapping("/stock-bajo")
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> obtenerInsumosConStockBajo(
            @RequestParam(value = "cantidad", defaultValue = "10") int cantidadMinima) {
        try {
            logger.info("GET /api/insumos/stock-bajo?cantidad={}", cantidadMinima);
            List<InsumoResponseDTO> insumos = service.obtenerInsumosConStockBajo(cantidadMinima);
            String mensaje = String.format("Se encontraron %d insumos con stock bajo", insumos.size());
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al obtener insumos con stock bajo: {}", e.getMessage());
            throw e;
        }
    }

    @GetMapping("/proximos-vencer")
    public ResponseEntity<ApiResponseDTO<List<InsumoResponseDTO>>> obtenerInsumosProximosAVencer(
            @RequestParam(value = "dias", defaultValue = "30") int diasAntes) {
        try {
            logger.info("GET /api/insumos/proximos-vencer?dias={}", diasAntes);
            List<InsumoResponseDTO> insumos = service.obtenerInsumosProximosAVencer(diasAntes);
            String mensaje = String.format("Se encontraron %d insumos próximos a vencer", insumos.size());
            return ResponseEntity.ok(ResponseBuilder.success(mensaje, insumos));
        } catch (Exception e) {
            logger.error("Error al obtener insumos próximos a vencer: {}", e.getMessage());
            throw e;
        }
    }

    // ===== ENDPOINT DE VERIFICACIÓN DE INTEGRIDAD =====

    @GetMapping("/verificar-producto/{productoId}")
    public ResponseEntity<ApiResponseDTO<Boolean>> verificarProducto(@PathVariable String productoId) {
        try {
            logger.info("GET /api/insumos/verificar-producto/{}", productoId);
            var verificacion = service.verificarExistenciaProducto(productoId);
            return ResponseEntity.ok(ResponseBuilder.success(
                    "Verificación completada", verificacion.getExiste()));
        } catch (Exception e) {
            logger.error("Error al verificar producto: {}", e.getMessage());
            throw e;
        }
    }
}
