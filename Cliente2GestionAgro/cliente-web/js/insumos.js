/**
 * SISTEMA DE GESTIÓN AGROPECUARIA
 * Universidad de Ibagué
 * insumos.js - Gestión de Insumos Agrícolas
 */

// ==================== ESTADO GLOBAL ====================
let insumosData = [];
let productosData = [];
let insumoActual = null;
let modoEdicion = false;

// ==================== INICIALIZACIÓN ====================
document.addEventListener('DOMContentLoaded', async () => {
    console.log('[INSUMOS] Inicializando módulo de insumos');

    await inicializarModulo();
    configurarEventListeners();
});

/**
 * Inicializa el módulo cargando datos necesarios
 */
async function inicializarModulo() {
    try {
        // Cargar productos para el select
        await cargarProductos();

        // Cargar insumos
        await cargarInsumos();

        // Cargar opciones de tipo de insumo
        cargarOpcionesTipoInsumo();

        // Cargar opciones de unidad de medida
        cargarOpcionesUnidadMedida();

        console.log('[INSUMOS] Módulo inicializado correctamente');
    } catch (error) {
        console.error('[INSUMOS] Error al inicializar:', error);
        UI.mostrarToast(CONFIG.MENSAJES.ERROR_CARGAR_INSUMOS, 'error');
    }
}

/**
 * Configura todos los event listeners
 */
function configurarEventListeners() {
    // Botón crear insumo
    document.getElementById('btn-crear-insumo').addEventListener('click', abrirModalCrear);

    // Botón buscar insumo individual
    document.getElementById('btn-buscar-insumo-individual').addEventListener('click', buscarInsumoIndividual);

    // Botón cerrar resultado búsqueda
    document.getElementById('btn-cerrar-resultado-insumo').addEventListener('click', cerrarResultadoBusqueda);

    // Botones de acciones en resultado
    document.getElementById('btn-editar-resultado-insumo').addEventListener('click', editarInsumoDesdeResultado);
    document.getElementById('btn-eliminar-resultado-insumo').addEventListener('click', eliminarInsumoDesdeResultado);

    // Filtros
    document.getElementById('filtro-tipo-insumo').addEventListener('change', aplicarFiltros);
    document.getElementById('filtro-producto-insumo').addEventListener('change', aplicarFiltros);
    document.getElementById('filtro-proveedor-insumo').addEventListener('input', aplicarFiltros);
    document.getElementById('btn-limpiar-filtros-insumo').addEventListener('click', limpiarFiltros);

    // Botón refrescar
    document.getElementById('btn-refrescar-insumos').addEventListener('click', cargarInsumos);

    // Modal
    document.getElementById('btn-cerrar-modal-insumo').addEventListener('click', cerrarModal);
    document.getElementById('btn-cancelar-insumo').addEventListener('click', cerrarModal);
    document.getElementById('form-insumo').addEventListener('submit', guardarInsumo);

    // Enter en búsqueda individual
    document.getElementById('input-buscar-insumo-id').addEventListener('keypress', (e) => {
        if (e.key === 'Enter') {
            buscarInsumoIndividual();
        }
    });
}

// ==================== CARGA DE DATOS ====================

/**
 * Carga todos los insumos desde la API
 */
async function cargarInsumos() {
    try {
        console.log('[INSUMOS] Cargando insumos...');

        const tbody = document.getElementById('tbody-insumos');
        tbody.innerHTML = '<tr><td colspan="10" class="text-center">Cargando insumos...</td></tr>';

        insumosData = await API.obtenerInsumos();
        console.log(`[INSUMOS] ${insumosData.length} insumos cargados`);

        renderizarTablaInsumos(insumosData);
        actualizarContadorInsumos(insumosData.length);

    } catch (error) {
        console.error('[INSUMOS] Error al cargar insumos:', error);
        const tbody = document.getElementById('tbody-insumos');
        tbody.innerHTML = `
            <tr>
                <td colspan="10" class="text-center error">
                    ${CONFIG.MENSAJES.ERROR_CARGAR_INSUMOS}: ${error.message}
                </td>
            </tr>
        `;
        UI.mostrarToast(CONFIG.MENSAJES.ERROR_CARGAR_INSUMOS, 'error');
    }
}

