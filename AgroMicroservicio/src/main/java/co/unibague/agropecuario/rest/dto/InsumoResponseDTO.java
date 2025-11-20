package co.unibague.agropecuario.rest.dto;

import com.fasterxml.jackson.annotation.JsonInclude;

import java.time.LocalDateTime;

/**
 * DTO para recibir respuestas del Microservicio C (Insumos)
 * Universidad de Ibagué - Microservicio A-B
 * Etapa 2: Integración entre microservicios
 */
@JsonInclude(JsonInclude.Include.NON_NULL)
public class InsumoResponseDTO {

    private String id;
    private String productoId;
    private String nombre;
    private Integer cantidad;
    private Double costoUnitario;
    private LocalDateTime fechaCompra;
    private String proveedor;
    private String tipo;
    private String descripcion;
    private String unidadMedida;
    private Integer stockMinimo;
    private String ubicacionAlmacen;
    private LocalDateTime fechaVencimiento;
    private String lote;

    // Campos calculados
    private Double costoTotal;
    private Boolean estaVencido;
    private Boolean stockBajo;

    // Constructor vacío
    public InsumoResponseDTO() {
    }

    // Getters y Setters
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

    public Integer getStockMinimo() {
        return stockMinimo;
    }

    public void setStockMinimo(Integer stockMinimo) {
        this.stockMinimo = stockMinimo;
    }

    public String getUbicacionAlmacen() {
        return ubicacionAlmacen;
    }

    public void setUbicacionAlmacen(String ubicacionAlmacen) {
        this.ubicacionAlmacen = ubicacionAlmacen;
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

    public Boolean getStockBajo() {
        return stockBajo;
    }

    public void setStockBajo(Boolean stockBajo) {
        this.stockBajo = stockBajo;
    }

    @Override
    public String toString() {
        return "InsumoResponseDTO{" +
                "id='" + id + '\'' +
                ", productoId='" + productoId + '\'' +
                ", nombre='" + nombre + '\'' +
                ", cantidad=" + cantidad +
                ", tipo='" + tipo + '\'' +
                ", costoTotal=" + costoTotal +
                '}';
    }
}
