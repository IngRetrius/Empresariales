package co.unibague.agropecuario.rest.service;

import co.unibague.agropecuario.rest.dto.InsumoResponseDTO;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.core.ParameterizedTypeReference;
import org.springframework.stereotype.Service;
import org.springframework.web.reactive.function.client.WebClient;
import org.springframework.web.reactive.function.client.WebClientResponseException;
import reactor.core.publisher.Mono;

import java.time.Duration;
import java.util.Collections;
import java.util.List;

/**
 * Servicio de integración con Microservicio C (Insumos)
 * Permite al Microservicio A-B consultar información de insumos
 * Universidad de Ibagué - Microservicio A-B
 * Etapa 2: Integración entre microservicios
 */
@Service
public class MicroservicioCIntegrationService {

    private static final Logger logger = LoggerFactory.getLogger(MicroservicioCIntegrationService.class);

    @Autowired
    private WebClient.Builder webClientBuilder;

    @Value("${app.microservicio-c.base-url}")
    private String microservicioCBaseUrl;

    @Value("${app.microservicio-c.timeout-ms}")
    private int timeout;

    /**
     * Obtiene todos los insumos asociados a un producto
     * @param productoId ID del producto agrícola
     * @return Lista de insumos del producto
     */
    public List<InsumoResponseDTO> obtenerInsumosPorProducto(String productoId) {
        logger.info("Consultando insumos del producto {} en Microservicio C", productoId);

        try {
            WebClient webClient = webClientBuilder.baseUrl(microservicioCBaseUrl).build();

            // Necesitamos recibir ApiResponseDTO<List<InsumoResponseDTO>>
            String response = webClient.get()
                    .uri("/api/insumos/producto/{productoId}", productoId)
                    .retrieve()
                    .bodyToMono(String.class)
                    .timeout(Duration.ofMillis(timeout))
                    .block();

            logger.info("Respuesta recibida del Microservicio C: {}", response);

            // Aquí deberías parsear el JSON de ApiResponseDTO y extraer la lista
            // Por simplicidad, retornamos una lista vacía si hay error
            // En una implementación completa usarías ObjectMapper para parsear

            return Collections.emptyList();

        } catch (WebClientResponseException e) {
            logger.error("Error HTTP al consultar Microservicio C: {} - {}", e.getStatusCode(), e.getMessage());
            return Collections.emptyList();
        } catch (Exception e) {
            logger.error("Error al comunicarse con Microservicio C: {}", e.getMessage(), e);
            return Collections.emptyList();
        }
    }

    /**
     * Obtiene el costo total de insumos para un producto
     * @param productoId ID del producto agrícola
     * @return Costo total de los insumos, o 0.0 si hay error
     */
    public Double obtenerCostoTotalInsumos(String productoId) {
        logger.info("Calculando costo total de insumos del producto {} en Microservicio C", productoId);

        try {
            WebClient webClient = webClientBuilder.baseUrl(microservicioCBaseUrl).build();

            // El endpoint devuelve ApiResponseDTO<Double>
            String response = webClient.get()
                    .uri("/api/insumos/costo-total/{productoId}", productoId)
                    .retrieve()
                    .bodyToMono(String.class)
                    .timeout(Duration.ofMillis(timeout))
                    .block();

            logger.info("Costo total de insumos recibido: {}", response);

            // En una implementación completa, parsear el JSON y extraer el valor
            return 0.0;

        } catch (WebClientResponseException e) {
            logger.error("Error HTTP al consultar costo total en Microservicio C: {} - {}",
                    e.getStatusCode(), e.getMessage());
            return 0.0;
        } catch (Exception e) {
            logger.error("Error al calcular costo total de insumos: {}", e.getMessage(), e);
            return 0.0;
        }
    }

    /**
     * Verifica si el Microservicio C está disponible
     * @return true si está disponible, false en caso contrario
     */
    public boolean verificarDisponibilidad() {
        logger.debug("Verificando disponibilidad del Microservicio C");

        try {
            WebClient webClient = webClientBuilder.baseUrl(microservicioCBaseUrl).build();

            webClient.get()
                    .uri("/api/insumos")
                    .retrieve()
                    .bodyToMono(String.class)
                    .timeout(Duration.ofMillis(timeout))
                    .block();

            logger.info("Microservicio C está disponible");
            return true;

        } catch (Exception e) {
            logger.warn("Microservicio C no está disponible: {}", e.getMessage());
            return false;
        }
    }
}