/**
 * Carga todos los productos para los selects
 */
async function cargarProductos() {
    try {
        productosData = await API.obtenerProductos();
        console.log(`[INSUMOS] ${productosData.length} productos cargados para selects`);

        // Llenar select en modal
        const selectModal = document.getElementById('insumo-producto-id');
        selectModal.innerHTML = '<option value="">Seleccione producto...</option>';

        productosData.forEach(producto => {
            const option = document.createElement('option');
            option.value = producto.id;
            option.textContent = `${producto.id} - ${producto.nombre}`;
            selectModal.appendChild(option);
        });

        // Llenar select en filtros
        const selectFiltro = document.getElementById('filtro-producto-insumo');
        selectFiltro.innerHTML = '<option value="">Seleccione producto...</option>';

        productosData.forEach(producto => {
            const option = document.createElement('option');
            option.value = producto.id;
            option.textContent = `${producto.id} - ${producto.nombre}`;
            selectFiltro.appendChild(option);
        });

    } catch (error) {
        console.error('[INSUMOS] Error al cargar productos:', error);
        UI.mostrarToast('Error al cargar lista de productos', 'error');
    }
}

/**
 * Carga las opciones de tipo de insumo desde CONFIG
 */
function cargarOpcionesTipoInsumo() {
    const select = document.getElementById('insumo-tipo');
    const selectFiltro = document.getElementById('filtro-tipo-insumo');

    select.innerHTML = '<option value="">Seleccione tipo...</option>';
    selectFiltro.innerHTML = '<option value="">Todos los tipos...</option>';

    CONFIG.TIPOS_INSUMO.forEach(tipo => {
        const option = document.createElement('option');
        option.value = tipo;
        option.textContent = formatearTipoInsumo(tipo);
        select.appendChild(option.cloneNode(true));
        selectFiltro.appendChild(option);
    });
}

/**
 * Carga las opciones de unidad de medida desde CONFIG
 */
function cargarOpcionesUnidadMedida() {
    const select = document.getElementById('insumo-unidad-medida');
    select.innerHTML = '<option value="">Seleccione unidad...</option>';

    CONFIG.UNIDADES_MEDIDA.forEach(unidad => {
        const option = document.createElement('option');
        option.value = unidad;
        option.textContent = unidad;
        select.appendChild(option);
    });
}

// ==================== RENDERIZADO ====================

/**
 * Renderiza la tabla de insumos
 */
function renderizarTablaInsumos(insumos) {
    const tbody = document.getElementById('tbody-insumos');

    if (!insumos || insumos.length === 0) {
        tbody.innerHTML = `
            <tr>
                <td colspan="10" class="text-center">
                    ${CONFIG.MENSAJES.SIN_DATOS}
                </td>
            </tr>
        `;
        return;
    }

    tbody.innerHTML = insumos.map(insumo => `
        <tr>
            <td>${insumo.id || 'N/A'}</td>
            <td>${insumo.nombre || 'N/A'}</td>
            <td>${insumo.productoId || 'N/A'}</td>
            <td><span class="badge badge-info">${formatearTipoInsumo(insumo.tipo)}</span></td>
            <td>${API.formatearNumero(insumo.cantidad || 0)} ${insumo.unidadMedida || ''}</td>
            <td>${API.formatearMoneda(insumo.costoUnitario || 0)}</td>
            <td><strong>${API.formatearMoneda(insumo.costoTotal || 0)}</strong></td>
            <td>${insumo.proveedor || 'N/A'}</td>
            <td>${formatearFechaCorta(insumo.fechaCompra)}</td>
            <td>
                <div class="btn-group">
                    <button class="btn btn-sm btn-warning" onclick="editarInsumo('${insumo.id}')" title="Editar">
                        ✏️
                    </button>
                    <button class="btn btn-sm btn-danger" onclick="confirmarEliminarInsumo('${insumo.id}')" title="Eliminar">
                        🗑️
                    </button>
                </div>
            </td>
        </tr>
    `).join('');
}

/**
 * Actualiza el contador de insumos
 */
