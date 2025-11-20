package co.unibague.agropecuario.insumos.repository;

import co.unibague.agropecuario.insumos.model.Insumo;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

/**
 * Repository JPA para la entidad Insumo
 * Proporciona acceso a datos con Oracle Database
 *
 * Universidad de Ibagué - Desarrollo de Aplicaciones Empresariales
 * Microservicio C
 */
@Repository
public interface InsumoJpaRepository extends JpaRepository<Insumo, String> {

    // ===== CONSULTAS POR RELACIÓN CON PRODUCTO =====

    /**
     * Obtiene todos los insumos de un producto específico
     * @param productoId ID del producto agrícola
     * @return Lista de insumos del producto
     */
    List<Insumo> findByProductoId(String productoId);

    /**
     * Cuenta los insumos de un producto
     * @param productoId ID del producto agrícola
     * @return Cantidad de insumos
     */
    int countByProductoId(String productoId);

    /**
     * Verifica si existe un insumo con el ID dado para un producto específico
     * @param id ID del insumo
     * @param productoId ID del producto
     * @return true si existe
     */
    boolean existsByIdAndProductoId(String id, String productoId);

    // ===== CONSULTAS POR TIPO =====

    /**
     * Busca insumos por tipo
     * @param tipo Tipo de insumo (FERTILIZANTE, SEMILLA, PESTICIDA, HERRAMIENTA)
     * @return Lista de insumos del tipo especificado
     */
    List<Insumo> findByTipo(String tipo);

    /**
     * Busca insumos por tipo y producto
     * @param tipo Tipo de insumo
     * @param productoId ID del producto
     * @return Lista de insumos
     */
    List<Insumo> findByTipoAndProductoId(String tipo, String productoId);

    // ===== CONSULTAS POR PROVEEDOR =====

    /**
     * Busca insumos por proveedor
     * @param proveedor Nombre del proveedor
     * @return Lista de insumos del proveedor
     */
    List<Insumo> findByProveedor(String proveedor);

    /**
     * Busca insumos por proveedor (case insensitive)
     * @param proveedor Nombre del proveedor
     * @return Lista de insumos
     */
    List<Insumo> findByProveedorIgnoreCase(String proveedor);

    /**
     * Busca insumos cuyo proveedor contenga el texto especificado
     * @param proveedor Texto a buscar en el nombre del proveedor
     * @return Lista de insumos
     */
    List<Insumo> findByProveedorContainingIgnoreCase(String proveedor);

    // ===== CONSULTAS POR NOMBRE =====

    /**
     * Busca insumos por nombre exacto
     * @param nombre Nombre del insumo
     * @return Lista de insumos
     */
    List<Insumo> findByNombre(String nombre);

    /**
     * Busca insumos cuyo nombre contenga el texto especificado
     * @param nombre Texto a buscar en el nombre
     * @return Lista de insumos
     */
    List<Insumo> findByNombreContainingIgnoreCase(String nombre);

    // ===== CONSULTAS POR FECHA =====

    /**
     * Busca insumos comprados en un rango de fechas
     * @param inicio Fecha de inicio
     * @param fin Fecha de fin
     * @return Lista de insumos
     */
    List<Insumo> findByFechaCompraBetween(LocalDateTime inicio, LocalDateTime fin);

    /**
     * Busca insumos cuya fecha de vencimiento esté en un rango
     * @param inicio Fecha de inicio
     * @param fin Fecha de fin
     * @return Lista de insumos
     */
    List<Insumo> findByFechaVencimientoBetween(LocalDateTime inicio, LocalDateTime fin);

    /**
     * Busca insumos que vencen antes de una fecha específica
     * @param fecha Fecha límite
     * @return Lista de insumos próximos a vencer
     */
    @Query("SELECT i FROM Insumo i WHERE i.fechaVencimiento IS NOT NULL AND i.fechaVencimiento < :fecha AND i.activo = true")
    List<Insumo> findInsumosProximosAVencer(@Param("fecha") LocalDateTime fecha);

    // ===== CONSULTAS POR ESTADO =====

    /**
     * Busca insumos activos
     * @param activo Estado del insumo
     * @return Lista de insumos activos o inactivos
     */
    List<Insumo> findByActivo(Boolean activo);

    /**
     * Busca insumos con stock bajo (menos de una cantidad específica)
     * @param cantidadMinima Cantidad mínima
     * @return Lista de insumos con stock bajo
     */
    @Query("SELECT i FROM Insumo i WHERE i.cantidad < :cantidadMinima AND i.activo = true")
    List<Insumo> findInsumosConStockBajo(@Param("cantidadMinima") int cantidadMinima);

    // ===== CONSULTAS POR COSTO =====

    /**
     * Busca insumos con costo unitario en un rango
     * @param minCosto Costo mínimo
     * @param maxCosto Costo máximo
     * @return Lista de insumos
     */
    List<Insumo> findByCostoUnitarioBetween(Double minCosto, Double maxCosto);

    /**
     * Busca insumos cuyo costo total supere un valor
     * @param costoTotal Costo total mínimo
     * @return Lista de insumos
     */
    @Query("SELECT i FROM Insumo i WHERE (i.cantidad * i.costoUnitario) > :costoTotal")
    List<Insumo> findInsumosPorCostoTotalMayorA(@Param("costoTotal") double costoTotal);

    // ===== CONSULTAS ESTADÍSTICAS =====

    /**
     * Calcula el costo total de todos los insumos de un producto
     * @param productoId ID del producto
     * @return Costo total
     */
    @Query("SELECT SUM(i.cantidad * i.costoUnitario) FROM Insumo i WHERE i.productoId = :productoId")
    Double calcularCostoTotalPorProducto(@Param("productoId") String productoId);

    /**
     * Cuenta insumos por tipo
     * @param tipo Tipo de insumo
     * @return Cantidad de insumos
     */
    int countByTipo(String tipo);

    /**
     * Obtiene el insumo más caro de un producto
     * @param productoId ID del producto
     * @return Insumo más caro
     */
    @Query("SELECT i FROM Insumo i WHERE i.productoId = :productoId ORDER BY i.costoUnitario DESC LIMIT 1")
    Optional<Insumo> findInsumoMasCaroPorProducto(@Param("productoId") String productoId);

    // ===== CONSULTAS DE VERIFICACIÓN =====

    /**
     * Verifica si existe algún insumo para un producto
     * @param productoId ID del producto
     * @return true si existen insumos
     */
    boolean existsByProductoId(String productoId);

    /**
     * Verifica si existe un insumo con el nombre y tipo dados
     * @param nombre Nombre del insumo
     * @param tipo Tipo del insumo
     * @return true si existe
     */
    boolean existsByNombreAndTipo(String nombre, String tipo);
}
