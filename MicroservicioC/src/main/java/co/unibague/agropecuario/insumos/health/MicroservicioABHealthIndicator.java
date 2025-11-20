package co.unibague.agropecuario.insumos.health;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.boot.actuate.health.Health;
import org.springframework.boot.actuate.health.HealthIndicator;
import org.springframework.stereotype.Component;
import org.springframework.web.reactive.function.client.WebClient;

import java.time.Duration;
import java.time.LocalDateTime;

/**
 * Health Indicator personalizado para Microservicio A-B (Productos y Cosechas)
 * Verifica si el microservicio remoto está disponible y respondiendo
 * Universidad de Ibagué - Microservicio C
 * Etapa 3: Health Checks
 */
@Component
public class MicroservicioABHealthIndicator implements HealthIndicator {

    private static final Logger logger = LoggerFactory.getLogger(MicroservicioABHealthIndicator.class);

    @Autowired
    private WebClient.Builder webClientBuilder;

    @Value("${app.microservicio-ab.base-url}")
    private String microservicioABBaseUrl;

    @Value("${app.microservicio-ab.timeout}")
    private int timeout;

    @Override
    public Health health() {
        try {
            logger.debug("Verificando salud del Microservicio A-B en: {}", microservicioABBaseUrl);

            WebClient webClient = webClientBuilder.baseUrl(microservicioABBaseUrl).build();

            long startTime = System.currentTimeMillis();

            // Intentar hacer un GET simple al endpoint base de productos
            String response = webClient.get()
                    .uri("/api/productos")
                    .retrieve()
                    .bodyToMono(String.class)
                    .timeout(Duration.ofMillis(timeout))
                    .block();

            long responseTime = System.currentTimeMillis() - startTime;

            logger.info("Microservicio A-B está disponible ({}ms)", responseTime);

            return Health.up()
                    .withDetail("microservicio", "Microservicio A-B - Productos y Cosechas")
                    .withDetail("url", microservicioABBaseUrl)
                    .withDetail("status", "UP")
                    .withDetail("responseTime", responseTime + "ms")
                    .withDetail("timestamp", LocalDateTime.now())
                    .withDetail("message", "Microservicio A-B está disponible y respondiendo correctamente")
                    .withDetail("integration", "Validación de integridad referencial activa")
                    .build();

        } catch (Exception e) {
            logger.error("Error al verificar salud del Microservicio A-B: {}", e.getMessage());

            return Health.down()
                    .withDetail("microservicio", "Microservicio A-B - Productos y Cosechas")
                    .withDetail("url", microservicioABBaseUrl)
                    .withDetail("status", "DOWN")
                    .withDetail("error", e.getClass().getSimpleName())
                    .withDetail("message", e.getMessage())
                    .withDetail("timestamp", LocalDateTime.now())
                    .withDetail("advice", "Verificar que Microservicio A-B esté corriendo en " + microservicioABBaseUrl)
                    .withDetail("impact", "No se podrá validar integridad referencial de productos")
                    .build();
        }
    }
}
