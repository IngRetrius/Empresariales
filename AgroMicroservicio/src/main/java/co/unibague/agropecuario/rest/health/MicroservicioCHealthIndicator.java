package co.unibague.agropecuario.rest.health;

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
 * Health Indicator personalizado para Microservicio C (Insumos)
 * Verifica si el microservicio remoto está disponible y respondiendo
 * Universidad de Ibagué - Microservicio A-B
 * Etapa 3: Health Checks
 */
@Component
public class MicroservicioCHealthIndicator implements HealthIndicator {

    private static final Logger logger = LoggerFactory.getLogger(MicroservicioCHealthIndicator.class);

    @Autowired
    private WebClient.Builder webClientBuilder;

    @Value("${app.microservicio-c.base-url}")
    private String microservicioCBaseUrl;

    @Value("${app.microservicio-c.timeout-ms}")
    private int timeout;

    @Override
    public Health health() {
        try {
            logger.debug("Verificando salud del Microservicio C en: {}", microservicioCBaseUrl);

            WebClient webClient = webClientBuilder.baseUrl(microservicioCBaseUrl).build();

            long startTime = System.currentTimeMillis();

            // Intentar hacer un GET simple al endpoint base de insumos
            String response = webClient.get()
                    .uri("/api/insumos")
                    .retrieve()
                    .bodyToMono(String.class)
                    .timeout(Duration.ofMillis(timeout))
                    .block();

            long responseTime = System.currentTimeMillis() - startTime;

            logger.info("Microservicio C está disponible ({}ms)", responseTime);

            return Health.up()
                    .withDetail("microservicio", "Microservicio C - Insumos")
                    .withDetail("url", microservicioCBaseUrl)
                    .withDetail("status", "UP")
                    .withDetail("responseTime", responseTime + "ms")
                    .withDetail("timestamp", LocalDateTime.now())
                    .withDetail("message", "Microservicio C está disponible y respondiendo correctamente")
                    .build();

        } catch (Exception e) {
            logger.error("Error al verificar salud del Microservicio C: {}", e.getMessage());

            return Health.down()
                    .withDetail("microservicio", "Microservicio C - Insumos")
                    .withDetail("url", microservicioCBaseUrl)
                    .withDetail("status", "DOWN")
                    .withDetail("error", e.getClass().getSimpleName())
                    .withDetail("message", e.getMessage())
                    .withDetail("timestamp", LocalDateTime.now())
                    .withDetail("advice", "Verificar que Microservicio C esté corriendo en " + microservicioCBaseUrl)
                    .build();
        }
    }
}
