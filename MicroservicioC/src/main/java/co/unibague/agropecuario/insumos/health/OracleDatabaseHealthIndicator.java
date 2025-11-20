package co.unibague.agropecuario.insumos.health;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.actuate.health.Health;
import org.springframework.boot.actuate.health.HealthIndicator;
import org.springframework.stereotype.Component;

import javax.sql.DataSource;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.time.LocalDateTime;

/**
 * Health Indicator personalizado para Base de Datos Oracle
 * Verifica conectividad y estado de la base de datos
 * Universidad de Ibagué - Microservicio C
 * Etapa 3: Health Checks
 */
@Component
public class OracleDatabaseHealthIndicator implements HealthIndicator {

    private static final Logger logger = LoggerFactory.getLogger(OracleDatabaseHealthIndicator.class);

    @Autowired
    private DataSource dataSource;

    @Override
    public Health health() {
        try {
            logger.debug("Verificando salud de la base de datos Oracle");

            long startTime = System.currentTimeMillis();

            try (Connection connection = dataSource.getConnection()) {
                // Verificar que la conexión esté activa
                if (!connection.isValid(2)) {
                    throw new RuntimeException("Conexión a la base de datos no es válida");
                }

                // Ejecutar query simple para verificar funcionamiento
                try (Statement statement = connection.createStatement()) {
                    ResultSet resultSet = statement.executeQuery("SELECT 1 FROM DUAL");
                    if (!resultSet.next()) {
                        throw new RuntimeException("No se pudo ejecutar query de prueba");
                    }
                }

                // Obtener información de la base de datos
                String databaseProductName = connection.getMetaData().getDatabaseProductName();
                String databaseProductVersion = connection.getMetaData().getDatabaseProductVersion();
                String url = connection.getMetaData().getURL();
                String userName = connection.getMetaData().getUserName();

                long responseTime = System.currentTimeMillis() - startTime;

                logger.info("Base de datos Oracle está disponible ({}ms)", responseTime);

                return Health.up()
                        .withDetail("database", databaseProductName)
                        .withDetail("version", databaseProductVersion)
                        .withDetail("url", url)
                        .withDetail("user", userName)
                        .withDetail("status", "UP")
                        .withDetail("responseTime", responseTime + "ms")
                        .withDetail("timestamp", LocalDateTime.now())
                        .withDetail("message", "Conexión a Oracle activa y funcionando correctamente")
                        .build();
            }

        } catch (Exception e) {
            logger.error("Error al verificar salud de Oracle: {}", e.getMessage());

            return Health.down()
                    .withDetail("database", "Oracle")
                    .withDetail("status", "DOWN")
                    .withDetail("error", e.getClass().getSimpleName())
                    .withDetail("message", e.getMessage())
                    .withDetail("timestamp", LocalDateTime.now())
                    .withDetail("advice", "Verificar que Oracle esté corriendo y las credenciales sean correctas")
                    .build();
        }
    }
}
