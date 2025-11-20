package co.unibague.agropecuario.insumos.model;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonProperty;
import jakarta.persistence.*;
import jakarta.validation.constraints.*;
import java.time.LocalDateTime;
import java.util.Objects;

/**
 * Entidad JPA Insumo - Clase C
 * Representa los insumos agrícolas necesarios para la producción
 * Relación: ProductoAgricola (1) ---> (0..*) Insumo
 *
 * Universidad de Ibagué - Desarrollo de Aplicaciones Empresariales
 * Microservicio C - Base de datos Oracle
 */
@Entity
@Table(name = "insumo")
public class Insumo {

    @Id
    @Column(name = "id", length = 10, nullable = false)
    @Size(max = 10, message = "El ID no puede exceder 10 caracteres")
    private String id;

    // Relación con ProductoAgricola (del Microservicio A-B)
    // Este campo NO es una FK de base de datos, sino una referencia lógica
    @Column(name = "producto_id", length = 10, nullable = false)
    @NotBlank(message = "El ID del producto es obligatorio")
    @JsonProperty("productoId")
    private String productoId;

    @Column(name = "nombre", length = 100, nullable = false)
    @NotBlank(message = "El nombre del insumo es obligatorio")
    @Size(min = 2, max = 100, message = "El nombre debe tener entre 2 y 100 caracteres")
    private String nombre;

    @Column(name = "cantidad", nullable = false)
    @NotNull(message = "La cantidad es obligatoria")
    @Min(value = 1, message = "La cantidad debe ser mayor a 0")
    @Max(value = 1000000, message = "La cantidad no puede exceder 1,000,000")
    private Integer cantidad;

    @Column(name = "costo_unitario", nullable = false)
    @NotNull(message = "El costo unitario es obligatorio")
    @DecimalMin(value = "0.01", message = "El costo debe ser mayor a 0")
    @DecimalMax(value = "10000000.0", message = "El costo no puede exceder $10,000,000")
    @JsonProperty("costoUnitario")
    private Double costoUnitario;

    @Column(name = "fecha_compra", nullable = false)
    @NotNull(message = "La fecha de compra es obligatoria")
    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    @JsonProperty("fechaCompra")
    private LocalDateTime fechaCompra;

    @Column(name = "proveedor", length = 100, nullable = false)
    @NotBlank(message = "El proveedor es obligatorio")
    @Size(min = 2, max = 100, message = "El proveedor debe tener entre 2 y 100 caracteres")
    private String proveedor;

    @Column(name = "tipo", length = 30, nullable = false)
    @NotBlank(message = "El tipo de insumo es obligatorio")
    @Pattern(regexp = "FERTILIZANTE|SEMILLA|PESTICIDA|HERRAMIENTA",
             message = "El tipo debe ser: FERTILIZANTE, SEMILLA, PESTICIDA o HERRAMIENTA")
    private String tipo;

    // Atributos opcionales
    @Column(name = "descripcion", length = 500)
    private String descripcion;

    @Column(name = "unidad_medida", length = 20)
    @JsonProperty("unidadMedida")
    private String unidadMedida; // kg, litros, unidades, etc.

    @Column(name = "fecha_vencimiento")
    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    @JsonProperty("fechaVencimiento")
    private LocalDateTime fechaVencimiento;

    @Column(name = "lote", length = 50)
    private String lote;

    @Column(name = "activo")
    private Boolean activo;

    // ===== CONSTRUCTORES =====

    public Insumo() {
        this.fechaCompra = LocalDateTime.now();
        this.activo = true;
        this.unidadMedida = "UNIDAD";
    }

    public Insumo(String id, String productoId, String nombre, Integer cantidad,
                  Double costoUnitario, String proveedor, String tipo) {
        this();
        this.id = id;
        this.productoId = productoId;
        this.nombre = nombre;
        this.cantidad = cantidad;
        this.costoUnitario = costoUnitario;
        this.proveedor = proveedor;
        this.tipo = tipo;
    }

