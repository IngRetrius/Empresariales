package co.unibague.agropecuario.insumos.dto.response;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.time.LocalDateTime;

/**
 * DTO para respuestas de insumos
 * Usado en operaciones GET
 *
 * Universidad de Ibagué - Microservicio C
 */
public class InsumoResponseDTO {

    private String id;

    @JsonProperty("productoId")
    private String productoId;

    private String nombre;

    private Integer cantidad;

    @JsonProperty("costoUnitario")
    private Double costoUnitario;

    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    @JsonProperty("fechaCompra")
    private LocalDateTime fechaCompra;

    private String proveedor;

    private String tipo;

    private String descripcion;

    @JsonProperty("unidadMedida")
    private String unidadMedida;

    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    @JsonProperty("fechaVencimiento")
    private LocalDateTime fechaVencimiento;

    private String lote;

    private Boolean activo;

    // Campos calculados
    @JsonProperty("costoTotal")
    private Double costoTotal;

    @JsonProperty("estaVencido")
    private Boolean estaVencido;

    @JsonProperty("proximoAVencer")
    private Boolean proximoAVencer;

    @JsonProperty("stockBajo")
    private Boolean stockBajo;

    // ===== CONSTRUCTORES =====

    public InsumoResponseDTO() {
    }

    // ===== BUILDER PATTERN =====

    public static Builder builder() {
        return new Builder();
    }

    public static class Builder {
        private InsumoResponseDTO dto = new InsumoResponseDTO();

        public Builder id(String id) {
            dto.id = id;
            return this;
        }

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

        public Builder costoTotal(Double costoTotal) {
            dto.costoTotal = costoTotal;
            return this;
        }

        public Builder estaVencido(Boolean estaVencido) {
            dto.estaVencido = estaVencido;
            return this;
        }

        public Builder proximoAVencer(Boolean proximoAVencer) {
            dto.proximoAVencer = proximoAVencer;
            return this;
        }

        public Builder stockBajo(Boolean stockBajo) {
            dto.stockBajo = stockBajo;
            return this;
        }

        public InsumoResponseDTO build() {
            return dto;
        }
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

    public Double getCostoTotal() {
        return costoTotal;
    }

    public void setCostoTotal(Double costoTotal) {
        this.costoTotal = costoTotal;
    }

    public Boolean getEstaVencido() {
        return estaVencido;
    }

    public void setEstaVencido(Boolean estaVencido) {
        this.estaVencido = estaVencido;
    }

    public Boolean getProximoAVencer() {
        return proximoAVencer;
    }

    public void setProximoAVencer(Boolean proximoAVencer) {
        this.proximoAVencer = proximoAVencer;
    }

    public Boolean getStockBajo() {
        return stockBajo;
    }

    public void setStockBajo(Boolean stockBajo) {
        this.stockBajo = stockBajo;
    }

    @Override
    public String toString() {
        return String.format("InsumoResponseDTO{id='%s', nombre='%s', tipo='%s', cantidad=%d}",
                id, nombre, tipo, cantidad);
    }
}
