/**
 * SISTEMA DE GESTIÓN AGROPECUARIA
 * Universidad de Ibagué
 * config.js - Configuración Global
 */

const CONFIG = {
    // ===== CONFIGURACIÓN DEL SERVIDOR =====
    API_BASE_URL: 'http://localhost:8081/api',
    REQUEST_TIMEOUT: 10000, // 10 segundos
    
    // ===== INFORMACIÓN DE LA APLICACIÓN =====
    APP_NAME: 'Sistema de Gestión Agropecuaria',
    VERSION: '2.0.0',
    UNIVERSIDAD: 'Universidad de Ibagué',
    CURSO: 'Desarrollo de Aplicaciones Empresariales',
    
    // ===== OPCIONES DE CALIDAD DE COSECHA =====
    CALIDADES: [
        'Premium',
        'Extra',
        'Estándar',
        'Segunda'
    ],
    
    // ===== ESTADOS DE COSECHA =====
    ESTADOS_COSECHA: [
        'Completada',
        'En proceso',
        'Pendiente'
    ],
    
    // ===== CONDICIONES CLIMÁTICAS =====
    CONDICIONES_CLIMATICAS: [
        'Soleado',
        'Parcialmente nublado',
        'Nublado',
        'Lluvioso',
        'Tormentoso',
        'Normal'
    ],
    
    // ===== TIPOS DE CULTIVO =====
    TIPOS_CULTIVO: [
        'Café',
        'Arroz',
        'Cacao',
        'Mango',
        'Aguacate',
        'Cítricos',
        'Maracuyá',
        'Sorgo',
        'Algodón',
        'Plátano',
        'Banano',
        'Yuca',
        'Papa',
        'Tomate'
    ],
    
    // ===== TEMPORADAS =====
    TEMPORADAS: [
        'Todo el año',
        'Temporada seca',
        'Temporada lluviosa',
        'Cosecha principal',
        'Cosecha mitaca',
        'Temporada alta',
        'Temporada baja'
    ],
    
    // ===== TIPOS DE SUELO =====
    TIPOS_SUELO: [
        'Franco',
        'Franco arcilloso',
        'Franco arenoso',
        'Arcilloso',
        'Arenoso',
        'Limoso'
    ],

    // ===== TIPOS DE INSUMO =====
    TIPOS_INSUMO: [
        'FERTILIZANTE',
        'SEMILLA',
        'PESTICIDA',
        'HERRAMIENTA',
        'HERBICIDA',
        'FUNGICIDA',
        'ABONO_ORGANICO',
        'RIEGO'
    ],

    // ===== UNIDADES DE MEDIDA =====
    UNIDADES_MEDIDA: [
        'Kilogramos',
        'Litros',
        'Unidades',
        'Toneladas',
        'Bultos',
        'Galones'
    ],
    
    // ===== VALIDACIONES =====
    VALIDACIONES: {
        MIN_HECTAREAS: 0.1,
        MAX_HECTAREAS: 10000,
        MIN_CANTIDAD: 1,
        MAX_CANTIDAD: 1000000,
        MIN_PRECIO: 100,
        MAX_PRECIO: 1000000,
        MIN_TRABAJADORES: 1,
        MAX_TRABAJADORES: 100,
        MIN_COSTO_UNITARIO: 1,
        MAX_COSTO_UNITARIO: 10000000
    },
    
    // ===== PAGINACIÓN =====
    ITEMS_PER_PAGE: 10,
    
    // ===== MENSAJES DEL SISTEMA =====
    MENSAJES: {
        // Generales
        CARGANDO: 'Cargando...',
        GUARDANDO: 'Guardando...',
        PROCESANDO: 'Procesando...',
        OPERACION_EXITOSA: 'Operación completada exitosamente',
        ERROR_CONEXION: 'Error al conectar con el servidor. Verifique que el servidor esté ejecutándose en el puerto 8081.',
        SIN_DATOS: 'No se encontraron datos',
        DATOS_INVALIDOS: 'Los datos ingresados no son válidos',
        
        // Confirmaciones
        CONFIRMAR_ELIMINAR: '¿Está seguro que desea eliminar este registro? Esta acción no se puede deshacer.',
        CONFIRMAR_CANCELAR: '¿Está seguro que desea cancelar? Los cambios no guardados se perderán.',
        
        // Productos
        PRODUCTO_CREADO: 'Producto creado exitosamente',
        PRODUCTO_ACTUALIZADO: 'Producto actualizado exitosamente',
        PRODUCTO_ELIMINADO: 'Producto eliminado exitosamente',
        ERROR_CREAR_PRODUCTO: 'Error al crear el producto',
        ERROR_ACTUALIZAR_PRODUCTO: 'Error al actualizar el producto',
        ERROR_ELIMINAR_PRODUCTO: 'Error al eliminar el producto',
        ERROR_CARGAR_PRODUCTOS: 'Error al cargar los productos',
        PRODUCTO_NO_ENCONTRADO: 'Producto no encontrado',
        
        // Cosechas
        COSECHA_CREADA: 'Cosecha creada exitosamente',
        COSECHA_ACTUALIZADA: 'Cosecha actualizada exitosamente',
        COSECHA_ELIMINADA: 'Cosecha eliminada exitosamente',
        ERROR_CREAR_COSECHA: 'Error al crear la cosecha',
        ERROR_ACTUALIZAR_COSECHA: 'Error al actualizar la cosecha',
        ERROR_ELIMINAR_COSECHA: 'Error al eliminar la cosecha',
        ERROR_CARGAR_COSECHAS: 'Error al cargar las cosechas',
        COSECHA_NO_ENCONTRADA: 'Cosecha no encontrada',

        // Insumos
        INSUMO_CREADO: 'Insumo creado exitosamente',
        INSUMO_ACTUALIZADO: 'Insumo actualizado exitosamente',
        INSUMO_ELIMINADO: 'Insumo eliminado exitosamente',
        ERROR_CREAR_INSUMO: 'Error al crear el insumo',
        ERROR_ACTUALIZAR_INSUMO: 'Error al actualizar el insumo',
        ERROR_ELIMINAR_INSUMO: 'Error al eliminar el insumo',
        ERROR_CARGAR_INSUMOS: 'Error al cargar los insumos',
        INSUMO_NO_ENCONTRADO: 'Insumo no encontrado',
        
        // Validaciones
        CAMPOS_REQUERIDOS: 'Por favor complete todos los campos obligatorios',
        VALOR_INVALIDO: 'El valor ingresado no es válido',
        SELECCIONE_PRODUCTO: 'Por favor seleccione un producto',
        FECHA_INVALIDA: 'La fecha ingresada no es válida'
    },
    
    // ===== FORMATO DE FECHAS =====
    FORMATO_FECHA: {
        COMPLETO: 'DD/MM/YYYY HH:mm:ss',
        CORTO: 'DD/MM/YYYY',
        HORA: 'HH:mm'
    },
    
    // ===== FORMATO DE NÚMEROS =====
    FORMATO_NUMERO: {
        DECIMALES_PRECIO: 2,
        DECIMALES_HECTAREAS: 2,
        SEPARADOR_MILES: '.',
        SEPARADOR_DECIMAL: ','
    },
    
    // ===== DELAYS Y TIMEOUTS =====
    DELAYS: {
        TOAST_DURATION: 3000, // 3 segundos
        DEBOUNCE_SEARCH: 500, // 0.5 segundos
        AUTO_REFRESH: 30000 // 30 segundos
    },
    
    // ===== ENDPOINTS =====
    ENDPOINTS: {
        // Productos
        PRODUCTOS: '/productos',
        PRODUCTO_POR_ID: (id) => `/productos/${id}`,
        PRODUCTOS_POR_TIPO: (tipo) => `/productos?tipo=${tipo}`,
        PRODUCTOS_POR_NOMBRE: (nombre) => `/productos?nombre=${nombre}`,
        ESTADISTICAS_PRODUCTOS: '/productos/estadisticas',
        
        // Cosechas
        COSECHAS: '/cosechas',
        COSECHA_POR_ID: (id) => `/cosechas/${id}`,
        COSECHAS_POR_PRODUCTO: (productoId) => `/cosechas/producto/${productoId}`,
        COSECHAS_POR_CALIDAD: (calidad) => `/cosechas?calidad=${calidad}`,
        ESTADISTICAS_COSECHAS: (productoId) => `/cosechas/producto/${productoId}/estadisticas`,
        
        // Maestro-Detalle
        PRODUCTO_COSECHAS: (productoId) => `/productos/${productoId}/cosechas`,
        PRODUCTO_COSECHA_POR_ID: (productoId, cosechaId) => `/productos/${productoId}/cosechas/${cosechaId}`,
        PRODUCTO_ESTADISTICAS: (productoId) => `/productos/${productoId}/cosechas/estadisticas`,

        // Insumos (vía proxy en Microservicio A-B)
        INSUMOS: '/insumos',
        INSUMO_POR_ID: (id) => `/insumos/${id}`,
        INSUMOS_POR_TIPO: (tipo) => `/insumos?tipo=${tipo}`,
        INSUMOS_POR_PROVEEDOR: (proveedor) => `/insumos?proveedor=${proveedor}`,
        INSUMOS_POR_PRODUCTO: (productoId) => `/insumos/producto/${productoId}`,
        INSUMOS_COSTO_TOTAL: (productoId) => `/insumos/costo-total/${productoId}`
    }
};

// Congelar el objeto para evitar modificaciones
Object.freeze(CONFIG);
Object.freeze(CONFIG.CALIDADES);
Object.freeze(CONFIG.ESTADOS_COSECHA);
Object.freeze(CONFIG.CONDICIONES_CLIMATICAS);
Object.freeze(CONFIG.TIPOS_CULTIVO);
Object.freeze(CONFIG.TEMPORADAS);
Object.freeze(CONFIG.TIPOS_SUELO);
Object.freeze(CONFIG.TIPOS_INSUMO);
Object.freeze(CONFIG.UNIDADES_MEDIDA);
Object.freeze(CONFIG.VALIDACIONES);
Object.freeze(CONFIG.MENSAJES);
Object.freeze(CONFIG.FORMATO_FECHA);
Object.freeze(CONFIG.FORMATO_NUMERO);
Object.freeze(CONFIG.DELAYS);
Object.freeze(CONFIG.ENDPOINTS);

// Log de inicialización
console.log(`[CONFIG] ${CONFIG.APP_NAME} v${CONFIG.VERSION} - Configuración cargada`);
console.log(`[CONFIG] API Base URL: ${CONFIG.API_BASE_URL}`);