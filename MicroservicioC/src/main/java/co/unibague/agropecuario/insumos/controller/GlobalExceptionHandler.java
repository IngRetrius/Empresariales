package co.unibague.agropecuario.insumos.controller;

import co.unibague.agropecuario.insumos.dto.response.ApiResponseDTO;
import co.unibague.agropecuario.insumos.dto.response.ErrorResponseDTO;
import co.unibague.agropecuario.insumos.exception.InsumoAlreadyExistsException;
import co.unibague.agropecuario.insumos.exception.InsumoNotFoundException;
import co.unibague.agropecuario.insumos.exception.MicroserviceClientException;
import co.unibague.agropecuario.insumos.exception.ValidationException;
import co.unibague.agropecuario.insumos.utils.ResponseBuilder;
import jakarta.servlet.http.HttpServletRequest;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.RestControllerAdvice;

import java.util.HashMap;
import java.util.Map;

/**
 * Manejador global de excepciones
 * Universidad de Ibagué - Microservicio C
 */
@RestControllerAdvice
public class GlobalExceptionHandler {

    private static final Logger logger = LoggerFactory.getLogger(GlobalExceptionHandler.class);

    @ExceptionHandler(InsumoNotFoundException.class)
    public ResponseEntity<ApiResponseDTO<Void>> handleInsumoNotFound(
            InsumoNotFoundException ex, HttpServletRequest request) {
        logger.error("Insumo no encontrado: {}", ex.getMessage());
        return ResponseEntity.status(HttpStatus.NOT_FOUND)
                .body(ResponseBuilder.error(ex.getMessage()));
    }

    @ExceptionHandler(InsumoAlreadyExistsException.class)
    public ResponseEntity<ApiResponseDTO<Void>> handleInsumoAlreadyExists(
            InsumoAlreadyExistsException ex, HttpServletRequest request) {
        logger.error("Insumo ya existe: {}", ex.getMessage());
        return ResponseEntity.status(HttpStatus.CONFLICT)
                .body(ResponseBuilder.error(ex.getMessage()));
    }

    @ExceptionHandler(ValidationException.class)
    public ResponseEntity<ApiResponseDTO<Void>> handleValidation(
            ValidationException ex, HttpServletRequest request) {
        logger.error("Error de validación: {}", ex.getMessage());
        return ResponseEntity.status(HttpStatus.BAD_REQUEST)
                .body(ResponseBuilder.error(ex.getMessage()));
    }

    @ExceptionHandler(MicroserviceClientException.class)
    public ResponseEntity<ApiResponseDTO<Void>> handleMicroserviceClient(
            MicroserviceClientException ex, HttpServletRequest request) {
        logger.error("Error al comunicarse con {}: {}", ex.getMicroservicio(), ex.getMessage());
        return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(ResponseBuilder.error("Error al comunicarse con " + ex.getMicroservicio() + ": " + ex.getMessage()));
    }

    @ExceptionHandler(MethodArgumentNotValidException.class)
    public ResponseEntity<ApiResponseDTO<Map<String, String>>> handleValidationErrors(
            MethodArgumentNotValidException ex, HttpServletRequest request) {
        logger.error("Errores de validación en campos: {}", ex.getBindingResult().getFieldErrorCount());

        Map<String, String> errors = new HashMap<>();
        ex.getBindingResult().getFieldErrors().forEach(error ->
                errors.put(error.getField(), error.getDefaultMessage())
        );

        return ResponseEntity.status(HttpStatus.BAD_REQUEST)
                .body(ResponseBuilder.error("Errores de validación", errors));
    }

    @ExceptionHandler(IllegalArgumentException.class)
    public ResponseEntity<ApiResponseDTO<Void>> handleIllegalArgument(
            IllegalArgumentException ex, HttpServletRequest request) {
        logger.error("Argumento ilegal: {}", ex.getMessage());
        return ResponseEntity.status(HttpStatus.BAD_REQUEST)
                .body(ResponseBuilder.error(ex.getMessage()));
    }

    @ExceptionHandler(Exception.class)
    public ResponseEntity<ApiResponseDTO<Void>> handleGenericException(
            Exception ex, HttpServletRequest request) {
        logger.error("Error inesperado: {}", ex.getMessage(), ex);
        return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR)
                .body(ResponseBuilder.error("Error interno del servidor: " + ex.getMessage()));
    }
}
