/**
 * SISTEMA DE GESTIÓN AGROPECUARIA
 * Universidad de Ibagué
 * app.js - Controlador Principal de la Aplicación
 */

const APP = {
    // ==================== INICIALIZACIÓN ====================

    /**
     * Inicializa la aplicación
     */
    async inicializar() {
        console.log('[APP] Inicializando aplicación...');

        try {
            // Configurar event listeners
            this.configurarEventListeners();

            // Cargar opciones en selects
            UI.cargarOpcionesSelects();

            // Cargar datos iniciales
            await this.cargarDatosIniciales();

            // Si estamos en maestro-detalle y hay un productoId en URL, seleccionarlo
            await this.verificarParametrosURL();

            console.log('[APP] Aplicación inicializada correctamente');
            UI.mostrarToast('Sistema cargado correctamente', 'success');
        } catch (error) {
            console.error('[APP] Error al inicializar:', error);
            UI.mostrarToast('Error al cargar la aplicación', 'error');
        }
    },

    /**
     * Carga los datos iniciales de la aplicación
     */
    async cargarDatosIniciales() {
        try {
            // Cargar productos en la sección de productos (solo si existe la tabla)
            const tablaProductos = document.getElementById('tabla-productos-body');
            if (tablaProductos) {
                await this.listarProductos();
            }

            // Cargar productos en el select de cosechas (solo si existen los selects)
            const selectCrearCosecha = document.getElementById('crear-cosecha-producto');
            if (selectCrearCosecha) {
                await UI.cargarProductosEnSelect();
            }

            // Cargar maestro-detalle si estamos en esa página
            const listaMaestro = document.getElementById('lista-productos-maestro');
            if (listaMaestro) {
                await this.cargarMaestroDetalle();
            }

            // Actualizar estadísticas (solo si existen los elementos)
            await UI.actualizarEstadisticasGenerales();

            console.log('[APP] Datos iniciales cargados');
        } catch (error) {
            console.error('[APP] Error al cargar datos iniciales:', error);
            throw error;
        }
    },

    /**
     * Verifica parámetros URL y ejecuta acciones correspondientes
     */
    async verificarParametrosURL() {
        try {
            const urlParams = new URLSearchParams(window.location.search);
            const productoId = urlParams.get('productoId');

            // Si estamos en maestro-detalle y hay un productoId, seleccionarlo
            if (productoId && document.getElementById('lista-productos-maestro')) {
                console.log(`[APP] Seleccionando producto desde URL: ${productoId}`);

                // Esperar un momento para que el DOM esté listo
                setTimeout(() => {
                    UI.seleccionarProductoMaestro(productoId);
                }, 500);
            }
        } catch (error) {
            console.error('[APP] Error al verificar parámetros URL:', error);
        }
    },

    /**
     * Configura todos los event listeners
     */
    configurarEventListeners() {
        // ===== PRODUCTOS =====
        // Botón CREAR producto
        document.getElementById('btn-crear-producto')?.addEventListener('click', () => {
            UI.mostrarFormularioCrearProducto();
        });

        document.getElementById('btn-listar-productos')?.addEventListener('click', () => {
            this.listarProductos();
        });

        document.getElementById('btn-buscar-tipo')?.addEventListener('click', () => {
            this.buscarProductosPorTipo();
        });

        // Búsqueda individual de producto
        document.getElementById('btn-buscar-producto-individual')?.addEventListener('click', () => {
            this.buscarProductoIndividual();
        });

        // Enter en el input de búsqueda de producto
        document.getElementById('input-buscar-producto-id')?.addEventListener('keypress', (e) => {
            if (e.key === 'Enter') {
                this.buscarProductoIndividual();
            }
        });

        // Botón cerrar resultado de búsqueda de producto
        document.getElementById('btn-cerrar-resultado-producto')?.addEventListener('click', () => {
            UI.ocultarResultadoBusquedaProducto();
        });

        // Botón editar desde búsqueda de producto
        document.getElementById('btn-editar-desde-busqueda-producto')?.addEventListener('click', () => {
            this.editarProductoDesdeBusqueda();
        });

        // Botón eliminar desde búsqueda de producto
        document.getElementById('btn-eliminar-desde-busqueda-producto')?.addEventListener('click', () => {
            this.eliminarProductoDesdeBusqueda();
        });

        // Formulario CREAR producto
        document.getElementById('form-crear-producto')?.addEventListener('submit', (e) => {
            e.preventDefault();
            this.crearProducto();
        });

        document.getElementById('btn-limpiar-crear-producto')?.addEventListener('click', () => {
            document.getElementById('form-crear-producto').reset();
        });

        document.getElementById('btn-cancelar-crear-producto')?.addEventListener('click', () => {
            UI.ocultarFormularioCrearProducto();
        });

        document.getElementById('btn-cerrar-crear-producto')?.addEventListener('click', () => {
            UI.ocultarFormularioCrearProducto();
        });

        // Formulario EDITAR producto
        document.getElementById('form-editar-producto')?.addEventListener('submit', (e) => {
            e.preventDefault();
            this.actualizarProducto();
        });

        document.getElementById('btn-cancelar-editar-producto')?.addEventListener('click', () => {
            UI.ocultarFormularioEditarProducto();
        });

        document.getElementById('btn-cerrar-editar-producto')?.addEventListener('click', () => {
            UI.ocultarFormularioEditarProducto();
        });

        // ===== COSECHAS =====
        // Botón CREAR cosecha
        document.getElementById('btn-crear-cosecha')?.addEventListener('click', () => {
            UI.mostrarFormularioCrearCosecha();
        });

        document.getElementById('btn-listar-cosechas')?.addEventListener('click', () => {
            this.listarCosechas();
        });

        document.getElementById('btn-buscar-calidad')?.addEventListener('click', () => {
            this.buscarCosechasPorCalidad();
        });

        // Búsqueda individual de cosecha
        document.getElementById('btn-buscar-cosecha-individual')?.addEventListener('click', () => {
            this.buscarCosechaIndividual();
        });

        // Enter en el input de búsqueda de cosecha
        document.getElementById('input-buscar-cosecha-id')?.addEventListener('keypress', (e) => {
            if (e.key === 'Enter') {
                this.buscarCosechaIndividual();
            }
        });

        // Botón cerrar resultado de búsqueda de cosecha
        document.getElementById('btn-cerrar-resultado-cosecha')?.addEventListener('click', () => {
            UI.ocultarResultadoBusquedaCosecha();
        });

        // Botón editar desde búsqueda de cosecha
        document.getElementById('btn-editar-desde-busqueda-cosecha')?.addEventListener('click', () => {
            this.editarCosechaDesdeBusqueda();
        });

        // Botón eliminar desde búsqueda de cosecha
        document.getElementById('btn-eliminar-desde-busqueda-cosecha')?.addEventListener('click', () => {
            this.eliminarCosechaDesdeBusqueda();
        });

        // Formulario CREAR cosecha
        document.getElementById('form-crear-cosecha')?.addEventListener('submit', (e) => {
            e.preventDefault();
            this.crearCosecha();
        });

        document.getElementById('btn-limpiar-crear-cosecha')?.addEventListener('click', () => {
            document.getElementById('form-crear-cosecha').reset();
        });

        document.getElementById('btn-cancelar-crear-cosecha')?.addEventListener('click', () => {
            UI.ocultarFormularioCrearCosecha();
        });

        document.getElementById('btn-cerrar-crear-cosecha')?.addEventListener('click', () => {
            UI.ocultarFormularioCrearCosecha();
        });

        // Formulario EDITAR cosecha
        document.getElementById('form-editar-cosecha')?.addEventListener('submit', (e) => {
            e.preventDefault();
            this.actualizarCosecha();
        });

        document.getElementById('btn-cancelar-editar-cosecha')?.addEventListener('click', () => {
            UI.ocultarFormularioEditarCosecha();
        });

        document.getElementById('btn-cerrar-editar-cosecha')?.addEventListener('click', () => {
            UI.ocultarFormularioEditarCosecha();
        });

        // ===== MAESTRO-DETALLE =====
        document.getElementById('btn-agregar-cosecha-producto')?.addEventListener('click', () => {
            if (UI.state.productoSeleccionadoMaestro) {
                UI.mostrarFormularioCrearCosechaMaestro(UI.state.productoSeleccionadoMaestro);
            } else {
                UI.mostrarToast('Seleccione un producto primero', 'warning');
            }
        });

        // Formulario CREAR cosecha maestro
        document.getElementById('form-crear-cosecha-maestro')?.addEventListener('submit', (e) => {
            e.preventDefault();
            this.crearCosechaEnMaestroDetalle();
        });

        document.getElementById('btn-limpiar-crear-cosecha-maestro')?.addEventListener('click', () => {
            document.getElementById('form-crear-cosecha-maestro').reset();
        });

        document.getElementById('btn-cancelar-crear-cosecha-maestro')?.addEventListener('click', () => {
            UI.ocultarFormularioCrearCosechaMaestro();
        });

        document.getElementById('btn-cerrar-crear-cosecha-maestro')?.addEventListener('click', () => {
            UI.ocultarFormularioCrearCosechaMaestro();
        });

        // Formulario EDITAR cosecha maestro
        document.getElementById('form-editar-cosecha-maestro')?.addEventListener('submit', (e) => {
            e.preventDefault();
            this.actualizarCosechaEnMaestroDetalle();
        });

        document.getElementById('btn-cancelar-editar-cosecha-maestro')?.addEventListener('click', () => {
            UI.ocultarFormularioEditarCosechaMaestro();
        });

        document.getElementById('btn-cerrar-editar-cosecha-maestro')?.addEventListener('click', () => {
            UI.ocultarFormularioEditarCosechaMaestro();
        });

        // ===== ESTADÍSTICAS =====
        document.getElementById('btn-actualizar-estadisticas')?.addEventListener('click', () => {
            UI.actualizarEstadisticasGenerales();
        });

        console.log('[APP] Event listeners configurados');
    },

    // ==================== PRODUCTOS ====================

    /**
     * Lista todos los productos
     */
    async listarProductos() {
        try {
            UI.mostrarLoading();
            const productos = await API.obtenerProductos();
            UI.renderizarTablaProductos(productos);
            UI.ocultarLoading();
            console.log('[APP] Productos listados:', productos.length);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.ERROR_CARGAR_PRODUCTOS, 'error');
            console.error('[APP] Error al listar productos:', error);
        }
    },

    /**
     * Busca productos por tipo de cultivo
     */
    async buscarProductosPorTipo() {
        const tipo = document.getElementById('select-tipo-producto').value;

        if (!tipo) {
            UI.mostrarToast('Seleccione un tipo de cultivo', 'warning');
            return;
        }

        try {
            UI.mostrarLoading();
            const productos = await API.buscarProductosPorTipo(tipo);
            UI.renderizarTablaProductos(productos);
            UI.ocultarLoading();
            UI.mostrarToast(`Se encontraron ${productos.length} productos`, 'info');
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al buscar productos', 'error');
            console.error('[APP] Error al buscar productos:', error);
        }
    },

    /**
     * Crea un nuevo producto
     */
    async crearProducto() {
        const datos = UI.obtenerDatosFormularioCrearProducto();

        // Validar datos
        if (!this.validarDatosProducto(datos)) {
            return;
        }

        try {
            UI.mostrarLoading();
            await API.crearProducto(datos);
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.PRODUCTO_CREADO, 'success');
            UI.ocultarFormularioCrearProducto();
            await this.listarProductos();
            await UI.cargarProductosEnSelect();
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.ERROR_CREAR_PRODUCTO, 'error');
            console.error('[APP] Error al crear producto:', error);
        }
    },

    /**
     * Actualiza un producto existente
     */
    async actualizarProducto() {
        const datos = UI.obtenerDatosFormularioEditarProducto();
        const id = UI.state.productoIdEdicion;

        if (!id) {
            UI.mostrarToast('Error: ID de producto no encontrado', 'error');
            return;
        }

        // Validar datos
        if (!this.validarDatosProducto(datos)) {
            return;
        }

        try {
            UI.mostrarLoading();
            await API.actualizarProducto(id, datos);
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.PRODUCTO_ACTUALIZADO, 'success');
            UI.ocultarFormularioEditarProducto();
            await this.listarProductos();
            await UI.cargarProductosEnSelect();
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.ERROR_ACTUALIZAR_PRODUCTO, 'error');
            console.error('[APP] Error al actualizar producto:', error);
        }
    },

    /**
     * Edita un producto (muestra formulario de edición)
     */
    async editarProducto(id) {
        try {
            UI.mostrarLoading();
            const producto = await API.obtenerProductoPorId(id);
            UI.ocultarLoading();
            UI.mostrarFormularioEditarProducto(producto);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar el producto', 'error');
            console.error('[APP] Error al editar producto:', error);
        }
    },

    /**
     * Elimina un producto
     */
    async eliminarProducto(id) {
        UI.mostrarConfirmacion(CONFIG.MENSAJES.CONFIRMAR_ELIMINAR, async (confirmado) => {
            if (!confirmado) return;

            try {
                UI.mostrarLoading();
                await API.eliminarProducto(id);
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.PRODUCTO_ELIMINADO, 'success');
                await this.listarProductos();
            } catch (error) {
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.ERROR_ELIMINAR_PRODUCTO, 'error');
                console.error('[APP] Error al eliminar producto:', error);
            }
        });
    },

    /**
     * Valida los datos de un producto
     */
    validarDatosProducto(datos) {
        if (!datos.nombre || !datos.tipoCultivo) {
            UI.mostrarToast(CONFIG.MENSAJES.CAMPOS_REQUERIDOS, 'warning');
            return false;
        }

        if (datos.hectareasCultivadas < CONFIG.VALIDACIONES.MIN_HECTAREAS || 
            datos.hectareasCultivadas > CONFIG.VALIDACIONES.MAX_HECTAREAS) {
            UI.mostrarToast(`Las hectáreas deben estar entre ${CONFIG.VALIDACIONES.MIN_HECTAREAS} y ${CONFIG.VALIDACIONES.MAX_HECTAREAS}`, 'warning');
            return false;
        }

        if (datos.cantidadProducida < CONFIG.VALIDACIONES.MIN_CANTIDAD) {
            UI.mostrarToast('La cantidad producida debe ser mayor a 0', 'warning');
            return false;
        }

        if (datos.precioVenta < CONFIG.VALIDACIONES.MIN_PRECIO) {
            UI.mostrarToast('El precio de venta debe ser mayor a $100', 'warning');
            return false;
        }

        return true;
    },

    // ==================== COSECHAS ====================

    /**
     * Lista todas las cosechas
     */
    async listarCosechas() {
        try {
            UI.mostrarLoading();
            const cosechas = await API.obtenerCosechas();
            UI.renderizarTablaCosechas(cosechas);
            UI.ocultarLoading();
            console.log('[APP] Cosechas listadas:', cosechas.length);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.ERROR_CARGAR_COSECHAS, 'error');
            console.error('[APP] Error al listar cosechas:', error);
        }
    },

    /**
     * Busca cosechas por calidad
     */
    async buscarCosechasPorCalidad() {
        const calidad = document.getElementById('select-calidad-cosecha').value;

        if (!calidad) {
            UI.mostrarToast('Seleccione una calidad', 'warning');
            return;
        }

        try {
            UI.mostrarLoading();
            const cosechas = await API.buscarCosechasPorCalidad(calidad);
            UI.renderizarTablaCosechas(cosechas);
            UI.ocultarLoading();
            UI.mostrarToast(`Se encontraron ${cosechas.length} cosechas`, 'info');
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al buscar cosechas', 'error');
            console.error('[APP] Error al buscar cosechas:', error);
        }
    },

    /**
     * Crea una nueva cosecha
     */
    async crearCosecha() {
        const datos = UI.obtenerDatosFormularioCrearCosecha();

        // Validar datos
        if (!this.validarDatosCosecha(datos)) {
            return;
        }

        try {
            UI.mostrarLoading();
            await API.crearCosecha(datos);
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.COSECHA_CREADA, 'success');
            UI.ocultarFormularioCrearCosecha();
            await this.listarCosechas();
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.ERROR_CREAR_COSECHA, 'error');
            console.error('[APP] Error al crear cosecha:', error);
        }
    },

    /**
     * Actualiza una cosecha existente
     */
    async actualizarCosecha() {
        const datos = UI.obtenerDatosFormularioEditarCosecha();
        const id = UI.state.cosechaIdEdicion;

        if (!id) {
            UI.mostrarToast('Error: ID de cosecha no encontrado', 'error');
            return;
        }

        // Validar datos
        if (!this.validarDatosCosecha(datos)) {
            return;
        }

        try {
            UI.mostrarLoading();
            await API.actualizarCosecha(id, datos);
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.COSECHA_ACTUALIZADA, 'success');
            UI.ocultarFormularioEditarCosecha();
            await this.listarCosechas();
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast(CONFIG.MENSAJES.ERROR_ACTUALIZAR_COSECHA, 'error');
            console.error('[APP] Error al actualizar cosecha:', error);
        }
    },

    /**
     * Edita una cosecha (muestra formulario de edición)
     */
    async editarCosecha(id) {
        try {
            UI.mostrarLoading();
            const cosecha = await API.obtenerCosechaPorId(id);
            UI.ocultarLoading();
            UI.mostrarFormularioEditarCosecha(cosecha);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar la cosecha', 'error');
            console.error('[APP] Error al editar cosecha:', error);
        }
    },

    /**
     * Elimina una cosecha
     */
    async eliminarCosecha(id) {
        UI.mostrarConfirmacion(CONFIG.MENSAJES.CONFIRMAR_ELIMINAR, async (confirmado) => {
            if (!confirmado) return;

            try {
                UI.mostrarLoading();
                await API.eliminarCosecha(id);
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.COSECHA_ELIMINADA, 'success');
                await this.listarCosechas();
            } catch (error) {
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.ERROR_ELIMINAR_COSECHA, 'error');
                console.error('[APP] Error al eliminar cosecha:', error);
            }
        });
    },

    /**
     * Ver detalle de una cosecha
     */
    async verDetalleCosecha(id) {
        try {
            UI.mostrarLoading();
            const cosecha = await API.obtenerCosechaPorId(id);
            UI.ocultarLoading();

            // Esperar un momento para que el modal de loading se oculte completamente
            setTimeout(() => {
                // Mostrar modal personalizado con los detalles
                UI.mostrarModalDetalleCosecha(cosecha);
            }, 100); // 100ms de retraso
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar detalle de cosecha', 'error');
            console.error('[APP] Error al ver detalle:', error);
        }
    },

    /**
     * Valida los datos de una cosecha
     */
    validarDatosCosecha(datos) {
        if (!datos.productoId) {
            UI.mostrarToast(CONFIG.MENSAJES.SELECCIONE_PRODUCTO, 'warning');
            return false;
        }

        if (!datos.fechaCosecha) {
            UI.mostrarToast(CONFIG.MENSAJES.FECHA_INVALIDA, 'warning');
            return false;
        }

        if (!datos.cantidadRecolectada || datos.cantidadRecolectada < 1) {
            UI.mostrarToast('La cantidad recolectada debe ser mayor a 0', 'warning');
            return false;
        }

        if (!datos.calidadProducto) {
            UI.mostrarToast('La calidad del producto es obligatoria', 'warning');
            return false;
        }

        return true;
    },

    // ==================== MAESTRO-DETALLE ====================

    /**
     * Carga la vista maestro-detalle
     */
    async cargarMaestroDetalle() {
        try {
            UI.mostrarLoading();
            const productos = await API.obtenerProductos();
            UI.renderizarListaProductosMaestro(productos);
            UI.ocultarLoading();
            console.log('[APP] Maestro-Detalle cargado');
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar maestro-detalle', 'error');
            console.error('[APP] Error en maestro-detalle:', error);
        }
    },

    /**
     * Ver cosechas de un producto (navega a maestro-detalle)
     */
    async verCosechasProducto(productoId) {
        // Navegar a la página maestro-detalle pasando el ID como parámetro URL
        window.location.href = `maestro-detalle.html?productoId=${encodeURIComponent(productoId)}`;
    },

    /**
     * Crea una cosecha en maestro-detalle
     */
    async crearCosechaEnMaestroDetalle() {
        const datos = UI.obtenerDatosFormularioCrearCosechaMaestro();

        if (!this.validarDatosCosecha(datos)) {
            return;
        }

        try {
            UI.mostrarLoading();
            await API.crearCosechaParaProducto(datos.productoId, datos);
            UI.mostrarToast('Cosecha agregada al producto exitosamente', 'success');
            UI.ocultarLoading();
            UI.ocultarFormularioCrearCosechaMaestro();

            // Recargar las cosechas del producto
            await UI.seleccionarProductoMaestro(datos.productoId);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al agregar cosecha al producto', 'error');
            console.error('[APP] Error al crear cosecha en maestro-detalle:', error);
        }
    },

    /**
     * Edita una cosecha de un producto (desde maestro-detalle)
     */
    async editarCosechaDeProducto(productoId, cosechaId) {
        try {
            UI.mostrarLoading();
            const cosecha = await API.obtenerCosechaDeProducto(productoId, cosechaId);
            UI.ocultarLoading();

            // Mostrar formulario de EDITAR cosecha maestro
            UI.mostrarFormularioEditarCosechaMaestro(cosecha);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar la cosecha', 'error');
            console.error('[APP] Error al editar cosecha del producto:', error);
        }
    },

    /**
     * Actualiza una cosecha en maestro-detalle
     */
    async actualizarCosechaEnMaestroDetalle() {
        const datos = UI.obtenerDatosFormularioEditarCosechaMaestro();
        const productoId = datos.productoId;
        const cosechaId = datos.id;

        if (!this.validarDatosCosecha(datos)) {
            return;
        }

        try {
            UI.mostrarLoading();
            await API.actualizarCosechaDeProducto(productoId, cosechaId, datos);
            UI.mostrarToast('Cosecha actualizada exitosamente', 'success');
            UI.ocultarLoading();
            UI.ocultarFormularioEditarCosechaMaestro();

            // Recargar las cosechas del producto
            await UI.seleccionarProductoMaestro(productoId);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al actualizar la cosecha', 'error');
            console.error('[APP] Error al actualizar cosecha en maestro-detalle:', error);
        }
    },

    /**
     * Elimina una cosecha de un producto
     */
    async eliminarCosechaDeProducto(productoId, cosechaId) {
        UI.mostrarConfirmacion(CONFIG.MENSAJES.CONFIRMAR_ELIMINAR, async (confirmado) => {
            if (!confirmado) return;

            try {
                UI.mostrarLoading();
                await API.eliminarCosechaDeProducto(productoId, cosechaId);
                UI.ocultarLoading();
                UI.mostrarToast('Cosecha eliminada exitosamente', 'success');

                // Recargar las cosechas del producto
                await UI.seleccionarProductoMaestro(productoId);
            } catch (error) {
                UI.ocultarLoading();
                UI.mostrarToast('Error al eliminar la cosecha', 'error');
                console.error('[APP] Error al eliminar cosecha del producto:', error);
            }
        });
    },

    // ==================== BÚSQUEDA INDIVIDUAL ====================

    /**
     * Busca un producto individual por ID
     */
    async buscarProductoIndividual() {
        const id = document.getElementById('input-buscar-producto-id').value.trim();

        if (!id) {
            UI.mostrarToast('Por favor ingrese el ID del producto', 'warning');
            return;
        }

        try {
            UI.mostrarLoading();
            const producto = await API.obtenerProductoPorId(id);
            UI.ocultarLoading();
            UI.mostrarResultadoBusquedaProducto(producto);
            UI.mostrarToast('Producto encontrado exitosamente', 'success');
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('No se encontró un producto con ese ID', 'error');
            console.error('[APP] Error al buscar producto:', error);
        }
    },

    /**
     * Edita un producto desde la búsqueda individual
     */
    async editarProductoDesdeBusqueda() {
        const id = UI.state.productoIdEdicion;

        if (!id) {
            UI.mostrarToast('Error: No hay un producto seleccionado', 'error');
            return;
        }

        try {
            UI.mostrarLoading();
            const producto = await API.obtenerProductoPorId(id);
            UI.ocultarLoading();

            // Ocultar resultado de búsqueda
            UI.ocultarResultadoBusquedaProducto();

            // Mostrar formulario de edición
            UI.mostrarFormularioEditarProducto(producto);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar el producto', 'error');
            console.error('[APP] Error al editar producto desde búsqueda:', error);
        }
    },

    /**
     * Elimina un producto desde la búsqueda individual
     */
    async eliminarProductoDesdeBusqueda() {
        const id = UI.state.productoIdEdicion;

        if (!id) {
            UI.mostrarToast('Error: No hay un producto seleccionado', 'error');
            return;
        }

        UI.mostrarConfirmacion(CONFIG.MENSAJES.CONFIRMAR_ELIMINAR, async (confirmado) => {
            if (!confirmado) return;

            try {
                UI.mostrarLoading();
                await API.eliminarProducto(id);
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.PRODUCTO_ELIMINADO, 'success');

                // Ocultar resultado de búsqueda
                UI.ocultarResultadoBusquedaProducto();

                // Actualizar lista de productos
                await this.listarProductos();
            } catch (error) {
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.ERROR_ELIMINAR_PRODUCTO, 'error');
                console.error('[APP] Error al eliminar producto desde búsqueda:', error);
            }
        });
    },

    /**
     * Busca una cosecha individual por ID
     */
    async buscarCosechaIndividual() {
        const id = document.getElementById('input-buscar-cosecha-id').value.trim();

        if (!id) {
            UI.mostrarToast('Por favor ingrese el ID de la cosecha', 'warning');
            return;
        }

        try {
            UI.mostrarLoading();
            const cosecha = await API.obtenerCosechaPorId(id);
            UI.ocultarLoading();
            UI.mostrarResultadoBusquedaCosecha(cosecha);
            UI.mostrarToast('Cosecha encontrada exitosamente', 'success');
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('No se encontró una cosecha con ese ID', 'error');
            console.error('[APP] Error al buscar cosecha:', error);
        }
    },

    /**
     * Edita una cosecha desde la búsqueda individual
     */
    async editarCosechaDesdeBusqueda() {
        const id = UI.state.cosechaIdEdicion;

        if (!id) {
            UI.mostrarToast('Error: No hay una cosecha seleccionada', 'error');
            return;
        }

        try {
            UI.mostrarLoading();
            const cosecha = await API.obtenerCosechaPorId(id);
            UI.ocultarLoading();

            // Ocultar resultado de búsqueda
            UI.ocultarResultadoBusquedaCosecha();

            // Mostrar formulario de edición
            UI.mostrarFormularioEditarCosecha(cosecha);
        } catch (error) {
            UI.ocultarLoading();
            UI.mostrarToast('Error al cargar la cosecha', 'error');
            console.error('[APP] Error al editar cosecha desde búsqueda:', error);
        }
    },

    /**
     * Elimina una cosecha desde la búsqueda individual
     */
    async eliminarCosechaDesdeBusqueda() {
        const id = UI.state.cosechaIdEdicion;

        if (!id) {
            UI.mostrarToast('Error: No hay una cosecha seleccionada', 'error');
            return;
        }

        UI.mostrarConfirmacion(CONFIG.MENSAJES.CONFIRMAR_ELIMINAR, async (confirmado) => {
            if (!confirmado) return;

            try {
                UI.mostrarLoading();
                await API.eliminarCosecha(id);
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.COSECHA_ELIMINADA, 'success');

                // Ocultar resultado de búsqueda
                UI.ocultarResultadoBusquedaCosecha();

                // Actualizar lista de cosechas
                await this.listarCosechas();
            } catch (error) {
                UI.ocultarLoading();
                UI.mostrarToast(CONFIG.MENSAJES.ERROR_ELIMINAR_COSECHA, 'error');
                console.error('[APP] Error al eliminar cosecha desde búsqueda:', error);
            }
        });
    }
};

// ==================== INICIALIZACIÓN AL CARGAR LA PÁGINA ====================

document.addEventListener('DOMContentLoaded', () => {
    console.log('='.repeat(80));
    console.log(`${CONFIG.APP_NAME} v${CONFIG.VERSION}`);
    console.log(CONFIG.UNIVERSIDAD);
    console.log(CONFIG.CURSO);
    console.log('='.repeat(80));
    
    // Inicializar la aplicación
    APP.inicializar();
});

// Log de carga del módulo
console.log('[APP] Módulo principal de la aplicación cargado');