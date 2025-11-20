package co.unibague.agropecuario.insumos.exception;

/**
 * Excepción lanzada cuando se intenta crear un insumo que ya existe
 * Universidad de Ibagué - Microservicio C
 */
public class InsumoAlreadyExistsException extends RuntimeException {

    public InsumoAlreadyExistsException(String message) {
        super(message);
    }

    public InsumoAlreadyExistsException(String message, Throwable cause) {
        super(message, cause);
    }

    public static InsumoAlreadyExistsException porId(String id) {
        return new InsumoAlreadyExistsException("Ya existe un insumo con ID: " + id);
    }
}
