package co.unibague.agropecuario.insumos.dto.request;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonProperty;
import jakarta.validation.constraints.*;

import java.time.LocalDateTime;

/**
 * DTO para crear/actualizar insumos
 * Usado en operaciones POST y PUT
 *
 * Universidad de Ibagué - Microservicio C
 */
public class InsumoRequestDTO {

    @NotBlank(message = "El ID del producto es obligatorio")
    @Size(max = 10, message = "El ID del producto no puede exceder 10 caracteres")
    @JsonProperty("productoId")
    private String productoId;

    @NotBlank(message = "El nombre del insumo es obligatorio")
    @Size(min = 2, max = 100, message = "El nombre debe tener entre 2 y 100 caracteres")
    private String nombre;

    @NotNull(message = "La cantidad es obligatoria")
    @Min(value = 1, message = "La cantidad debe ser mayor a 0")
    @Max(value = 1000000, message = "La cantidad no puede exceder 1,000,000")
    private Integer cantidad;

    @NotNull(message = "El costo unitario es obligatorio")
    @DecimalMin(value = "0.01", message = "El costo debe ser mayor a 0")
    @DecimalMax(value = "10000000.0", message = "El costo no puede exceder $10,000,000")
    @JsonProperty("costoUnitario")
    private Double costoUnitario;

    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    @JsonProperty("fechaCompra")
    private LocalDateTime fechaCompra;

    @NotBlank(message = "El proveedor es obligatorio")
    @Size(min = 2, max = 100, message = "El proveedor debe tener entre 2 y 100 caracteres")
    private String proveedor;

    @NotBlank(message = "El tipo de insumo es obligatorio")
    @Pattern(regexp = "FERTILIZANTE|SEMILLA|PESTICIDA|HERRAMIENTA",
             message = "El tipo debe ser: FERTILIZANTE, SEMILLA, PESTICIDA o HERRAMIENTA")
    private String tipo;

    // Atributos opcionales
    @Size(max = 500, message = "La descripción no puede exceder 500 caracteres")
    private String descripcion;

    @Size(max = 20, message = "La unidad de medida no puede exceder 20 caracteres")
    @JsonProperty("unidadMedida")
    private String unidadMedida;

    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    @JsonProperty("fechaVencimiento")
    private LocalDateTime fechaVencimiento;

    @Size(max = 50, message = "El lote no puede exceder 50 caracteres")
    private String lote;

    private Boolean activo;

    // ===== CONSTRUCTORES =====

    public InsumoRequestDTO() {
        this.activo = true;
        this.fechaCompra = LocalDateTime.now();
    }

    // ===== BUILDER PATTERN =====

    public static Builder builder() {
        return new Builder();
    }

    public static class Builder {
        private InsumoRequestDTO dto = new InsumoRequestDTO();

        public Builder productoId(String productoId) {
            dto.productoId = productoId;
            return this;
        }

        public Builder nombre(String nombre) {
            dto.nombre = nombre;
            return this;
        }

        public Builder cantidad(Integer cantidad) {
            dto.cantidad = cantidad;
            return this;
        }

        public Builder costoUnitario(Double costoUnitario) {
            dto.costoUnitario = costoUnitario;
            return this;
        }

        public Builder fechaCompra(LocalDateTime fechaCompra) {
            dto.fechaCompra = fechaCompra;
            return this;
        }

        public Builder proveedor(String proveedor) {
            dto.proveedor = proveedor;
            return this;
        }

        public Builder tipo(String tipo) {
            dto.tipo = tipo;
            return this;
        }

        public Builder descripcion(String descripcion) {
            dto.descripcion = descripcion;
            return this;
        }

        public Builder unidadMedida(String unidadMedida) {
            dto.unidadMedida = unidadMedida;
            return this;
        }

        public Builder fechaVencimiento(LocalDateTime fechaVencimiento) {
            dto.fechaVencimiento = fechaVencimiento;
            return this;
        }

        public Builder lote(String lote) {
            dto.lote = lote;
            return this;
        }

        public Builder activo(Boolean activo) {
            dto.activo = activo;
            return this;
        }

        public InsumoRequestDTO build() {
            return dto;
        }
    }

    // ===== GETTERS Y SETTERS =====

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

    @Override
    public String toString() {
        return String.format("InsumoRequestDTO{nombre='%s', tipo='%s', cantidad=%d, productoId='%s'}",
                nombre, tipo, cantidad, productoId);
    }
}
