package co.unibague.agropecuario.rest.dto;

import jakarta.validation.constraints.NotBlank;

/**
 * DTO para solicitudes de verificación de integridad referencial
 * Usado para comunicación entre Microservicio A-B y Microservicio C
 * Universidad de Ibagué - Microservicio A-B
 */
public class IntegridadRequestDTO {

    @NotBlank(message = "El ID de la entidad es obligatorio")
    private String entidadId;

    @NotBlank(message = "El tipo de entidad es obligatorio")
    private String tipoEntidad;

    // Constructor vacío
    public IntegridadRequestDTO() {
    }

    // Constructor completo
    public IntegridadRequestDTO(String entidadId, String tipoEntidad) {
        this.entidadId = entidadId;
        this.tipoEntidad = tipoEntidad;
    }

    // Builder pattern
    public static Builder builder() {
        return new Builder();
    }

    public static class Builder {
        private String entidadId;
        private String tipoEntidad;

        public Builder entidadId(String entidadId) {
            this.entidadId = entidadId;
            return this;
        }

        public Builder tipoEntidad(String tipoEntidad) {
            this.tipoEntidad = tipoEntidad;
            return this;
        }

        public IntegridadRequestDTO build() {
            return new IntegridadRequestDTO(entidadId, tipoEntidad);
        }
    }

    // Getters y Setters
    public String getEntidadId() {
        return entidadId;
    }

    public void setEntidadId(String entidadId) {
        this.entidadId = entidadId;
    }

    public String getTipoEntidad() {
        return tipoEntidad;
    }

    public void setTipoEntidad(String tipoEntidad) {
        this.tipoEntidad = tipoEntidad;
    }

    @Override
    public String toString() {
        return "IntegridadRequestDTO{" +
                "entidadId='" + entidadId + '\'' +
                ", tipoEntidad='" + tipoEntidad + '\'' +
                '}';
    }
}
