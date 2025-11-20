package co.unibague.agropecuario.insumos.utils;

import co.unibague.agropecuario.insumos.dto.response.ApiResponseDTO;
import co.unibague.agropecuario.insumos.dto.response.ErrorResponseDTO;

import java.time.LocalDateTime;
import java.util.Map;

/**
 * Builder para construcción de respuestas API consistentes
 * Universidad de Ibagué - Microservicio C
 */
public class ResponseBuilder {

    /**
     * Construye una respuesta exitosa
     */
    public static <T> ApiResponseDTO<T> success(String message, T data) {
        ApiResponseDTO<T> response = new ApiResponseDTO<>();
        response.setSuccess(true);
        response.setMessage(message);
        response.setData(data);
        response.setTimestamp(LocalDateTime.now());
        return response;
    }

    /**
     * Construye una respuesta de error simple
     */
    public static <T> ApiResponseDTO<T> error(String message) {
        ApiResponseDTO<T> response = new ApiResponseDTO<>();
        response.setSuccess(false);
        response.setMessage(message);
        response.setData(null);
        response.setTimestamp(LocalDateTime.now());
        return response;
    }

    /**
     * Construye una respuesta de error con detalles de validación
     */
    public static <T> ApiResponseDTO<T> error(String message, Map<String, String> validationErrors) {
        ApiResponseDTO<T> response = new ApiResponseDTO<>();
        response.setSuccess(false);
        response.setMessage(message);
        response.setData(null);
        response.setErrors(validationErrors);
        response.setTimestamp(LocalDateTime.now());
        return response;
    }

    /**
     * Construye un ErrorResponseDTO detallado
     */
    public static ErrorResponseDTO errorDetallado(Integer status, String error, String message, String path) {
        ErrorResponseDTO response = new ErrorResponseDTO();
        response.setStatus(status);
        response.setError(error);
        response.setMessage(message);
        response.setPath(path);
        response.setTimestamp(LocalDateTime.now());
        return response;
    }

    /**
     * Construye un ErrorResponseDTO con errores de validación
     */
    public static ErrorResponseDTO errorConValidacion(Integer status, String error, String message,
                                                       String path, Map<String, String> validationErrors) {
        ErrorResponseDTO response = errorDetallado(status, error, message, path);
        response.setValidationErrors(validationErrors);
        return response;
    }

    // Constructor privado
    private ResponseBuilder() {
        throw new IllegalStateException("Clase utilitaria - no instanciable");
    }
}
