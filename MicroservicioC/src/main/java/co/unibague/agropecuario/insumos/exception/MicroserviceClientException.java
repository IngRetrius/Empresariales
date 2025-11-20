package co.unibague.agropecuario.insumos.exception;

/**
 * Excepción lanzada cuando falla la comunicación con otro microservicio
 * Universidad de Ibagué - Microservicio C
 */
public class MicroserviceClientException extends RuntimeException {

    private final String microservicio;

    public MicroserviceClientException(String microservicio, String message) {
        super(message);
        this.microservicio = microservicio;
    }

    public MicroserviceClientException(String microservicio, String message, Throwable cause) {
        super(message, cause);
        this.microservicio = microservicio;
    }

    public String getMicroservicio() {
        return microservicio;
    }
}