function actualizarContadorInsumos(total) {
    const badge = document.getElementById('total-insumos');
    badge.textContent = `Total: ${total}`;
}

// ==================== BÚSQUEDA INDIVIDUAL ====================

/**
 * Busca un insumo por ID
 */
async function buscarInsumoIndividual() {
    const inputId = document.getElementById('input-buscar-insumo-id');
    const id = inputId.value.trim();

    if (!id) {
        UI.mostrarToast('Por favor ingrese un ID de insumo', 'warning');
        return;
    }

    try {
        console.log(`[INSUMOS] Buscando insumo: ${id}`);
        const insumo = await API.obtenerInsumoPorId(id);

        mostrarResultadoBusqueda(insumo);
        inputId.value = '';

    } catch (error) {
        console.error('[INSUMOS] Error al buscar insumo:', error);
        UI.mostrarToast(CONFIG.MENSAJES.INSUMO_NO_ENCONTRADO, 'error');
    }
}

/**
 * Muestra el resultado de la búsqueda individual
 */
function mostrarResultadoBusqueda(insumo) {
    insumoActual = insumo;

    document.getElementById('resultado-insumo-id').value = insumo.id || '';
    document.getElementById('resultado-insumo-nombre').value = insumo.nombre || '';
    document.getElementById('resultado-insumo-producto-id').value = insumo.productoId || '';
    document.getElementById('resultado-insumo-tipo').value = formatearTipoInsumo(insumo.tipo);
    document.getElementById('resultado-insumo-cantidad').value = `${insumo.cantidad} ${insumo.unidadMedida || ''}`;
    document.getElementById('resultado-insumo-costo-unitario').value = API.formatearMoneda(insumo.costoUnitario);
    document.getElementById('resultado-insumo-costo-total').value = API.formatearMoneda(insumo.costoTotal);
    document.getElementById('resultado-insumo-proveedor').value = insumo.proveedor || '';
    document.getElementById('resultado-insumo-fecha-compra').value = API.formatearFechaDesdeAPI(insumo.fechaCompra);
    document.getElementById('resultado-insumo-unidad-medida').value = insumo.unidadMedida || '';

    document.getElementById('resultado-busqueda-insumo').classList.remove('hidden');
}

/**
 * Cierra el resultado de búsqueda
 */
function cerrarResultadoBusqueda() {
    document.getElementById('resultado-busqueda-insumo').classList.add('hidden');
    insumoActual = null;
}

/**
 * Edita el insumo desde el resultado de búsqueda
 */
function editarInsumoDesdeResultado() {
    if (insumoActual) {
        editarInsumo(insumoActual.id);
    }
}

/**
 * Elimina el insumo desde el resultado de búsqueda
 */
function eliminarInsumoDesdeResultado() {
    if (insumoActual) {
        confirmarEliminarInsumo(insumoActual.id);
    }
}

// ==================== FILTROS ====================

/**
 * Aplica los filtros a la tabla
 */
function aplicarFiltros() {
    const tipoFiltro = document.getElementById('filtro-tipo-insumo').value;
    const productoFiltro = document.getElementById('filtro-producto-insumo').value;
    const proveedorFiltro = document.getElementById('filtro-proveedor-insumo').value.toLowerCase();

    let insumosFiltrados = insumosData;

    // Filtrar por tipo
    if (tipoFiltro) {
        insumosFiltrados = insumosFiltrados.filter(insumo => insumo.tipo === tipoFiltro);
    }

    // Filtrar por producto
    if (productoFiltro) {
        insumosFiltrados = insumosFiltrados.filter(insumo => insumo.productoId === productoFiltro);
    }

    // Filtrar por proveedor
    if (proveedorFiltro) {
        insumosFiltrados = insumosFiltrados.filter(insumo =>
            (insumo.proveedor || '').toLowerCase().includes(proveedorFiltro)
        );
    }

    console.log(`[INSUMOS] Filtros aplicados: ${insumosFiltrados.length} resultados`);
    renderizarTablaInsumos(insumosFiltrados);
    actualizarContadorInsumos(insumosFiltrados.length);
}

/**
 * Limpia todos los filtros
 */
