# Correcciones en Página de Insumos - Cliente Web

**Fecha**: 19 de Noviembre de 2025

## Problemas Corregidos

### 1. Botones de Editar/Eliminar no funcionaban en la tabla

**Causa**: Los botones usaban `onclick` con funciones que no estaban definidas globalmente.

**Solución**:
- Agregadas funciones globales `window.editarInsumoDesdeTabla()` y `window.confirmarEliminarInsumoDesdeTabla()`
- Actualizados los botones en la tabla para llamar a estas funciones
- Eliminados emojis de los textos de botones

**Archivos modificados**:
- `js/insumos.js` (líneas 218-223, 572-611)

### 2. Modal "Listado de Insumos" muy pequeño

**Causa**: El modal tenía un `max-width: 600px` que era insuficiente para mostrar todos los campos del formulario.

**Solución**:
- Aumentado `max-width` de `.modal-content` a 800px
- Agregada clase `.modal-dialog` con `max-width: 900px`
- Mejorada la visualización de formularios con muchos campos

**Archivos modificados**:
- `css/components/_modals.css` (líneas 24-41)

### 3. Columna "Acciones" no se veía apropiadamente

**Causa**: La tabla no tenía anchos mínimos definidos y la columna de acciones se comprimía.

**Solución**:
- Agregados `min-width` a todas las columnas del header de la tabla
- Columna "Acciones" ahora tiene `min-width: 160px`
- Cambiado `.table-container` por `.table-responsive` para scroll horizontal
- Agregados estilos específicos para `.btn-group` y `.btn-sm` en tablas

**Archivos modificados**:
- `pages/insumos.html` (líneas 144-169)
- `css/components/_tables.css` (líneas 56-67)

## Cambios Específicos

### insumos.js

```javascript
// ANTES (no funcionaba)
<button onclick="editarInsumo('${insumo.id}')">Editar</button>

// DESPUÉS (funciona correctamente)
<button onclick="window.editarInsumoDesdeTabla('${insumo.id}')">Editar</button>

// Nuevas funciones globales agregadas:
window.editarInsumoDesdeTabla = async function(id) { ... }
window.confirmarEliminarInsumoDesdeTabla = async function(id) { ... }
```

### _modals.css

```css
/* ANTES */
.modal-content {
    max-width: 600px;
}

/* DESPUÉS */
.modal-content {
    max-width: 800px;
}

.modal-dialog {
    max-width: 900px;
}
```

### insumos.html

```html
<!-- ANTES -->
<th>Acciones</th>

<!-- DESPUÉS -->
<th style="min-width: 160px;">Acciones</th>
```

### _tables.css

```css
/* Nuevos estilos agregados */
.table .btn-group {
    display: flex;
    gap: 0.5rem;
    flex-wrap: nowrap;
}

.table .btn-sm {
    padding: 0.375rem 0.75rem;
    font-size: 0.875rem;
    white-space: nowrap;
}
```

## Funcionalidad Restaurada

### Botones de Editar en tabla:
1. Usuario hace clic en "Editar" en cualquier fila
2. Se carga el insumo desde la API
3. Se abre el modal con los datos precargados
4. Usuario puede modificar y guardar

### Botones de Eliminar en tabla:
1. Usuario hace clic en "Eliminar" en cualquier fila
2. Aparece confirmación: "¿Está seguro que desea eliminar este insumo?"
3. Si confirma, se elimina del servidor
4. Se actualiza la tabla automáticamente
5. Se muestra toast de confirmación

### Modal mejorado:
- Ahora se ven todos los campos sin necesidad de scroll excesivo
- Mejor distribución de los campos en dos columnas
- Los botones de acción se ven correctamente

### Tabla mejorada:
- Scroll horizontal si es necesario (responsive)
- Columna "Acciones" siempre visible con ancho fijo
- Botones "Editar" y "Eliminar" con espacio apropiado
- Sin emojis en los botones (solo texto)

## Pruebas Realizadas

- Editar insumo desde tabla
- Eliminar insumo desde tabla con confirmación
- Visualización del modal en pantallas pequeñas
- Scroll horizontal de la tabla en móviles
- Alineación de columnas y botones

## Archivos Afectados

1. `js/insumos.js` - Funciones globales para onclick
2. `css/components/_modals.css` - Tamaño del modal aumentado
3. `pages/insumos.html` - Min-width en columnas de tabla
4. `css/components/_tables.css` - Estilos para botones en tabla

## Notas Técnicas

- Las funciones se agregaron al objeto `window` para que sean accesibles desde `onclick` en HTML generado dinámicamente
- Se mantiene el patrón async/await para las operaciones con la API
- Los botones ahora muestran texto claro ("Editar", "Eliminar") en lugar de emojis
- La tabla usa `table-responsive` para mejor comportamiento en móviles
