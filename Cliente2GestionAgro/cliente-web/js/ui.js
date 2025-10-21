/**
 * SISTEMA DE GESTIÓN AGROPECUARIA
 * Universidad de Ibagué
 * ui.js - Módulo de Manipulación del DOM
 */

const UI = {
    // Estado actual de la UI
    state: {
        productoSeleccionadoMaestro: null,
        productoIdEdicion: null,
        cosechaIdEdicion: null
    },

    // ==================== GESTIÓN DE SECCIONES ====================

    /**
     * Muestra una sección específica y oculta las demás
     */
    mostrarSeccion(seccionId) {
        // Ocultar todas las secciones
        document.querySelectorAll('.section').forEach(section => {
            section.classList.remove('active');
        });

        // Mostrar la sección seleccionada
        const seccion = document.getElementById(`section-${seccionId}`);
        if (seccion) {
            seccion.classList.add('active');
        }

        // Actualizar tabs de navegación
        document.querySelectorAll('.nav-tab').forEach(tab => {
            tab.classList.remove('active');
        });

        const tabActivo = document.querySelector(`[data-section="${seccionId}"]`);
        if (tabActivo) {
            tabActivo.classList.add('active');
        }

        console.log(`[UI] Sección mostrada: ${seccionId}`);
    },

    // ==================== GESTIÓN DE FORMULARIOS ====================

    /**
     * Muestra el formulario de CREAR producto
     */
    mostrarFormularioCrearProducto() {
        const container = document.getElementById('form-crear-producto-container');
        const form = document.getElementById('form-crear-producto');

        if (!container || !form) {
            console.error('[UI] Formulario crear producto no encontrado');
            return;
        }

        // Limpiar formulario
        form.reset();
        container.classList.remove('hidden');

        // Scroll al formulario
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log('[UI] Formulario crear producto mostrado');
    },

    /**
     * Oculta el formulario de CREAR producto
     */
    ocultarFormularioCrearProducto() {
        const container = document.getElementById('form-crear-producto-container');
        const form = document.getElementById('form-crear-producto');

        if (container && form) {
            container.classList.add('hidden');
            form.reset();
        }

        console.log('[UI] Formulario crear producto ocultado');
    },

    /**
     * Muestra el formulario de EDITAR producto
     */
    mostrarFormularioEditarProducto(producto) {
        const container = document.getElementById('form-editar-producto-container');
        const form = document.getElementById('form-editar-producto');

        if (!container || !form) {
            console.error('[UI] Formulario editar producto no encontrado');
            return;
        }

        // Guardar ID en estado
        this.state.productoIdEdicion = producto.id;

        // Llenar formulario con datos
        document.getElementById('editar-producto-id').value = producto.id || '';
        document.getElementById('editar-producto-nombre').value = producto.nombre || '';
        document.getElementById('editar-producto-tipo').value = producto.tipoCultivo || '';
        document.getElementById('editar-producto-hectareas').value = producto.hectareasCultivadas || '';
        document.getElementById('editar-producto-cantidad').value = producto.cantidadProducida || '';
        document.getElementById('editar-producto-precio').value = producto.precioVenta || '';
        document.getElementById('editar-producto-costo').value = producto.costoProduccion || '';
        document.getElementById('editar-producto-temporada').value = producto.temporada || '';
        document.getElementById('editar-producto-suelo').value = producto.tipoSuelo || '';
        document.getElementById('editar-producto-finca').value = producto.codigoFinca || '';

        container.classList.remove('hidden');

        // Scroll al formulario
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log(`[UI] Formulario editar producto mostrado para ID: ${producto.id}`);
    },

    /**
     * Oculta el formulario de EDITAR producto
     */
    ocultarFormularioEditarProducto() {
        const container = document.getElementById('form-editar-producto-container');
        const form = document.getElementById('form-editar-producto');

        if (container && form) {
            container.classList.add('hidden');
            form.reset();
            this.state.productoIdEdicion = null;
        }

        console.log('[UI] Formulario editar producto ocultado');
    },

    /**
     * Muestra el formulario de CREAR cosecha
     */
    mostrarFormularioCrearCosecha() {
        const container = document.getElementById('form-crear-cosecha-container');
        const form = document.getElementById('form-crear-cosecha');

        if (!container || !form) {
            console.error('[UI] Formulario crear cosecha no encontrado');
            return;
        }

        // Limpiar formulario
        form.reset();
        container.classList.remove('hidden');

        // Scroll al formulario
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log('[UI] Formulario crear cosecha mostrado');
    },

    /**
     * Oculta el formulario de CREAR cosecha
     */
    ocultarFormularioCrearCosecha() {
        const container = document.getElementById('form-crear-cosecha-container');
        const form = document.getElementById('form-crear-cosecha');

        if (container && form) {
            container.classList.add('hidden');
            form.reset();
        }

        console.log('[UI] Formulario crear cosecha ocultado');
    },

    /**
     * Muestra el formulario de EDITAR cosecha
     */
    mostrarFormularioEditarCosecha(cosecha) {
        const container = document.getElementById('form-editar-cosecha-container');
        const form = document.getElementById('form-editar-cosecha');

        if (!container || !form) {
            console.error('[UI] Formulario editar cosecha no encontrado');
            return;
        }

        // Guardar ID en estado
        this.state.cosechaIdEdicion = cosecha.id;

        // Llenar formulario con datos
        document.getElementById('editar-cosecha-id').value = cosecha.id || '';
        document.getElementById('editar-cosecha-producto').value = cosecha.productoId || '';

        // Formatear fecha para input datetime-local
        if (cosecha.fechaCosecha) {
            const fecha = new Date(cosecha.fechaCosecha);
            const fechaLocal = new Date(fecha.getTime() - fecha.getTimezoneOffset() * 60000);
            document.getElementById('editar-cosecha-fecha').value = fechaLocal.toISOString().slice(0, 16);
        }

        document.getElementById('editar-cosecha-cantidad').value = cosecha.cantidadRecolectada || '';
        document.getElementById('editar-cosecha-calidad').value = cosecha.calidadProducto || '';
        document.getElementById('editar-cosecha-estado').value = cosecha.estadoCosecha || '';
        document.getElementById('editar-cosecha-trabajadores').value = cosecha.numeroTrabajadores || '';
        document.getElementById('editar-cosecha-costo').value = cosecha.costoManoObra || '';
        document.getElementById('editar-cosecha-clima').value = cosecha.condicionesClimaticas || '';
        document.getElementById('editar-cosecha-observaciones').value = cosecha.observaciones || '';

        container.classList.remove('hidden');

        // Scroll al formulario
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log(`[UI] Formulario editar cosecha mostrado para ID: ${cosecha.id}`);
    },

    /**
     * Oculta el formulario de EDITAR cosecha
     */
    ocultarFormularioEditarCosecha() {
        const container = document.getElementById('form-editar-cosecha-container');
        const form = document.getElementById('form-editar-cosecha');

        if (container && form) {
            container.classList.add('hidden');
            form.reset();
            this.state.cosechaIdEdicion = null;
        }

        console.log('[UI] Formulario editar cosecha ocultado');
    },

    /**
     * Obtiene los datos del formulario de CREAR producto
     */
    obtenerDatosFormularioCrearProducto() {
        return {
            nombre: document.getElementById('crear-producto-nombre').value,
            tipoCultivo: document.getElementById('crear-producto-tipo').value,
            hectareasCultivadas: parseFloat(document.getElementById('crear-producto-hectareas').value),
            cantidadProducida: parseInt(document.getElementById('crear-producto-cantidad').value),
            precioVenta: parseFloat(document.getElementById('crear-producto-precio').value),
            costoProduccion: parseFloat(document.getElementById('crear-producto-costo').value),
            temporada: document.getElementById('crear-producto-temporada').value,
            tipoSuelo: document.getElementById('crear-producto-suelo').value,
            codigoFinca: document.getElementById('crear-producto-finca').value
        };
    },

    /**
     * Obtiene los datos del formulario de EDITAR producto
     */
    obtenerDatosFormularioEditarProducto() {
        return {
            id: document.getElementById('editar-producto-id').value,
            nombre: document.getElementById('editar-producto-nombre').value,
            tipoCultivo: document.getElementById('editar-producto-tipo').value,
            hectareasCultivadas: parseFloat(document.getElementById('editar-producto-hectareas').value),
            cantidadProducida: parseInt(document.getElementById('editar-producto-cantidad').value),
            precioVenta: parseFloat(document.getElementById('editar-producto-precio').value),
            costoProduccion: parseFloat(document.getElementById('editar-producto-costo').value),
            temporada: document.getElementById('editar-producto-temporada').value,
            tipoSuelo: document.getElementById('editar-producto-suelo').value,
            codigoFinca: document.getElementById('editar-producto-finca').value
        };
    },

    /**
     * Obtiene los datos del formulario de CREAR cosecha
     */
    obtenerDatosFormularioCrearCosecha() {
        return {
            productoId: document.getElementById('crear-cosecha-producto').value,
            fechaCosecha: document.getElementById('crear-cosecha-fecha').value,
            cantidadRecolectada: parseInt(document.getElementById('crear-cosecha-cantidad').value),
            calidadProducto: document.getElementById('crear-cosecha-calidad').value,
            estadoCosecha: document.getElementById('crear-cosecha-estado').value || 'Pendiente',
            numeroTrabajadores: parseInt(document.getElementById('crear-cosecha-trabajadores').value) || null,
            costoManoObra: parseFloat(document.getElementById('crear-cosecha-costo').value) || null,
            condicionesClimaticas: document.getElementById('crear-cosecha-clima').value,
            observaciones: document.getElementById('crear-cosecha-observaciones').value
        };
    },

    /**
     * Obtiene los datos del formulario de EDITAR cosecha
     */
    obtenerDatosFormularioEditarCosecha() {
        return {
            id: document.getElementById('editar-cosecha-id').value,
            productoId: document.getElementById('editar-cosecha-producto').value,
            fechaCosecha: document.getElementById('editar-cosecha-fecha').value,
            cantidadRecolectada: parseInt(document.getElementById('editar-cosecha-cantidad').value),
            calidadProducto: document.getElementById('editar-cosecha-calidad').value,
            estadoCosecha: document.getElementById('editar-cosecha-estado').value || 'Pendiente',
            numeroTrabajadores: parseInt(document.getElementById('editar-cosecha-trabajadores').value) || null,
            costoManoObra: parseFloat(document.getElementById('editar-cosecha-costo').value) || null,
            condicionesClimaticas: document.getElementById('editar-cosecha-clima').value,
            observaciones: document.getElementById('editar-cosecha-observaciones').value
        };
    },

    // ==================== RENDERIZADO DE TABLAS ====================

    /**
     * Renderiza la tabla de productos
     */
    renderizarTablaProductos(productos) {
        const tbody = document.getElementById('tabla-productos-body');
        const contador = document.getElementById('productos-contador');

        if (!tbody) {
            console.error('[UI] Tabla de productos no encontrada');
            return;
        }

        // Actualizar contador
        if (contador) {
            contador.textContent = `${productos.length} producto${productos.length !== 1 ? 's' : ''}`;
        }

        // Limpiar tabla
        tbody.innerHTML = '';

        if (productos.length === 0) {
            tbody.innerHTML = `
                <tr>
                    <td colspan="7" class="text-center">No hay productos registrados</td>
                </tr>
            `;
            return;
        }

        // Renderizar filas
        productos.forEach(producto => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${producto.id}</td>
                <td><strong>${producto.nombre}</strong></td>
                <td>${producto.tipoCultivo}</td>
                <td>${API.formatearNumero(producto.hectareasCultivadas, 2)} ha</td>
                <td>${API.formatearNumero(producto.cantidadProducida)} kg</td>
                <td>${API.formatearMoneda(producto.precioVenta)}</td>
                <td>
                    <button class="btn btn-info btn-sm" onclick="APP.verCosechasProducto('${producto.id}')">
                        Ver Cosechas
                    </button>
                </td>
            `;
            tbody.appendChild(tr);
        });

        console.log(`[UI] Tabla de productos renderizada: ${productos.length} registros`);
    },

    /**
     * Renderiza la tabla de cosechas
     */
    renderizarTablaCosechas(cosechas) {
        const tbody = document.getElementById('tabla-cosechas-body');
        const contador = document.getElementById('cosechas-contador');

        if (!tbody) {
            console.error('[UI] Tabla de cosechas no encontrada');
            return;
        }

        // Actualizar contador
        if (contador) {
            contador.textContent = `${cosechas.length} cosecha${cosechas.length !== 1 ? 's' : ''}`;
        }

        // Limpiar tabla
        tbody.innerHTML = '';

        if (cosechas.length === 0) {
            tbody.innerHTML = `
                <tr>
                    <td colspan="7" class="text-center">No hay cosechas registradas</td>
                </tr>
            `;
            return;
        }

        // Renderizar filas
        cosechas.forEach(cosecha => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${cosecha.id}</td>
                <td>${API.formatearFechaDesdeAPI(cosecha.fechaCosecha)}</td>
                <td>${cosecha.productoId}</td>
                <td>${API.formatearNumero(cosecha.cantidadRecolectada)} kg</td>
                <td><span class="badge">${cosecha.calidadProducto}</span></td>
                <td>${cosecha.numeroTrabajadores || 'N/A'}</td>
                <td>
                    <button class="btn btn-info btn-sm" onclick="APP.verDetalleCosecha('${cosecha.id}')">
                        Ver Detalles
                    </button>
                </td>
            `;
            tbody.appendChild(tr);
        });

        console.log(`[UI] Tabla de cosechas renderizada: ${cosechas.length} registros`);
    },

    // ==================== MAESTRO-DETALLE ====================

    /**
     * Renderiza la lista de productos en el panel maestro
     */
    renderizarListaProductosMaestro(productos) {
        const lista = document.getElementById('lista-productos-maestro');

        if (!lista) {
            console.error('[UI] Lista de productos maestro no encontrada');
            return;
        }

        lista.innerHTML = '';

        if (productos.length === 0) {
            lista.innerHTML = '<p class="text-center">No hay productos registrados</p>';
            return;
        }

        productos.forEach(producto => {
            const div = document.createElement('div');
            div.className = 'producto-item';
            div.dataset.productoId = producto.id;
            div.innerHTML = `
                <h4>${producto.nombre}</h4>
                <p><strong>ID:</strong> ${producto.id}</p>
                <p><strong>Tipo:</strong> ${producto.tipoCultivo}</p>
                <p><strong>Hectáreas:</strong> ${API.formatearNumero(producto.hectareasCultivadas, 2)} ha</p>
            `;

            div.addEventListener('click', () => {
                this.seleccionarProductoMaestro(producto.id);
            });

            lista.appendChild(div);
        });

        console.log(`[UI] Lista maestro renderizada: ${productos.length} productos`);
    },

    /**
     * Selecciona un producto en el panel maestro
     */
    async seleccionarProductoMaestro(productoId) {
        // Actualizar estado
        this.state.productoSeleccionadoMaestro = productoId;

        // Actualizar UI
        document.querySelectorAll('.producto-item').forEach(item => {
            item.classList.remove('selected');
        });

        const itemSeleccionado = document.querySelector(`[data-producto-id="${productoId}"]`);
        if (itemSeleccionado) {
            itemSeleccionado.classList.add('selected');
        }

        // Ocultar estado vacío y mostrar detalle
        document.getElementById('detalle-vacio').classList.add('hidden');
        document.getElementById('detalle-producto').classList.remove('hidden');

        // Cargar detalles del producto
        try {
            this.mostrarLoading();

            const producto = await API.obtenerProductoPorId(productoId);
            this.mostrarDetalleProducto(producto);

            const cosechas = await API.obtenerCosechasDeProducto(productoId);
            this.mostrarCosechasDelProducto(cosechas);

            const estadisticas = await API.obtenerEstadisticasProducto(productoId);
            this.mostrarEstadisticasProducto(estadisticas);

            this.ocultarLoading();
        } catch (error) {
            this.ocultarLoading();
            this.mostrarToast('Error al cargar detalles del producto', 'error');
            console.error('[UI] Error al seleccionar producto:', error);
        }
    },

    /**
     * Muestra el detalle de un producto
     */
    mostrarDetalleProducto(producto) {
        const container = document.getElementById('info-producto-detalle');

        if (!container) {
            console.error('[UI] Contenedor de detalle de producto no encontrado');
            return;
        }

        container.innerHTML = `
            <div class="info-item">
                <label>ID</label>
                <div class="value">${producto.id}</div>
            </div>
            <div class="info-item">
                <label>Nombre</label>
                <div class="value">${producto.nombre}</div>
            </div>
            <div class="info-item">
                <label>Tipo de Cultivo</label>
                <div class="value">${producto.tipoCultivo}</div>
            </div>
            <div class="info-item">
                <label>Hectáreas</label>
                <div class="value">${API.formatearNumero(producto.hectareasCultivadas, 2)} ha</div>
            </div>
            <div class="info-item">
                <label>Cantidad Producida</label>
                <div class="value">${API.formatearNumero(producto.cantidadProducida)} kg</div>
            </div>
            <div class="info-item">
                <label>Precio de Venta</label>
                <div class="value">${API.formatearMoneda(producto.precioVenta)}</div>
            </div>
            <div class="info-item">
                <label>Costo de Producción</label>
                <div class="value">${API.formatearMoneda(producto.costoProduccion)}</div>
            </div>
            <div class="info-item">
                <label>Temporada</label>
                <div class="value">${producto.temporada || 'N/A'}</div>
            </div>
        `;
    },

    /**
     * Muestra las cosechas de un producto en la vista maestro-detalle
     */
    mostrarCosechasDelProducto(cosechas) {
        const tbody = document.getElementById('tabla-cosechas-producto');

        if (!tbody) {
            console.error('[UI] Tabla de cosechas del producto no encontrada');
            return;
        }

        tbody.innerHTML = '';

        if (cosechas.length === 0) {
            tbody.innerHTML = `
                <tr>
                    <td colspan="6" class="text-center">No hay cosechas registradas para este producto</td>
                </tr>
            `;
            return;
        }

        cosechas.forEach(cosecha => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${cosecha.id}</td>
                <td>${API.formatearFechaDesdeAPI(cosecha.fechaCosecha)}</td>
                <td>${API.formatearNumero(cosecha.cantidadRecolectada)} kg</td>
                <td><span class="badge">${cosecha.calidadProducto}</span></td>
                <td>${cosecha.estadoCosecha}</td>
                <td>
                    <button class="btn btn-warning btn-sm" onclick="APP.editarCosechaDeProducto('${this.state.productoSeleccionadoMaestro}', '${cosecha.id}')">
                        Editar
                    </button>
                    <button class="btn btn-danger btn-sm" onclick="APP.eliminarCosechaDeProducto('${this.state.productoSeleccionadoMaestro}', '${cosecha.id}')">
                        Eliminar
                    </button>
                </td>
            `;
            tbody.appendChild(tr);
        });
    },

    /**
     * Muestra estadísticas de un producto
     */
    mostrarEstadisticasProducto(estadisticas) {
        const container = document.getElementById('estadisticas-producto');

        if (!container) {
            console.error('[UI] Contenedor de estadísticas no encontrado');
            return;
        }

        container.innerHTML = `
            <div class="stat-item">
                <div class="label">Total Cosechas</div>
                <div class="value">${estadisticas.totalCosechas || 0}</div>
            </div>
            <div class="stat-item">
                <div class="label">Total Recolectado</div>
                <div class="value">${API.formatearNumero(estadisticas.cantidadTotalRecolectada || 0)} kg</div>
            </div>
            <div class="stat-item">
                <div class="label">Promedio por Cosecha</div>
                <div class="value">${API.formatearNumero(estadisticas.promedioRecoleccion || 0, 2)} kg</div>
            </div>
            <div class="stat-item">
                <div class="label">Costo Total Mano de Obra</div>
                <div class="value">${API.formatearMoneda(estadisticas.costoTotalManoObra || 0)}</div>
            </div>
        `;
    },

    // ==================== ESTADÍSTICAS GENERALES ====================

    /**
     * Actualiza las estadísticas generales del sistema
     */
    async actualizarEstadisticasGenerales() {
        try {
            // Verificar si los elementos de estadísticas existen en esta página
            const statTotalProductos = document.getElementById('stat-total-productos');
            const statTotalCosechas = document.getElementById('stat-total-cosechas');
            const statTotalKg = document.getElementById('stat-total-kg');
            const statProductoTop = document.getElementById('stat-producto-top');

            // Si ningún elemento existe, significa que no estamos en la página de estadísticas
            if (!statTotalProductos && !statTotalCosechas && !statTotalKg && !statProductoTop) {
                console.log('[UI] Elementos de estadísticas no encontrados - omitiendo actualización');
                return;
            }

            this.mostrarLoading();

            const productos = await API.obtenerProductos();
            const cosechas = await API.obtenerCosechas();

            // Total productos
            if (statTotalProductos) {
                statTotalProductos.textContent = productos.length;
            }

            // Total cosechas
            if (statTotalCosechas) {
                statTotalCosechas.textContent = cosechas.length;
            }

            // Total kg recolectados
            const totalKg = cosechas.reduce((sum, c) => sum + (c.cantidadRecolectada || 0), 0);
            if (statTotalKg) {
                statTotalKg.textContent = API.formatearNumero(totalKg);
            }

            // Producto con más cosechas
            const cosechasPorProducto = {};
            cosechas.forEach(c => {
                cosechasPorProducto[c.productoId] = (cosechasPorProducto[c.productoId] || 0) + 1;
            });

            let maxCosechas = 0;
            let productoTop = '-';
            for (const [productoId, cantidad] of Object.entries(cosechasPorProducto)) {
                if (cantidad > maxCosechas) {
                    maxCosechas = cantidad;
                    const producto = productos.find(p => p.id === productoId);
                    productoTop = producto ? producto.nombre : productoId;
                }
            }
            if (statProductoTop) {
                statProductoTop.textContent = productoTop;
            }

            // Información del servidor
            const infoServidor = document.getElementById('info-servidor');
            if (infoServidor) {
                infoServidor.innerHTML = `
                    <div class="server-info-item">
                        <strong>Servidor</strong>
                        <div>API REST Agropecuario</div>
                    </div>
                    <div class="server-info-item">
                        <strong>URL</strong>
                        <div>${CONFIG.API_BASE_URL}</div>
                    </div>
                    <div class="server-info-item">
                        <strong>Versión</strong>
                        <div>${CONFIG.VERSION}</div>
                    </div>
                    <div class="server-info-item">
                        <strong>Estado</strong>
                        <div style="color: var(--color-success);">Conectado</div>
                    </div>
                `;
            }

            this.ocultarLoading();
        } catch (error) {
            this.ocultarLoading();
            this.mostrarToast('Error al cargar estadísticas', 'error');
            console.error('[UI] Error al actualizar estadísticas:', error);
        }
    },

    // ==================== SELECTS DINÁMICOS ====================

    /**
     * Carga las opciones de los selects
     */
    cargarOpcionesSelects() {
        // Tipos de cultivo - Formulario CREAR
        const selectTipoCrearProducto = document.getElementById('crear-producto-tipo');
        if (selectTipoCrearProducto) {
            CONFIG.TIPOS_CULTIVO.forEach(tipo => {
                const option = document.createElement('option');
                option.value = tipo;
                option.textContent = tipo;
                selectTipoCrearProducto.appendChild(option);
            });
        }

        // Tipos de cultivo - Formulario EDITAR
        const selectTipoEditarProducto = document.getElementById('editar-producto-tipo');
        if (selectTipoEditarProducto) {
            CONFIG.TIPOS_CULTIVO.forEach(tipo => {
                const option = document.createElement('option');
                option.value = tipo;
                option.textContent = tipo;
                selectTipoEditarProducto.appendChild(option);
            });
        }

        // Tipos de cultivo - Filtro
        const selectTipoFiltro = document.getElementById('select-tipo-producto');
        if (selectTipoFiltro) {
            CONFIG.TIPOS_CULTIVO.forEach(tipo => {
                const option = document.createElement('option');
                option.value = tipo;
                option.textContent = tipo;
                selectTipoFiltro.appendChild(option);
            });
        }

        // Temporadas - Formulario CREAR
        const selectTemporadaCrear = document.getElementById('crear-producto-temporada');
        if (selectTemporadaCrear) {
            CONFIG.TEMPORADAS.forEach(temporada => {
                const option = document.createElement('option');
                option.value = temporada;
                option.textContent = temporada;
                selectTemporadaCrear.appendChild(option);
            });
        }

        // Temporadas - Formulario EDITAR
        const selectTemporadaEditar = document.getElementById('editar-producto-temporada');
        if (selectTemporadaEditar) {
            CONFIG.TEMPORADAS.forEach(temporada => {
                const option = document.createElement('option');
                option.value = temporada;
                option.textContent = temporada;
                selectTemporadaEditar.appendChild(option);
            });
        }

        // Tipos de suelo - Formulario CREAR
        const selectSueloCrear = document.getElementById('crear-producto-suelo');
        if (selectSueloCrear) {
            CONFIG.TIPOS_SUELO.forEach(suelo => {
                const option = document.createElement('option');
                option.value = suelo;
                option.textContent = suelo;
                selectSueloCrear.appendChild(option);
            });
        }

        // Tipos de suelo - Formulario EDITAR
        const selectSueloEditar = document.getElementById('editar-producto-suelo');
        if (selectSueloEditar) {
            CONFIG.TIPOS_SUELO.forEach(suelo => {
                const option = document.createElement('option');
                option.value = suelo;
                option.textContent = suelo;
                selectSueloEditar.appendChild(option);
            });
        }

        // Calidades - Formulario CREAR
        const selectCalidadCrear = document.getElementById('crear-cosecha-calidad');
        if (selectCalidadCrear) {
            CONFIG.CALIDADES.forEach(calidad => {
                const option = document.createElement('option');
                option.value = calidad;
                option.textContent = calidad;
                selectCalidadCrear.appendChild(option);
            });
        }

        // Calidades - Formulario EDITAR
        const selectCalidadEditar = document.getElementById('editar-cosecha-calidad');
        if (selectCalidadEditar) {
            CONFIG.CALIDADES.forEach(calidad => {
                const option = document.createElement('option');
                option.value = calidad;
                option.textContent = calidad;
                selectCalidadEditar.appendChild(option);
            });
        }

        // Calidades - Filtro
        const selectCalidadFiltro = document.getElementById('select-calidad-cosecha');
        if (selectCalidadFiltro) {
            CONFIG.CALIDADES.forEach(calidad => {
                const option = document.createElement('option');
                option.value = calidad;
                option.textContent = calidad;
                selectCalidadFiltro.appendChild(option);
            });
        }

        // Estados de cosecha - Formulario CREAR
        const selectEstadoCrear = document.getElementById('crear-cosecha-estado');
        if (selectEstadoCrear) {
            CONFIG.ESTADOS_COSECHA.forEach(estado => {
                const option = document.createElement('option');
                option.value = estado;
                option.textContent = estado;
                selectEstadoCrear.appendChild(option);
            });
        }

        // Estados de cosecha - Formulario EDITAR
        const selectEstadoEditar = document.getElementById('editar-cosecha-estado');
        if (selectEstadoEditar) {
            CONFIG.ESTADOS_COSECHA.forEach(estado => {
                const option = document.createElement('option');
                option.value = estado;
                option.textContent = estado;
                selectEstadoEditar.appendChild(option);
            });
        }

        // Condiciones climáticas - Formulario CREAR
        const selectClimaCrear = document.getElementById('crear-cosecha-clima');
        if (selectClimaCrear) {
            CONFIG.CONDICIONES_CLIMATICAS.forEach(clima => {
                const option = document.createElement('option');
                option.value = clima;
                option.textContent = clima;
                selectClimaCrear.appendChild(option);
            });
        }

        // Condiciones climáticas - Formulario EDITAR
        const selectClimaEditar = document.getElementById('editar-cosecha-clima');
        if (selectClimaEditar) {
            CONFIG.CONDICIONES_CLIMATICAS.forEach(clima => {
                const option = document.createElement('option');
                option.value = clima;
                option.textContent = clima;
                selectClimaEditar.appendChild(option);
            });
        }

        // ===== FORMULARIOS MAESTRO-DETALLE =====

        // Calidades - Formulario CREAR maestro
        const selectCalidadCrearMaestro = document.getElementById('crear-cosecha-maestro-calidad');
        if (selectCalidadCrearMaestro) {
            CONFIG.CALIDADES.forEach(calidad => {
                const option = document.createElement('option');
                option.value = calidad;
                option.textContent = calidad;
                selectCalidadCrearMaestro.appendChild(option);
            });
        }

        // Calidades - Formulario EDITAR maestro
        const selectCalidadEditarMaestro = document.getElementById('editar-cosecha-maestro-calidad');
        if (selectCalidadEditarMaestro) {
            CONFIG.CALIDADES.forEach(calidad => {
                const option = document.createElement('option');
                option.value = calidad;
                option.textContent = calidad;
                selectCalidadEditarMaestro.appendChild(option);
            });
        }

        // Estados de cosecha - Formulario CREAR maestro
        const selectEstadoCrearMaestro = document.getElementById('crear-cosecha-maestro-estado');
        if (selectEstadoCrearMaestro) {
            CONFIG.ESTADOS_COSECHA.forEach(estado => {
                const option = document.createElement('option');
                option.value = estado;
                option.textContent = estado;
                selectEstadoCrearMaestro.appendChild(option);
            });
        }

        // Estados de cosecha - Formulario EDITAR maestro
        const selectEstadoEditarMaestro = document.getElementById('editar-cosecha-maestro-estado');
        if (selectEstadoEditarMaestro) {
            CONFIG.ESTADOS_COSECHA.forEach(estado => {
                const option = document.createElement('option');
                option.value = estado;
                option.textContent = estado;
                selectEstadoEditarMaestro.appendChild(option);
            });
        }

        // Condiciones climáticas - Formulario CREAR maestro
        const selectClimaCrearMaestro = document.getElementById('crear-cosecha-maestro-clima');
        if (selectClimaCrearMaestro) {
            CONFIG.CONDICIONES_CLIMATICAS.forEach(clima => {
                const option = document.createElement('option');
                option.value = clima;
                option.textContent = clima;
                selectClimaCrearMaestro.appendChild(option);
            });
        }

        // Condiciones climáticas - Formulario EDITAR maestro
        const selectClimaEditarMaestro = document.getElementById('editar-cosecha-maestro-clima');
        if (selectClimaEditarMaestro) {
            CONFIG.CONDICIONES_CLIMATICAS.forEach(clima => {
                const option = document.createElement('option');
                option.value = clima;
                option.textContent = clima;
                selectClimaEditarMaestro.appendChild(option);
            });
        }

        console.log('[UI] Opciones de selects cargadas para TODOS los formularios (incluyendo maestro-detalle)');
    },

    /**
     * Carga productos en el select de cosechas (AMBOS formularios)
     */
    async cargarProductosEnSelect() {
        try {
            const productos = await API.obtenerProductos();

            // Select CREAR cosecha
            const selectCrear = document.getElementById('crear-cosecha-producto');
            if (selectCrear) {
                selectCrear.innerHTML = '<option value="">Seleccionar producto...</option>';
                productos.forEach(producto => {
                    const option = document.createElement('option');
                    option.value = producto.id;
                    option.textContent = `${producto.id} - ${producto.nombre}`;
                    selectCrear.appendChild(option);
                });
            }

            // Select EDITAR cosecha
            const selectEditar = document.getElementById('editar-cosecha-producto');
            if (selectEditar) {
                selectEditar.innerHTML = '<option value="">Seleccionar producto...</option>';
                productos.forEach(producto => {
                    const option = document.createElement('option');
                    option.value = producto.id;
                    option.textContent = `${producto.id} - ${producto.nombre}`;
                    selectEditar.appendChild(option);
                });
            }

            console.log('[UI] Productos cargados en selects de CREAR y EDITAR');
        } catch (error) {
            console.error('[UI] Error al cargar productos en select:', error);
        }
    },

    // ==================== MODALES Y NOTIFICACIONES ====================

    /**
     * Muestra el modal de loading
     */
    mostrarLoading() {
        const modal = document.getElementById('modal-loading');
        if (modal) {
            modal.classList.add('show');
        }
    },

    /**
     * Oculta el modal de loading
     */
    ocultarLoading() {
        const modal = document.getElementById('modal-loading');
        if (modal) {
            modal.classList.remove('show');
        }
    },

    /**
     * Muestra un modal de confirmación
     */
    mostrarConfirmacion(mensaje, callback) {
        const modal = document.getElementById('modal-confirmacion');
        const mensajeElement = document.getElementById('modal-mensaje');
        const btnConfirmar = document.getElementById('modal-confirmar');
        const btnCancelar = document.getElementById('modal-cancelar');
        const btnClose = document.getElementById('modal-close');

        if (!modal) return;

        mensajeElement.textContent = mensaje;
        modal.classList.add('show');

        // Remover listeners anteriores
        const nuevoConfirmar = btnConfirmar.cloneNode(true);
        btnConfirmar.parentNode.replaceChild(nuevoConfirmar, btnConfirmar);

        const nuevoCancelar = btnCancelar.cloneNode(true);
        btnCancelar.parentNode.replaceChild(nuevoCancelar, btnCancelar);

        const nuevoClose = btnClose.cloneNode(true);
        btnClose.parentNode.replaceChild(nuevoClose, btnClose);

        // Agregar nuevos listeners
        nuevoConfirmar.addEventListener('click', () => {
            modal.classList.remove('show');
            if (callback) callback(true);
        });

        nuevoCancelar.addEventListener('click', () => {
            modal.classList.remove('show');
            if (callback) callback(false);
        });

        nuevoClose.addEventListener('click', () => {
            modal.classList.remove('show');
            if (callback) callback(false);
        });

        // Cerrar al hacer click fuera del modal
        modal.addEventListener('click', (e) => {
            if (e.target === modal) {
                modal.classList.remove('show');
                if (callback) callback(false);
            }
        });
    },

    /**
     * Muestra una notificación toast
     */
    mostrarToast(mensaje, tipo = 'info') {
        const container = document.getElementById('toast-container');

        if (!container) {
            console.error('[UI] Contenedor de toast no encontrado');
            return;
        }

        const toast = document.createElement('div');
        toast.className = `toast ${tipo}`;
        toast.innerHTML = `
            <div>${mensaje}</div>
        `;

        container.appendChild(toast);

        // Remover después de 3 segundos
        setTimeout(() => {
            toast.style.opacity = '0';
            setTimeout(() => {
                container.removeChild(toast);
            }, 300);
        }, CONFIG.DELAYS.TOAST_DURATION);

        console.log(`[UI] Toast mostrado: ${tipo} - ${mensaje}`);
    },

    // ==================== BÚSQUEDA INDIVIDUAL ====================

    /**
     * Muestra el resultado de búsqueda individual de producto
     */
    mostrarResultadoBusquedaProducto(producto) {
        const container = document.getElementById('resultado-busqueda-producto');

        if (!container) {
            console.error('[UI] Contenedor de resultado de búsqueda no encontrado');
            return;
        }

        // Guardar ID en estado
        this.state.productoIdEdicion = producto.id;

        // Llenar campos con datos
        document.getElementById('resultado-producto-id').value = producto.id || '';
        document.getElementById('resultado-producto-nombre').value = producto.nombre || '';
        document.getElementById('resultado-producto-tipo').value = producto.tipoCultivo || '';
        document.getElementById('resultado-producto-hectareas').value = producto.hectareasCultivadas ? `${API.formatearNumero(producto.hectareasCultivadas, 2)} ha` : '';
        document.getElementById('resultado-producto-cantidad').value = producto.cantidadProducida ? `${API.formatearNumero(producto.cantidadProducida)} kg` : '';
        document.getElementById('resultado-producto-precio').value = producto.precioVenta ? API.formatearMoneda(producto.precioVenta) : '';
        document.getElementById('resultado-producto-costo').value = producto.costoProduccion ? API.formatearMoneda(producto.costoProduccion) : '';
        document.getElementById('resultado-producto-temporada').value = producto.temporada || 'N/A';
        document.getElementById('resultado-producto-suelo').value = producto.tipoSuelo || 'N/A';
        document.getElementById('resultado-producto-finca').value = producto.codigoFinca || 'N/A';

        container.classList.remove('hidden');

        // Scroll al resultado
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log(`[UI] Resultado de búsqueda de producto mostrado: ID ${producto.id}`);
    },

    /**
     * Oculta el resultado de búsqueda individual de producto
     */
    ocultarResultadoBusquedaProducto() {
        const container = document.getElementById('resultado-busqueda-producto');

        if (container) {
            container.classList.add('hidden');
            this.state.productoIdEdicion = null;
        }

        // Limpiar input de búsqueda
        const inputBusqueda = document.getElementById('input-buscar-producto-id');
        if (inputBusqueda) {
            inputBusqueda.value = '';
        }

        console.log('[UI] Resultado de búsqueda de producto ocultado');
    },

    /**
     * Muestra el resultado de búsqueda individual de cosecha
     */
    mostrarResultadoBusquedaCosecha(cosecha) {
        const container = document.getElementById('resultado-busqueda-cosecha');

        if (!container) {
            console.error('[UI] Contenedor de resultado de búsqueda no encontrado');
            return;
        }

        // Guardar ID en estado
        this.state.cosechaIdEdicion = cosecha.id;

        // Llenar campos con datos
        document.getElementById('resultado-cosecha-id').value = cosecha.id || '';
        document.getElementById('resultado-cosecha-producto').value = cosecha.productoId || '';
        document.getElementById('resultado-cosecha-fecha').value = cosecha.fechaCosecha ? API.formatearFechaDesdeAPI(cosecha.fechaCosecha) : '';
        document.getElementById('resultado-cosecha-cantidad').value = cosecha.cantidadRecolectada ? `${API.formatearNumero(cosecha.cantidadRecolectada)} kg` : '';
        document.getElementById('resultado-cosecha-calidad').value = cosecha.calidadProducto || '';
        document.getElementById('resultado-cosecha-estado').value = cosecha.estadoCosecha || '';
        document.getElementById('resultado-cosecha-trabajadores').value = cosecha.numeroTrabajadores || 'N/A';
        document.getElementById('resultado-cosecha-costo').value = cosecha.costoManoObra ? API.formatearMoneda(cosecha.costoManoObra) : 'N/A';
        document.getElementById('resultado-cosecha-clima').value = cosecha.condicionesClimaticas || 'N/A';
        document.getElementById('resultado-cosecha-observaciones').value = cosecha.observaciones || 'N/A';

        container.classList.remove('hidden');

        // Scroll al resultado
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log(`[UI] Resultado de búsqueda de cosecha mostrado: ID ${cosecha.id}`);
    },

    /**
     * Oculta el resultado de búsqueda individual de cosecha
     */
    ocultarResultadoBusquedaCosecha() {
        const container = document.getElementById('resultado-busqueda-cosecha');

        if (container) {
            container.classList.add('hidden');
            this.state.cosechaIdEdicion = null;
        }

        // Limpiar input de búsqueda
        const inputBusqueda = document.getElementById('input-buscar-cosecha-id');
        if (inputBusqueda) {
            inputBusqueda.value = '';
        }

        console.log('[UI] Resultado de búsqueda de cosecha ocultado');
    },

    // ==================== FORMULARIOS MAESTRO-DETALLE ====================

    /**
     * Muestra el formulario de CREAR cosecha en maestro-detalle
     */
    mostrarFormularioCrearCosechaMaestro(productoId) {
        const container = document.getElementById('form-crear-cosecha-maestro-container');
        const form = document.getElementById('form-crear-cosecha-maestro');

        if (!container || !form) {
            console.error('[UI] Formulario crear cosecha maestro no encontrado');
            return;
        }

        // Limpiar formulario
        form.reset();

        // Establecer producto ID
        document.getElementById('crear-cosecha-maestro-producto').value = productoId;

        container.classList.remove('hidden');

        // Scroll al formulario
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log('[UI] Formulario crear cosecha maestro mostrado');
    },

    /**
     * Oculta el formulario de CREAR cosecha en maestro-detalle
     */
    ocultarFormularioCrearCosechaMaestro() {
        const container = document.getElementById('form-crear-cosecha-maestro-container');
        const form = document.getElementById('form-crear-cosecha-maestro');

        if (container && form) {
            container.classList.add('hidden');
            form.reset();
        }

        console.log('[UI] Formulario crear cosecha maestro ocultado');
    },

    /**
     * Muestra el formulario de EDITAR cosecha en maestro-detalle
     */
    mostrarFormularioEditarCosechaMaestro(cosecha) {
        const container = document.getElementById('form-editar-cosecha-maestro-container');
        const form = document.getElementById('form-editar-cosecha-maestro');

        if (!container || !form) {
            console.error('[UI] Formulario editar cosecha maestro no encontrado');
            return;
        }

        // Llenar formulario con datos
        document.getElementById('editar-cosecha-maestro-id').value = cosecha.id || '';
        document.getElementById('editar-cosecha-maestro-producto').value = cosecha.productoId || '';

        // Formatear fecha para input datetime-local
        if (cosecha.fechaCosecha) {
            const fecha = new Date(cosecha.fechaCosecha);
            const fechaLocal = new Date(fecha.getTime() - fecha.getTimezoneOffset() * 60000);
            document.getElementById('editar-cosecha-maestro-fecha').value = fechaLocal.toISOString().slice(0, 16);
        }

        document.getElementById('editar-cosecha-maestro-cantidad').value = cosecha.cantidadRecolectada || '';
        document.getElementById('editar-cosecha-maestro-calidad').value = cosecha.calidadProducto || '';
        document.getElementById('editar-cosecha-maestro-estado').value = cosecha.estadoCosecha || '';
        document.getElementById('editar-cosecha-maestro-trabajadores').value = cosecha.numeroTrabajadores || '';
        document.getElementById('editar-cosecha-maestro-costo').value = cosecha.costoManoObra || '';
        document.getElementById('editar-cosecha-maestro-clima').value = cosecha.condicionesClimaticas || '';
        document.getElementById('editar-cosecha-maestro-observaciones').value = cosecha.observaciones || '';

        container.classList.remove('hidden');

        // Scroll al formulario
        container.scrollIntoView({ behavior: 'smooth', block: 'start' });

        console.log(`[UI] Formulario editar cosecha maestro mostrado para ID: ${cosecha.id}`);
    },

    /**
     * Oculta el formulario de EDITAR cosecha en maestro-detalle
     */
    ocultarFormularioEditarCosechaMaestro() {
        const container = document.getElementById('form-editar-cosecha-maestro-container');
        const form = document.getElementById('form-editar-cosecha-maestro');

        if (container && form) {
            container.classList.add('hidden');
            form.reset();
        }

        console.log('[UI] Formulario editar cosecha maestro ocultado');
    },

    /**
     * Obtiene los datos del formulario de CREAR cosecha maestro
     */
    obtenerDatosFormularioCrearCosechaMaestro() {
        return {
            productoId: document.getElementById('crear-cosecha-maestro-producto').value,
            fechaCosecha: document.getElementById('crear-cosecha-maestro-fecha').value,
            cantidadRecolectada: parseInt(document.getElementById('crear-cosecha-maestro-cantidad').value),
            calidadProducto: document.getElementById('crear-cosecha-maestro-calidad').value,
            estadoCosecha: document.getElementById('crear-cosecha-maestro-estado').value || 'Pendiente',
            numeroTrabajadores: parseInt(document.getElementById('crear-cosecha-maestro-trabajadores').value) || null,
            costoManoObra: parseFloat(document.getElementById('crear-cosecha-maestro-costo').value) || null,
            condicionesClimaticas: document.getElementById('crear-cosecha-maestro-clima').value,
            observaciones: document.getElementById('crear-cosecha-maestro-observaciones').value
        };
    },

    /**
     * Obtiene los datos del formulario de EDITAR cosecha maestro
     */
    obtenerDatosFormularioEditarCosechaMaestro() {
        return {
            id: document.getElementById('editar-cosecha-maestro-id').value,
            productoId: document.getElementById('editar-cosecha-maestro-producto').value,
            fechaCosecha: document.getElementById('editar-cosecha-maestro-fecha').value,
            cantidadRecolectada: parseInt(document.getElementById('editar-cosecha-maestro-cantidad').value),
            calidadProducto: document.getElementById('editar-cosecha-maestro-calidad').value,
            estadoCosecha: document.getElementById('editar-cosecha-maestro-estado').value || 'Pendiente',
            numeroTrabajadores: parseInt(document.getElementById('editar-cosecha-maestro-trabajadores').value) || null,
            costoManoObra: parseFloat(document.getElementById('editar-cosecha-maestro-costo').value) || null,
            condicionesClimaticas: document.getElementById('editar-cosecha-maestro-clima').value,
            observaciones: document.getElementById('editar-cosecha-maestro-observaciones').value
        };
    }
};

// Log de inicialización
console.log('[UI] Módulo de UI cargado');