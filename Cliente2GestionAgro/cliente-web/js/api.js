/**
 * SISTEMA DE GESTIÓN AGROPECUARIA
 * Universidad de Ibagué
 * api.js - Módulo de Comunicación con API REST
 */

const API = {
    /**
     * Realiza una petición HTTP genérica
     * @param {string} endpoint - Endpoint de la API
     * @param {object} options - Opciones de la petición fetch
     * @returns {Promise} Respuesta de la API
     */
    async request(endpoint, options = {}) {
        const url = `${CONFIG.API_BASE_URL}${endpoint}`;
        
        const defaultOptions = {
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            ...options
        };

        try {
            console.log(`[API] ${options.method || 'GET'} ${url}`);
            
            const controller = new AbortController();
            const timeoutId = setTimeout(() => controller.abort(), CONFIG.REQUEST_TIMEOUT);
            
            const response = await fetch(url, {
                ...defaultOptions,
                signal: controller.signal
            });
            
            clearTimeout(timeoutId);

            // Obtener el cuerpo de la respuesta
            let data;
            const contentType = response.headers.get('content-type');
            
            if (contentType && contentType.includes('application/json')) {
                data = await response.json();
            } else {
                data = await response.text();
            }

            if (!response.ok) {
                const errorMessage = data.message || data.error || `Error ${response.status}: ${response.statusText}`;
                throw new Error(errorMessage);
            }

            console.log(`[API] Respuesta exitosa:`, data);
            return data;

        } catch (error) {
            if (error.name === 'AbortError') {
                console.error('[API] Timeout: La petición tardó demasiado');
                throw new Error('La petición tardó demasiado tiempo. Por favor, intente nuevamente.');
            }
            
            console.error('[API] Error:', error);
            throw error;
        }
    },

    // ==================== PRODUCTOS ====================

    /**
     * Obtiene todos los productos
     */
    async obtenerProductos() {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTOS);
        return response.data || [];
    },

    /**
     * Obtiene un producto por ID
     */
    async obtenerProductoPorId(id) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_POR_ID(id));
        return response.data;
    },

    /**
     * Busca productos por tipo de cultivo
     */
    async buscarProductosPorTipo(tipo) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTOS_POR_TIPO(tipo));
        return response.data || [];
    },

    /**
     * Busca productos por nombre
     */
    async buscarProductosPorNombre(nombre) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTOS_POR_NOMBRE(nombre));
        return response.data || [];
    },

    /**
     * Crea un nuevo producto
     */
    async crearProducto(producto) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTOS, {
            method: 'POST',
            body: JSON.stringify(producto)
        });
        return response.data;
    },

    /**
     * Actualiza un producto existente
     */
    async actualizarProducto(id, producto) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_POR_ID(id), {
            method: 'PUT',
            body: JSON.stringify(producto)
        });
        return response.data;
    },

    /**
     * Elimina un producto
     */
    async eliminarProducto(id) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_POR_ID(id), {
            method: 'DELETE'
        });
        return response;
    },

    /**
     * Obtiene estadísticas de productos
     */
    async obtenerEstadisticasProductos() {
        const response = await this.request(CONFIG.ENDPOINTS.ESTADISTICAS_PRODUCTOS);
        return response.data;
    },

    // ==================== COSECHAS ====================

    /**
     * Obtiene todas las cosechas
     */
    async obtenerCosechas() {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHAS);
        return response.data || [];
    },

    /**
     * Obtiene una cosecha por ID
     */
    async obtenerCosechaPorId(id) {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHA_POR_ID(id));
        return response.data;
    },

    /**
     * Obtiene cosechas de un producto específico
     * CRÍTICO PARA MAESTRO-DETALLE
     */
    async obtenerCosechasPorProducto(productoId) {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHAS_POR_PRODUCTO(productoId));
        return response.data || [];
    },

    /**
     * Busca cosechas por calidad
     */
    async buscarCosechasPorCalidad(calidad) {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHAS_POR_CALIDAD(calidad));
        return response.data || [];
    },

    /**
     * Crea una nueva cosecha
     */
    async crearCosecha(cosecha) {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHAS, {
            method: 'POST',
            body: JSON.stringify(cosecha)
        });
        return response.data;
    },

    /**
     * Actualiza una cosecha existente
     */
    async actualizarCosecha(id, cosecha) {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHA_POR_ID(id), {
            method: 'PUT',
            body: JSON.stringify(cosecha)
        });
        return response.data;
    },

    /**
     * Elimina una cosecha
     */
    async eliminarCosecha(id) {
        const response = await this.request(CONFIG.ENDPOINTS.COSECHA_POR_ID(id), {
            method: 'DELETE'
        });
        return response;
    },

    /**
     * Obtiene estadísticas de cosechas para un producto
     */
    async obtenerEstadisticasCosechas(productoId) {
        const response = await this.request(CONFIG.ENDPOINTS.ESTADISTICAS_COSECHAS(productoId));
        return response.data;
    },

    // ==================== MAESTRO-DETALLE ====================

    /**
     * Obtiene todas las cosechas de un producto (Maestro-Detalle)
     * Endpoint: GET /api/productos/{productoId}/cosechas
     */
    async obtenerCosechasDeProducto(productoId) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_COSECHAS(productoId));
        return response.data || [];
    },

    /**
     * Crea una cosecha para un producto específico (Maestro-Detalle)
     * Endpoint: POST /api/productos/{productoId}/cosechas
     */
    async crearCosechaParaProducto(productoId, cosecha) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_COSECHAS(productoId), {
            method: 'POST',
            body: JSON.stringify(cosecha)
        });
        return response.data;
    },

    /**
     * Obtiene una cosecha específica de un producto (Maestro-Detalle)
     * Endpoint: GET /api/productos/{productoId}/cosechas/{cosechaId}
     */
    async obtenerCosechaDeProducto(productoId, cosechaId) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_COSECHA_POR_ID(productoId, cosechaId));
        return response.data;
    },

    /**
     * Actualiza una cosecha de un producto (Maestro-Detalle)
     * Endpoint: PUT /api/productos/{productoId}/cosechas/{cosechaId}
     */
    async actualizarCosechaDeProducto(productoId, cosechaId, cosecha) {
        const response = await this.request(
            CONFIG.ENDPOINTS.PRODUCTO_COSECHA_POR_ID(productoId, cosechaId),
            {
                method: 'PUT',
                body: JSON.stringify(cosecha)
            }
        );
        return response.data;
    },

    /**
     * Elimina una cosecha de un producto (Maestro-Detalle)
     * Endpoint: DELETE /api/productos/{productoId}/cosechas/{cosechaId}
     */
    async eliminarCosechaDeProducto(productoId, cosechaId) {
        const response = await this.request(
            CONFIG.ENDPOINTS.PRODUCTO_COSECHA_POR_ID(productoId, cosechaId),
            {
                method: 'DELETE'
            }
        );
        return response;
    },

    /**
     * Obtiene estadísticas de un producto específico (Maestro-Detalle)
     * Endpoint: GET /api/productos/{productoId}/cosechas/estadisticas
     */
    async obtenerEstadisticasProducto(productoId) {
        const response = await this.request(CONFIG.ENDPOINTS.PRODUCTO_ESTADISTICAS(productoId));
        return response.data;
    },

    // ==================== UTILIDADES ====================

    /**
     * Verifica la conexión con el servidor
     */
    async verificarConexion() {
        try {
            await this.request('/productos/test');
            console.log('[API] Conexión con el servidor: OK');
            return true;
        } catch (error) {
            console.error('[API] No se pudo conectar con el servidor:', error.message);
            return false;
        }
    },

    /**
     * Formatea una fecha para enviarla al servidor
     */
    formatearFechaParaAPI(fecha) {
        if (!fecha) return null;
        
        // Si es string de datetime-local, convertir a formato ISO
        if (typeof fecha === 'string') {
            const date = new Date(fecha);
            return date.toISOString().slice(0, 19);
        }
        
        // Si es objeto Date
        if (fecha instanceof Date) {
            return fecha.toISOString().slice(0, 19);
        }
        
        return fecha;
    },

    /**
     * Formatea una fecha desde la API para mostrarla
     */
    formatearFechaDesdeAPI(fechaISO) {
        if (!fechaISO) return '';
        
        try {
            const fecha = new Date(fechaISO);
            const dia = fecha.getDate().toString().padStart(2, '0');
            const mes = (fecha.getMonth() + 1).toString().padStart(2, '0');
            const anio = fecha.getFullYear();
            const hora = fecha.getHours().toString().padStart(2, '0');
            const minutos = fecha.getMinutes().toString().padStart(2, '0');
            
            return `${dia}/${mes}/${anio} ${hora}:${minutos}`;
        } catch (error) {
            console.error('[API] Error al formatear fecha:', error);
            return fechaISO;
        }
    },

    /**
     * Formatea un número como moneda
     */
    formatearMoneda(valor) {
        if (valor === null || valor === undefined) return '$0';
        
        return new Intl.NumberFormat('es-CO', {
            style: 'currency',
            currency: 'COP',
            minimumFractionDigits: 0,
            maximumFractionDigits: 0
        }).format(valor);
    },

    /**
     * Formatea un número con separadores de miles
     */
    formatearNumero(valor, decimales = 0) {
        if (valor === null || valor === undefined) return '0';
        
        return new Intl.NumberFormat('es-CO', {
            minimumFractionDigits: decimales,
            maximumFractionDigits: decimales
        }).format(valor);
    }
};

// Log de inicialización
console.log('[API] Módulo de API cargado');
console.log(`[API] Base URL configurada: ${CONFIG.API_BASE_URL}`);

// Verificar conexión al cargar
API.verificarConexion().then(conectado => {
    if (!conectado) {
        console.warn('[API] ADVERTENCIA: No se pudo conectar con el servidor. Verifique que esté ejecutándose.');
    }
});