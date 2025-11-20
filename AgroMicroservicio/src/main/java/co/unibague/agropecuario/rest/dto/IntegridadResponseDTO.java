package co.unibague.agropecuario.rest.dto;

import com.fasterxml.jackson.annotation.JsonInclude;

import java.time.LocalDateTime;

/**
 * DTO para respuestas de verificación de integridad referencial
 * Usado para comunicación entre Microservicio A-B y Microservicio C
 * Universidad de Ibagué - Microservicio A-B
 */
@JsonInclude(JsonInclude.Include.NON_NULL)
public class IntegridadResponseDTO {

    private String entidad;
    private String id;
    private Boolean existe;
    private String nombre;
    private LocalDateTime timestamp;

    // Constructor vacío
    public IntegridadResponseDTO() {
        this.timestamp = LocalDateTime.now();
    }

    // Constructor completo
    public IntegridadResponseDTO(String entidad, String id, Boolean existe, String nombre) {
        this.entidad = entidad;
        this.id = id;
        this.existe = existe;
        this.nombre = nombre;
        this.timestamp = LocalDateTime.now();
    }

    // Builder pattern
    public static Builder builder() {
        return new Builder();
    }

    public static class Builder {
        private String entidad;
        private String id;
        private Boolean existe;
        private String nombre;

        public Builder entidad(String entidad) {
            this.entidad = entidad;
            return this;
        }

        public Builder id(String id) {
            this.id = id;
            return this;
        }

        public Builder existe(Boolean existe) {
            this.existe = existe;
            return this;
        }

        public Builder nombre(String nombre) {
            this.nombre = nombre;
            return this;
        }

        public IntegridadResponseDTO build() {
            return new IntegridadResponseDTO(entidad, id, existe, nombre);
        }
    }

    // Getters y Setters
    public String getEntidad() {
        return entidad;
    }

    public void setEntidad(String entidad) {
        this.entidad = entidad;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Boolean getExiste() {
        return existe;
    }

    public void setExiste(Boolean existe) {
        this.existe = existe;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public LocalDateTime getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(LocalDateTime timestamp) {
        this.timestamp = timestamp;
    }

    @Override
    public String toString() {
        return "IntegridadResponseDTO{" +
                "entidad='" + entidad + '\'' +
                ", id='" + id + '\'' +
                ", existe=" + existe +
                ", nombre='" + nombre + '\'' +
                ", timestamp=" + timestamp +
                '}';
    }
}
