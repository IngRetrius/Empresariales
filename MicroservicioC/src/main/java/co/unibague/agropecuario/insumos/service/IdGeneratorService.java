package co.unibague.agropecuario.insumos.service;

import org.springframework.stereotype.Service;

import java.util.concurrent.atomic.AtomicInteger;

/**
 * Servicio para generar IDs únicos
 * Universidad de Ibagué - Microservicio C
 */
@Service
public class IdGeneratorService {

    private final AtomicInteger contador = new AtomicInteger(0);

    /**
     * Genera un ID único con el prefijo especificado
     * Formato: PREFIJO + número con padding de 3 dígitos
     * Ejemplo: INS001, INS002, etc.
     *
     * @param prefijo Prefijo del ID (ej: "INS")
     * @return ID generado
     */
    public synchronized String generarId(String prefijo) {
        int numero = contador.incrementAndGet();
        return String.format("%s%03d", prefijo, numero);
    }

    /**
     * Genera un ID para insumo
     * @return ID con formato INS001
     */
    public String generarIdInsumo() {
        return generarId("INS");
    }

    /**
     * Reinicia el contador (útil para testing)
     */
    public void reiniciarContador() {
        contador.set(0);
    }

    /**
     * Obtiene el valor actual del contador
     */
    public int getContadorActual() {
        return contador.get();
    }
}
