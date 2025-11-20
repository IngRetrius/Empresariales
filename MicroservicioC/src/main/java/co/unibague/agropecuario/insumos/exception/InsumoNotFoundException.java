package co.unibague.agropecuario.insumos.exception;

/**
 * Excepción lanzada cuando un insumo no es encontrado
 * Universidad de Ibagué - Microservicio C
 */
public class InsumoNotFoundException extends RuntimeException {

    public InsumoNotFoundException(String message) {
        super(message);
    }

    public InsumoNotFoundException(String message, Throwable cause) {
        super(message, cause);
    }

    public static InsumoNotFoundException porId(String id) {
        return new InsumoNotFoundException("Insumo no encontrado con ID: " + id);
    }
}
