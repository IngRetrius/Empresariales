package co.unibague.agropecuario.rest.controller;

import co.unibague.agropecuario.rest.dto.ApiResponseDTO;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.reactive.function.client.WebClient;
import reactor.core.publisher.Mono;

import java.time.Duration;
import java.util.List;
import java.util.Map;

/**
 * Controlador Proxy para redireccionar peticiones de Insumos al Microservicio C
 * Actúa como gateway para que los clientes no necesiten conocer la URL del Microservicio C
 */
@RestController
@RequestMapping("/api/insumos")
@CrossOrigin(origins = "*")
public class InsumoProxyController {

    private static final Logger logger = LoggerFactory.getLogger(InsumoProxyController.class);

    private final WebClient webClient;

    @Value("${app.microservicio-c.base-url:http://localhost:8082}")
    private String microservicioCBaseUrl;

    @Value("${app.microservicio-c.timeout-ms:5000}")
    private int timeoutMs;

    public InsumoProxyController(WebClient.Builder webClientBuilder,
                                  @Value("${app.microservicio-c.base-url:http://localhost:8082}") String baseUrl) {
        this.microservicioCBaseUrl = baseUrl;
        this.webClient = webClientBuilder.baseUrl(baseUrl).build();
        logger.info("InsumoProxyController inicializado. Microservicio C URL: {}", baseUrl);
    }

