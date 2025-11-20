package co.unibague.agropecuario.insumos.dto.request;

import com.fasterxml.jackson.annotation.JsonProperty;
import jakarta.validation.constraints.NotBlank;

/**
 * DTO para solicitud de verificación de integridad referencial
 * Universidad de Ibagué - Microservicio C
 */
public class IntegridadRequestDTO {

    @NotBlank(message = "El ID del producto es obligatorio")
    @JsonProperty("productoId")
    private String productoId;

    private String entidad;

    // ===== CONSTRUCTORES =====

    public IntegridadRequestDTO() {
    }

    public IntegridadRequestDTO(String productoId) {
        this.productoId = productoId;
        this.entidad = "ProductoAgricola";
    }

    // ===== GETTERS Y SETTERS =====

    public String getProductoId() {
        return productoId;
    }

    public void setProductoId(String productoId) {
        this.productoId = productoId;
    }

    public String getEntidad() {
        return entidad;
    }

    public void setEntidad(String entidad) {
        this.entidad = entidad;
    }
}
