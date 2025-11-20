package co.unibague.agropecuario.insumos;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

/**
 * Clase principal del Microservicio C - Gestión de Insumos Agrícolas
 * Universidad de Ibagué - Desarrollo de Aplicaciones Empresariales
 * Tercer Proyecto 2025B
 *
 * Puerto: 8082
 * Base de Datos: Oracle
 *
 * @author Universidad de Ibagué
 * @version 1.0.0
 */
@SpringBootApplication
public class MicroservicioInsumoApplication {

    public static void main(String[] args) {
        SpringApplication.run(MicroservicioInsumoApplication.class, args);
        System.out.println("\n===========================================");
        System.out.println("MICROSERVICIO C - INSUMOS AGRÍCOLAS");
        System.out.println("Universidad de Ibagué");
        System.out.println("Puerto: 8082");
        System.out.println("Base de Datos: Oracle");
        System.out.println("API: http://localhost:8082/api/insumos");
        System.out.println("===========================================\n");
    }
}
