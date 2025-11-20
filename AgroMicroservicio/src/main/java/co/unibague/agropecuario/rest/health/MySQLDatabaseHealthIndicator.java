package co.unibague.agropecuario.rest.health;

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
 * Health Indicator personalizado para Base de Datos MySQL
 * Verifica conectividad y estado de la base de datos
 * Universidad de Ibagué - Microservicio A-B
 * Etapa 3: Health Checks
 */
@Component
public class MySQLDatabaseHealthIndicator implements HealthIndicator {

    private static final Logger logger = LoggerFactory.getLogger(MySQLDatabaseHealthIndicator.class);

    @Autowired
    private DataSource dataSource;

    @Override
    public Health health() {
        try {
            logger.debug("Verificando salud de la base de datos MySQL");

            long startTime = System.currentTimeMillis();

            try (Connection connection = dataSource.getConnection()) {
                // Verificar que la conexión esté activa
                if (!connection.isValid(2)) {
                    throw new RuntimeException("Conexión a la base de datos no es válida");
                }

                // Ejecutar query simple para verificar funcionamiento
                try (Statement statement = connection.createStatement()) {
                    ResultSet resultSet = statement.executeQuery("SELECT 1");
                    if (!resultSet.next()) {
                        throw new RuntimeException("No se pudo ejecutar query de prueba");
                    }
                }

                // Obtener información de la base de datos
                String databaseProductName = connection.getMetaData().getDatabaseProductName();
                String databaseProductVersion = connection.getMetaData().getDatabaseProductVersion();
                String url = connection.getMetaData().getURL();

                long responseTime = System.currentTimeMillis() - startTime;

                logger.info("Base de datos MySQL está disponible ({}ms)", responseTime);

                return Health.up()
                        .withDetail("database", databaseProductName)
                        .withDetail("version", databaseProductVersion)
                        .withDetail("url", url)
                        .withDetail("status", "UP")
                        .withDetail("responseTime", responseTime + "ms")
                        .withDetail("timestamp", LocalDateTime.now())
                        .withDetail("message", "Conexión a MySQL activa y funcionando correctamente")
                        .build();
            }

        } catch (Exception e) {
            logger.error("Error al verificar salud de MySQL: {}", e.getMessage());

            return Health.down()
                    .withDetail("database", "MySQL")
                    .withDetail("status", "DOWN")
                    .withDetail("error", e.getClass().getSimpleName())
                    .withDetail("message", e.getMessage())
                    .withDetail("timestamp", LocalDateTime.now())
                    .withDetail("advice", "Verificar que MySQL esté corriendo y las credenciales sean correctas")
                    .build();
        }
    }
}
