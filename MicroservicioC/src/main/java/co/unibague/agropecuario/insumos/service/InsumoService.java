package co.unibague.agropecuario.insumos.service;

import co.unibague.agropecuario.insumos.dto.request.InsumoRequestDTO;
import co.unibague.agropecuario.insumos.dto.response.InsumoResponseDTO;
import co.unibague.agropecuario.insumos.dto.response.IntegridadResponseDTO;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

/**
 * Interface del servicio de Insumos
 * Define las operaciones de negocio para gestión de insumos
 *
 * Universidad de Ibagué - Microservicio C
 */
public interface InsumoService {

    // ===== OPERACIONES CRUD =====

    /**
     * Crea un nuevo insumo
     * Valida la integridad referencial con Microservicio A-B
     *
     * @param request DTO con datos del insumo
     * @return Insumo creado
     */
    InsumoResponseDTO crearInsumo(InsumoRequestDTO request);

    /**
     * Obtiene un insumo por su ID
     *
     * @param id ID del insumo
     * @return Insumo encontrado
     */
    Optional<InsumoResponseDTO> obtenerInsumoPorId(String id);

    /**
     * Obtiene todos los insumos
     *
     * @return Lista de todos los insumos
     */
    List<InsumoResponseDTO> obtenerTodosLosInsumos();

    /**
     * Actualiza un insumo existente
     *
     * @param id ID del insumo a actualizar
     * @param request DTO con nuevos datos
     * @return Insumo actualizado
     */
    InsumoResponseDTO actualizarInsumo(String id, InsumoRequestDTO request);

    /**
     * Elimina un insumo
     *
     * @param id ID del insumo a eliminar
     */
    void eliminarInsumo(String id);

    // ===== BÚSQUEDAS POR CRITERIO =====

    /**
     * Obtiene insumos de un producto específico
     *
     * @param productoId ID del producto
     * @return Lista de insumos del producto
     */
    List<InsumoResponseDTO> obtenerInsumosPorProducto(String productoId);

    /**
     * Busca insumos por tipo
     *
     * @param tipo Tipo de insumo
     * @return Lista de insumos del tipo especificado
     */
    List<InsumoResponseDTO> obtenerInsumosPorTipo(String tipo);

    /**
     * Busca insumos por proveedor
     *
     * @param proveedor Nombre del proveedor
     * @return Lista de insumos del proveedor
     */
    List<InsumoResponseDTO> obtenerInsumosPorProveedor(String proveedor);

    /**
     * Busca insumos por rango de fechas de compra
     *
     * @param inicio Fecha de inicio
     * @param fin Fecha de fin
     * @return Lista de insumos en el rango
     */
    List<InsumoResponseDTO> obtenerInsumosPorRangoFechas(LocalDateTime inicio, LocalDateTime fin);

    /**
     * Busca insumos por nombre (búsqueda parcial)
     *
     * @param nombre Nombre o parte del nombre
     * @return Lista de insumos que coinciden
     */
    List<InsumoResponseDTO> buscarInsumosPorNombre(String nombre);

    // ===== OPERACIONES DE NEGOCIO =====

    /**
     * Verifica si existe un insumo
     *
     * @param id ID del insumo
     * @return true si existe
     */
    boolean existeInsumo(String id);

    /**
     * Cuenta los insumos de un producto
     *
     * @param productoId ID del producto
     * @return Cantidad de insumos
     */
    int contarInsumosPorProducto(String productoId);

    /**
     * Obtiene insumos con stock bajo
     *
     * @param cantidadMinima Cantidad mínima considerada como stock bajo
     * @return Lista de insumos con stock bajo
     */
    List<InsumoResponseDTO> obtenerInsumosConStockBajo(int cantidadMinima);

    /**
     * Obtiene insumos próximos a vencer
     *
     * @param diasAntes Días antes del vencimiento
     * @return Lista de insumos próximos a vencer
     */
    List<InsumoResponseDTO> obtenerInsumosProximosAVencer(int diasAntes);

    /**
     * Calcula el costo total de insumos de un producto
     *
     * @param productoId ID del producto
     * @return Costo total
     */
    Double calcularCostoTotalPorProducto(String productoId);

    // ===== INTEGRIDAD REFERENCIAL =====

    /**
     * Verifica la existencia de un producto en Microservicio A-B
     * Usado para validación de integridad referencial
     *
     * @param productoId ID del producto a verificar
     * @return Respuesta con información de la verificación
     */
    IntegridadResponseDTO verificarExistenciaProducto(String productoId);
}