function limpiarFiltros() {
    document.getElementById('filtro-tipo-insumo').value = '';
    document.getElementById('filtro-producto-insumo').value = '';
    document.getElementById('filtro-proveedor-insumo').value = '';

    renderizarTablaInsumos(insumosData);
    actualizarContadorInsumos(insumosData.length);

    UI.mostrarToast('Filtros limpiados', 'info');
}

// ==================== MODAL ====================

/**
 * Abre el modal en modo crear
 */
function abrirModalCrear() {
    modoEdicion = false;
    document.getElementById('modal-insumo-titulo').textContent = 'Crear Insumo';
    document.getElementById('insumo-modo').value = 'crear';
    document.getElementById('form-insumo').reset();
    document.getElementById('insumo-id').value = '';

    // Establecer fecha actual
    const ahora = new Date();
    ahora.setMinutes(ahora.getMinutes() - ahora.getTimezoneOffset());
    document.getElementById('insumo-fecha-compra').value = ahora.toISOString().slice(0, 16);

    document.getElementById('modal-insumo').classList.add('active');
}

/**
 * Abre el modal en modo edición
 */
async function editarInsumo(id) {
    try {
        console.log(`[INSUMOS] Editando insumo: ${id}`);
        const insumo = await API.obtenerInsumoPorId(id);

        modoEdicion = true;
        document.getElementById('modal-insumo-titulo').textContent = 'Editar Insumo';
        document.getElementById('insumo-modo').value = 'editar';
        document.getElementById('insumo-id').value = insumo.id;

        // Llenar formulario
        document.getElementById('insumo-nombre').value = insumo.nombre || '';
        document.getElementById('insumo-producto-id').value = insumo.productoId || '';
        document.getElementById('insumo-tipo').value = insumo.tipo || '';
        document.getElementById('insumo-cantidad').value = insumo.cantidad || '';
        document.getElementById('insumo-unidad-medida').value = insumo.unidadMedida || '';
        document.getElementById('insumo-costo-unitario').value = insumo.costoUnitario || '';
        document.getElementById('insumo-proveedor').value = insumo.proveedor || '';

        // Formatear fecha para datetime-local
        if (insumo.fechaCompra) {
            const fecha = new Date(insumo.fechaCompra);
            fecha.setMinutes(fecha.getMinutes() - fecha.getTimezoneOffset());
            document.getElementById('insumo-fecha-compra').value = fecha.toISOString().slice(0, 16);
        }

        document.getElementById('insumo-lote').value = insumo.lote || '';
        document.getElementById('insumo-descripcion').value = insumo.descripcion || '';
        document.getElementById('insumo-stock-minimo').value = insumo.stockMinimo || '';
        document.getElementById('insumo-ubicacion-almacen').value = insumo.ubicacionAlmacen || '';

        if (insumo.fechaVencimiento) {
            const fechaVenc = new Date(insumo.fechaVencimiento);
            document.getElementById('insumo-fecha-vencimiento').value = fechaVenc.toISOString().split('T')[0];
        }

        document.getElementById('modal-insumo').classList.add('active');

    } catch (error) {
        console.error('[INSUMOS] Error al cargar insumo para editar:', error);
        UI.mostrarToast(CONFIG.MENSAJES.ERROR_CARGAR_INSUMOS, 'error');
    }
}

/**
 * Cierra el modal
 */
function cerrarModal() {
    document.getElementById('modal-insumo').classList.remove('active');
    document.getElementById('form-insumo').reset();
    modoEdicion = false;
}

// ==================== CRUD ====================

/**
 * Guarda un insumo (crear o actualizar)
 */
async function guardarInsumo(event) {
    event.preventDefault();

    const modo = document.getElementById('insumo-modo').value;
    const insumo = obtenerDatosFormulario();

    try {
        if (modo === 'crear') {
            await crearInsumo(insumo);
        } else {
            await actualizarInsumo(insumo);
        }
    } catch (error) {
        console.error('[INSUMOS] Error al guardar:', error);
        UI.mostrarToast(
            modo === 'crear' ? CONFIG.MENSAJES.ERROR_CREAR_INSUMO : CONFIG.MENSAJES.ERROR_ACTUALIZAR_INSUMO,
            'error'
        );
    }
}

