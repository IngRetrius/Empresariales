package co.unibague.agropecuario.insumos.dto.response;

import com.fasterxml.jackson.annotation.JsonFormat;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.datatype.jsr310.deser.LocalDateTimeDeserializer;
import java.time.LocalDateTime;

/**
 * DTO para respuesta de verificación de integridad referencial
 * Usado para validar la existencia de ProductoAgricola en Microservicio A-B
 *
 * Universidad de Ibagué - Microservicio C
 */
public class IntegridadResponseDTO {

    private String entidad;
    private String id;
    private Boolean existe;
    private String nombre;
    private Boolean activo;

    @JsonDeserialize(using = LocalDateTimeDeserializer.class)
    private LocalDateTime timestamp;

    @JsonProperty("mensaje")
    private String mensaje;

    // ===== CONSTRUCTORES =====

    public IntegridadResponseDTO() {
        this.timestamp = LocalDateTime.now();
    }

    public IntegridadResponseDTO(String entidad, String id, Boolean existe) {
        this();
        this.entidad = entidad;
        this.id = id;
        this.existe = existe;
    }

    // ===== GETTERS Y SETTERS =====

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

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }

    public LocalDateTime getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(LocalDateTime timestamp) {
        this.timestamp = timestamp;
    }

    public String getMensaje() {
        return mensaje;
    }

    public void setMensaje(String mensaje) {
        this.mensaje = mensaje;
    }
}
