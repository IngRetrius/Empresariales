package co.unibague.agropecuario.insumos.utils;

/**
 * Constantes de la aplicación
 * Universidad de Ibagué - Microservicio C
 */
public class Constantes {

    // ===== PREFIJOS DE IDS =====
    public static final String PREFIJO_INSUMO = "INS";
    public static final int PADDING_NUMERO = 3;
    public static final int LONGITUD_ID = 10;

    // ===== FORMATOS =====
    public static final String FORMATO_FECHA = "yyyy-MM-dd'T'HH:mm:ss";

    // ===== MENSAJES DE ERROR =====
    public static final String ERROR_INSUMO_NO_ENCONTRADO = "Insumo no encontrado con ID: %s";
    public static final String ERROR_INSUMO_YA_EXISTE = "Ya existe un insumo con ID: %s";
    public static final String ERROR_PRODUCTO_NO_ENCONTRADO = "Producto no encontrado con ID: %s";
    public static final String ERROR_PRODUCTO_NO_EXISTE_INTEGRIDAD = "El producto con ID %s no existe. No se puede crear el insumo.";
    public static final String ERROR_MICROSERVICIO_AB_NO_DISPONIBLE = "No se puede verificar la existencia del producto. Microservicio A-B no disponible.";
    public static final String ERROR_VALIDACION_CANTIDAD = "La cantidad debe ser mayor a 0";
    public static final String ERROR_VALIDACION_COSTO = "El costo debe ser mayor a 0";
    public static final String ERROR_VALIDACION_PRODUCTO_ID = "El ID del producto es obligatorio";

    // ===== MENSAJES DE ÉXITO =====
    public static final String EXITO_CREAR_INSUMO = "Insumo creado exitosamente";
    public static final String EXITO_ACTUALIZAR_INSUMO = "Insumo actualizado exitosamente";
    public static final String EXITO_ELIMINAR_INSUMO = "Insumo eliminado exitosamente";
    public static final String EXITO_OBTENER_INSUMO = "Insumo encontrado";
    public static final String EXITO_LISTAR_INSUMOS = "Insumos obtenidos exitosamente";

    // ===== TIMEOUTS Y REINTENTOS =====
    public static final int WEBCLIENT_TIMEOUT_MS = 5000;
    public static final int WEBCLIENT_MAX_RETRIES = 3;

    // ===== ESTADOS =====
    public static final String ESTADO_ACTIVO = "ACTIVO";
    public static final String ESTADO_INACTIVO = "INACTIVO";

    // ===== TIPOS DE INSUMO =====
    public static final String TIPO_FERTILIZANTE = "FERTILIZANTE";
    public static final String TIPO_SEMILLA = "SEMILLA";
    public static final String TIPO_PESTICIDA = "PESTICIDA";
    public static final String TIPO_HERRAMIENTA = "HERRAMIENTA";

    // ===== UNIDADES DE MEDIDA =====
    public static final String UNIDAD_KG = "KG";
    public static final String UNIDAD_LITROS = "LITROS";
    public static final String UNIDAD_UNIDAD = "UNIDAD";
    public static final String UNIDAD_METROS = "METROS";

    // ===== LÍMITES DE NEGOCIO =====
    public static final int CANTIDAD_MIN = 1;
    public static final int CANTIDAD_MAX = 1000000;
    public static final double COSTO_MIN = 0.01;
    public static final double COSTO_MAX = 10000000.0;
    public static final int STOCK_BAJO_THRESHOLD = 10;
    public static final int DIAS_PROXIMO_VENCIMIENTO = 30;

    // Constructor privado para prevenir instanciación
    private Constantes() {
        throw new IllegalStateException("Clase de constantes - no instanciable");
    }
}
