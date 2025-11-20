package co.unibague.agropecuario.insumos.exception;

/**
 * Excepción lanzada cuando falla la validación de datos de negocio
 * Universidad de Ibagué - Microservicio C
 */
public class ValidationException extends RuntimeException {

    public ValidationException(String message) {
        super(message);
    }

    public ValidationException(String message, Throwable cause) {
        super(message, cause);
    }
}