    // ===== MÉTODOS DE NEGOCIO =====

    /**
     * Calcula el costo total del insumo (cantidad * costo unitario)
     */
    public double calcularCostoTotal() {
        if (cantidad == null || costoUnitario == null) {
            return 0.0;
        }
        return cantidad * costoUnitario;
    }

    /**
     * Verifica si el insumo está próximo a vencer (menos de 30 días)
     */
    public boolean estaProximoAVencer() {
        if (fechaVencimiento == null) {
            return false;
        }
        LocalDateTime dentroDeUnMes = LocalDateTime.now().plusDays(30);
        return fechaVencimiento.isBefore(dentroDeUnMes) && fechaVencimiento.isAfter(LocalDateTime.now());
    }

    /**
     * Verifica si el insumo está vencido
     */
    public boolean estaVencido() {
        if (fechaVencimiento == null) {
            return false;
        }
        return fechaVencimiento.isBefore(LocalDateTime.now());
    }

    /**
     * Verifica si el stock es bajo (menos de 10 unidades)
     */
    public boolean esStockBajo() {
        return cantidad != null && cantidad < 10;
    }

    /**
     * Reduce la cantidad del insumo
     */
    public void reducirCantidad(int cantidadAReducir) {
        if (cantidadAReducir <= 0) {
            throw new IllegalArgumentException("La cantidad a reducir debe ser mayor a 0");
        }
        if (this.cantidad == null || this.cantidad < cantidadAReducir) {
            throw new IllegalArgumentException("No hay suficiente stock");
        }
        this.cantidad -= cantidadAReducir;
    }

    /**
     * Aumenta la cantidad del insumo
     */
    public void aumentarCantidad(int cantidadAAumentar) {
        if (cantidadAAumentar <= 0) {
            throw new IllegalArgumentException("La cantidad a aumentar debe ser mayor a 0");
        }
        this.cantidad += cantidadAAumentar;
    }

    // ===== GETTERS Y SETTERS =====

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getProductoId() {
        return productoId;
    }

    public void setProductoId(String productoId) {
        this.productoId = productoId;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Integer getCantidad() {
        return cantidad;
    }

    public void setCantidad(Integer cantidad) {
        this.cantidad = cantidad;
    }

    public Double getCostoUnitario() {
        return costoUnitario;
    }

    public void setCostoUnitario(Double costoUnitario) {
        this.costoUnitario = costoUnitario;
    }

    public LocalDateTime getFechaCompra() {
        return fechaCompra;
    }

    public void setFechaCompra(LocalDateTime fechaCompra) {
        this.fechaCompra = fechaCompra;
    }

    public String getProveedor() {
        return proveedor;
    }

    public void setProveedor(String proveedor) {
        this.proveedor = proveedor;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getUnidadMedida() {
        return unidadMedida;
    }

    public void setUnidadMedida(String unidadMedida) {
        this.unidadMedida = unidadMedida;
    }

    public LocalDateTime getFechaVencimiento() {
        return fechaVencimiento;
    }

    public void setFechaVencimiento(LocalDateTime fechaVencimiento) {
        this.fechaVencimiento = fechaVencimiento;
    }

    public String getLote() {
        return lote;
    }

    public void setLote(String lote) {
        this.lote = lote;
    }

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }

    // ===== MÉTODOS ESTÁNDAR =====

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (obj == null || getClass() != obj.getClass()) return false;
        Insumo insumo = (Insumo) obj;
        return Objects.equals(id, insumo.id);
    }

    @Override
    public int hashCode() {
        return Objects.hash(id);
    }

    @Override
    public String toString() {
        return String.format("Insumo{id='%s', nombre='%s', tipo='%s', cantidad=%d, productoId='%s'}",
                id, nombre, tipo, cantidad, productoId);
    }
}
