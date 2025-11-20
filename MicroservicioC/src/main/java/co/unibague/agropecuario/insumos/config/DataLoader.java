package co.unibague.agropecuario.insumos.config;

import co.unibague.agropecuario.insumos.model.Insumo;
import co.unibague.agropecuario.insumos.repository.InsumoJpaRepository;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import java.time.LocalDateTime;

/**
 * Carga datos iniciales en la base de datos
 * Universidad de Ibagué - Microservicio C
 */
@Component
public class DataLoader implements CommandLineRunner {

    private static final Logger logger = LoggerFactory.getLogger(DataLoader.class);

    @Autowired
    private InsumoJpaRepository repository;

    @Override
    public void run(String... args) {
        logger.info("Verificando datos iniciales...");

        if (repository.count() == 0) {
            logger.info("Cargando datos iniciales de insumos...");
            cargarDatosIniciales();
            logger.info("Datos iniciales cargados exitosamente");
        } else {
            logger.info("La base de datos ya contiene {} insumos", repository.count());
        }
    }

    private void cargarDatosIniciales() {
        // Insumo 1: Fertilizante para Café
        Insumo fertilizanteCafe = new Insumo();
        fertilizanteCafe.setId("INS001");
        fertilizanteCafe.setProductoId("AGR001");
        fertilizanteCafe.setNombre("Fertilizante NPK 15-15-15");
        fertilizanteCafe.setCantidad(50);
        fertilizanteCafe.setCostoUnitario(45000.0);
        fertilizanteCafe.setFechaCompra(LocalDateTime.now().minusDays(10));
        fertilizanteCafe.setProveedor("Agroquímicos del Valle");
        fertilizanteCafe.setTipo("FERTILIZANTE");
        fertilizanteCafe.setDescripcion("Fertilizante balanceado para café");
        fertilizanteCafe.setUnidadMedida("KG");
        fertilizanteCafe.setLote("LOTE-2025-001");
        repository.save(fertilizanteCafe);

        // Insumo 2: Semilla para Arroz
        Insumo semillaArroz = new Insumo();
        semillaArroz.setId("INS002");
        semillaArroz.setProductoId("AGR002");
        semillaArroz.setNombre("Semilla de Arroz Fedearroz 2000");
        semillaArroz.setCantidad(100);
        semillaArroz.setCostoUnitario(5500.0);
        semillaArroz.setFechaCompra(LocalDateTime.now().minusDays(5));
        semillaArroz.setProveedor("Semillas Premium S.A.");
        semillaArroz.setTipo("SEMILLA");
        semillaArroz.setDescripcion("Semilla certificada de alto rendimiento");
        semillaArroz.setUnidadMedida("KG");
        semillaArroz.setLote("LOTE-2025-002");
        repository.save(semillaArroz);

        // Insumo 3: Pesticida
        Insumo pesticida = new Insumo();
        pesticida.setId("INS003");
        pesticida.setProductoId("AGR001");
        pesticida.setNombre("Pesticida Orgánico BioControl");
        pesticida.setCantidad(20);
        pesticida.setCostoUnitario(85000.0);
        pesticida.setFechaCompra(LocalDateTime.now().minusDays(15));
        pesticida.setProveedor("Biológicos del Tolima");
        pesticida.setTipo("PESTICIDA");
        pesticida.setDescripcion("Control biológico de plagas");
        pesticida.setUnidadMedida("LITROS");
        pesticida.setFechaVencimiento(LocalDateTime.now().plusYears(1));
        pesticida.setLote("LOTE-2025-003");
        repository.save(pesticida);

        // Insumo 4: Herramienta
        Insumo herramienta = new Insumo();
        herramienta.setId("INS004");
        herramienta.setProductoId("AGR003");
        herramienta.setNombre("Tijeras de Poda Profesionales");
        herramienta.setCantidad(15);
        herramienta.setCostoUnitario(125000.0);
        herramienta.setFechaCompra(LocalDateTime.now().minusDays(20));
        herramienta.setProveedor("Herramientas Agrícolas Ltda");
        herramienta.setTipo("HERRAMIENTA");
        herramienta.setDescripcion("Tijeras de acero inoxidable para poda");
        herramienta.setUnidadMedida("UNIDAD");
        herramienta.setLote("LOTE-2025-004");
        repository.save(herramienta);

        // Insumo 5: Fertilizante orgánico
        Insumo fertilizanteOrganico = new Insumo();
        fertilizanteOrganico.setId("INS005");
        fertilizanteOrganico.setProductoId("AGR002");
        fertilizanteOrganico.setNombre("Abono Orgánico Compostado");
        fertilizanteOrganico.setCantidad(200);
        fertilizanteOrganico.setCostoUnitario(12000.0);
        fertilizanteOrganico.setFechaCompra(LocalDateTime.now().minusDays(3));
        fertilizanteOrganico.setProveedor("Orgánicos del Caribe");
        fertilizanteOrganico.setTipo("FERTILIZANTE");
        fertilizanteOrganico.setDescripcion("Compost 100% orgánico");
        fertilizanteOrganico.setUnidadMedida("KG");
        fertilizanteOrganico.setLote("LOTE-2025-005");
        repository.save(fertilizanteOrganico);

        logger.info("5 insumos de ejemplo creados");
    }
}