    /**
     * GET /api/insumos - Obtener todos los insumos
     */
    @GetMapping
    public ResponseEntity<?> obtenerTodosLosInsumos() {
        logger.info("Proxy: Redirigiendo solicitud GET /api/insumos al Microservicio C");

        try {
            Object response = webClient
                .get()
                .uri("/api/insumos")
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Respuesta exitosa recibida del Microservicio C");
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al comunicarse con Microservicio C: {}", e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al comunicarse con el servicio de insumos: " + e.getMessage(),
                    "microservicioC", microservicioCBaseUrl
                ));
        }
    }

    /**
     * GET /api/insumos/{id} - Obtener insumo por ID
     */
    @GetMapping("/{id}")
    public ResponseEntity<?> obtenerInsumoPorId(@PathVariable String id) {
        logger.info("Proxy: Redirigiendo solicitud GET /api/insumos/{} al Microservicio C", id);

        try {
            Object response = webClient
                .get()
                .uri("/api/insumos/{id}", id)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumo {} recuperado exitosamente del Microservicio C", id);
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al obtener insumo {}: {}", id, e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al obtener el insumo: " + e.getMessage(),
                    "insumoId", id
                ));
        }
    }

    /**
     * POST /api/insumos - Crear nuevo insumo
     */
    @PostMapping
    public ResponseEntity<?> crearInsumo(@RequestBody Object insumoRequest) {
        logger.info("Proxy: Redirigiendo solicitud POST /api/insumos al Microservicio C");

        try {
            Object response = webClient
                .post()
                .uri("/api/insumos")
                .bodyValue(insumoRequest)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumo creado exitosamente en Microservicio C");
            return ResponseEntity.status(HttpStatus.CREATED).body(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al crear insumo: {}", e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al crear el insumo: " + e.getMessage()
                ));
        }
    }

    /**
     * PUT /api/insumos/{id} - Actualizar insumo
     */
    @PutMapping("/{id}")
    public ResponseEntity<?> actualizarInsumo(@PathVariable String id, @RequestBody Object insumoRequest) {
        logger.info("Proxy: Redirigiendo solicitud PUT /api/insumos/{} al Microservicio C", id);

        try {
            Object response = webClient
                .put()
                .uri("/api/insumos/{id}", id)
                .bodyValue(insumoRequest)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumo {} actualizado exitosamente en Microservicio C", id);
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al actualizar insumo {}: {}", id, e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al actualizar el insumo: " + e.getMessage(),
                    "insumoId", id
                ));
        }
    }

    /**
     * DELETE /api/insumos/{id} - Eliminar insumo
     */
    @DeleteMapping("/{id}")
    public ResponseEntity<?> eliminarInsumo(@PathVariable String id) {
        logger.info("Proxy: Redirigiendo solicitud DELETE /api/insumos/{} al Microservicio C", id);

        try {
            Object response = webClient
                .delete()
                .uri("/api/insumos/{id}", id)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumo {} eliminado exitosamente en Microservicio C", id);
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al eliminar insumo {}: {}", id, e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al eliminar el insumo: " + e.getMessage(),
                    "insumoId", id
                ));
        }
    }

    /**
     * GET /api/insumos/producto/{productoId} - Obtener insumos por producto
     */
    @GetMapping("/producto/{productoId}")
    public ResponseEntity<?> obtenerInsumosPorProducto(@PathVariable String productoId) {
        logger.info("Proxy: Redirigiendo solicitud GET /api/insumos/producto/{} al Microservicio C", productoId);

        try {
            Object response = webClient
                .get()
                .uri("/api/insumos/producto/{productoId}", productoId)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumos del producto {} recuperados exitosamente del Microservicio C", productoId);
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al obtener insumos del producto {}: {}", productoId, e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al obtener insumos del producto: " + e.getMessage(),
                    "productoId", productoId
                ));
        }
    }

    /**
     * GET /api/insumos/tipo/{tipo} - Buscar insumos por tipo
     */
    @GetMapping("/tipo/{tipo}")
    public ResponseEntity<?> buscarInsumosPorTipo(@PathVariable String tipo) {
        logger.info("Proxy: Redirigiendo solicitud GET /api/insumos/tipo/{} al Microservicio C", tipo);

        try {
            Object response = webClient
                .get()
                .uri("/api/insumos/tipo/{tipo}", tipo)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumos de tipo {} recuperados exitosamente del Microservicio C", tipo);
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al buscar insumos por tipo {}: {}", tipo, e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al buscar insumos por tipo: " + e.getMessage(),
                    "tipo", tipo
                ));
        }
    }

    /**
     * GET /api/insumos/proveedor/{proveedor} - Buscar insumos por proveedor
     */
    @GetMapping("/proveedor/{proveedor}")
    public ResponseEntity<?> buscarInsumosPorProveedor(@PathVariable String proveedor) {
        logger.info("Proxy: Redirigiendo solicitud GET /api/insumos/proveedor/{} al Microservicio C", proveedor);

        try {
            Object response = webClient
                .get()
                .uri("/api/insumos/proveedor/{proveedor}", proveedor)
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Insumos del proveedor {} recuperados exitosamente del Microservicio C", proveedor);
            return ResponseEntity.ok(response);
        } catch (Exception e) {
            logger.error("Proxy: Error al buscar insumos por proveedor {}: {}", proveedor, e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "success", false,
                    "message", "Error al buscar insumos por proveedor: " + e.getMessage(),
                    "proveedor", proveedor
                ));
        }
    }

    /**
     * GET /api/insumos/health - Verificar disponibilidad del Microservicio C
     */
    @GetMapping("/health")
    public ResponseEntity<?> verificarDisponibilidad() {
        logger.info("Proxy: Verificando disponibilidad del Microservicio C");

        try {
            webClient
                .get()
                .uri("/api/insumos")
                .retrieve()
                .bodyToMono(Object.class)
                .timeout(Duration.ofMillis(timeoutMs))
                .block();

            logger.info("Proxy: Microservicio C está disponible");
            return ResponseEntity.ok(Map.of(
                "status", "UP",
                "microservicioC", microservicioCBaseUrl,
                "mensaje", "Microservicio C está disponible y respondiendo correctamente"
            ));
        } catch (Exception e) {
            logger.error("Proxy: Microservicio C no está disponible: {}", e.getMessage());
            return ResponseEntity.status(HttpStatus.SERVICE_UNAVAILABLE)
                .body(Map.of(
                    "status", "DOWN",
                    "microservicioC", microservicioCBaseUrl,
                    "mensaje", "Microservicio C no está disponible: " + e.getMessage()
                ));
        }
    }
}