/**
 * Crea un nuevo insumo
 */
async function crearInsumo(insumo) {
    console.log('[INSUMOS] Creando insumo:', insumo);

    const resultado = await API.crearInsumo(insumo);
    console.log('[INSUMOS] Insumo creado:', resultado);

    UI.mostrarToast(CONFIG.MENSAJES.INSUMO_CREADO, 'success');
    cerrarModal();
    await cargarInsumos();
}

/**
 * Actualiza un insumo existente
 */
async function actualizarInsumo(insumo) {
    const id = document.getElementById('insumo-id').value;
    console.log(`[INSUMOS] Actualizando insumo: ${id}`, insumo);

    const resultado = await API.actualizarInsumo(id, insumo);
    console.log('[INSUMOS] Insumo actualizado:', resultado);

    UI.mostrarToast(CONFIG.MENSAJES.INSUMO_ACTUALIZADO, 'success');
    cerrarModal();
    await cargarInsumos();
    cerrarResultadoBusqueda();
}

/**
 * Confirma la eliminación de un insumo
 */
function confirmarEliminarInsumo(id) {
    if (confirm(CONFIG.MENSAJES.CONFIRMAR_ELIMINAR)) {
        eliminarInsumo(id);
    }
}

/**
 * Elimina un insumo
 */
async function eliminarInsumo(id) {
    try {
        console.log(`[INSUMOS] Eliminando insumo: ${id}`);

        await API.eliminarInsumo(id);

        UI.mostrarToast(CONFIG.MENSAJES.INSUMO_ELIMINADO, 'success');
        await cargarInsumos();
        cerrarResultadoBusqueda();

    } catch (error) {
        console.error('[INSUMOS] Error al eliminar:', error);
        UI.mostrarToast(CONFIG.MENSAJES.ERROR_ELIMINAR_INSUMO, 'error');
    }
}

// ==================== UTILIDADES ====================

/**
 * Obtiene los datos del formulario
 */
function obtenerDatosFormulario() {
    const fechaCompra = API.formatearFechaParaAPI(document.getElementById('insumo-fecha-compra').value);
    const fechaVencimiento = document.getElementById('insumo-fecha-vencimiento').value || null;

    return {
        nombre: document.getElementById('insumo-nombre').value.trim(),
        productoId: document.getElementById('insumo-producto-id').value,
        tipo: document.getElementById('insumo-tipo').value,
        cantidad: parseInt(document.getElementById('insumo-cantidad').value),
        unidadMedida: document.getElementById('insumo-unidad-medida').value,
        costoUnitario: parseFloat(document.getElementById('insumo-costo-unitario').value),
        proveedor: document.getElementById('insumo-proveedor').value.trim(),
        fechaCompra: fechaCompra,
        lote: document.getElementById('insumo-lote').value.trim() || null,
        descripcion: document.getElementById('insumo-descripcion').value.trim() || null,
        stockMinimo: parseInt(document.getElementById('insumo-stock-minimo').value) || null,
        ubicacionAlmacen: document.getElementById('insumo-ubicacion-almacen').value.trim() || null,
        fechaVencimiento: fechaVencimiento
    };
}

/**
 * Formatea el tipo de insumo para mostrar
 */
function formatearTipoInsumo(tipo) {
    if (!tipo) return 'N/A';
    return tipo.replace(/_/g, ' ').toLowerCase()
        .split(' ')
        .map(word => word.charAt(0).toUpperCase() + word.slice(1))
        .join(' ');
}

/**
 * Formatea una fecha de manera corta
 */
function formatearFechaCorta(fecha) {
    if (!fecha) return 'N/A';
    try {
        const date = new Date(fecha);
        const dia = date.getDate().toString().padStart(2, '0');
        const mes = (date.getMonth() + 1).toString().padStart(2, '0');
        const anio = date.getFullYear();
        return `${dia}/${mes}/${anio}`;
    } catch (error) {
        return 'N/A';
    }
}

// Log de carga del módulo
console.log('[INSUMOS] Módulo insumos.js cargado');
