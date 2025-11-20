# Corrección: Modal de Editar Insumos no se mostraba

**Fecha**: 20 de Noviembre de 2025
**Problema**: Al hacer clic en "Editar" en la tabla de insumos, el backend procesaba la solicitud correctamente pero el modal no se mostraba en el frontend.

## Diagnóstico

### Logs del Backend (Correctos)
```
2025-11-20T14:58:30.211 INFO  c.u.a.i.controller.InsumoController : GET /api/insumos/INS004
2025-11-20T14:58:30.212 DEBUG c.u.a.insumos.service.InsumoServiceImpl : Buscando insumo por ID: INS004
```

El backend estaba funcionando correctamente y devolviendo el insumo solicitado.

### Problema en el Frontend

**Causa raíz**: Incompatibilidad entre el nombre de la clase CSS y el JavaScript.

- **CSS** (`_modals.css`): Usa la clase `show` para mostrar modales
  ```css
  .modal.show {
      display: flex;
      align-items: center;
      justify-content: center;
  }
  ```

- **JavaScript** (`insumos.js`): Estaba usando la clase `active` incorrectamente
  ```javascript
  // INCORRECTO
  document.getElementById('modal-insumo').classList.add('active');
  ```

## Solución Aplicada

### 1. Corrección de la función global `editarInsumoDesdeTabla`

**ANTES** (líneas 577-588):
```javascript
window.editarInsumoDesdeTabla = async function(id) {
    console.log(`[INSUMOS] Editando insumo desde tabla: ${id}`);
    try {
        const insumo = await API.obtenerInsumoPorId(id);
        if (insumo) {
            abrirModalEditar(insumo);  // Esta función no existía
        }
    } catch (error) {
        console.error('[INSUMOS] Error al cargar insumo:', error);
        UI.mostrarToast('Error al cargar el insumo', 'error');
    }
};
```

**DESPUÉS**:
```javascript
window.editarInsumoDesdeTabla = async function(id) {
    console.log(`[INSUMOS] Editando insumo desde tabla: ${id}`);
    await editarInsumo(id);  // Llama a la función existente
};
```

### 2. Cambio de clase `active` a `show` en `abrirModalCrear()`

**Línea 376**:
```javascript
// ANTES
document.getElementById('modal-insumo').classList.add('active');

// DESPUÉS
document.getElementById('modal-insumo').classList.add('show');
```

### 3. Cambio de clase `active` a `show` en `editarInsumo()`

**Línea 418**:
```javascript
// ANTES
document.getElementById('modal-insumo').classList.add('active');

// DESPUÉS
document.getElementById('modal-insumo').classList.add('show');
```

### 4. Cambio de clase `active` a `show` en `cerrarModal()`

**Línea 430**:
```javascript
// ANTES
document.getElementById('modal-insumo').classList.remove('active');

// DESPUÉS
document.getElementById('modal-insumo').classList.remove('show');
```

## Archivos Modificados

- `js/insumos.js` (4 cambios en 3 funciones)

## Flujo Corregido

1. Usuario hace clic en "Editar" en la tabla
   ```html
   <button onclick="window.editarInsumoDesdeTabla('INS004')">Editar</button>
   ```

2. Se ejecuta la función global
   ```javascript
   window.editarInsumoDesdeTabla('INS004')
   ```

3. Llama a la función local `editarInsumo()`
   ```javascript
   await editarInsumo('INS004');
   ```

4. Obtiene el insumo de la API
   ```javascript
   const insumo = await API.obtenerInsumoPorId('INS004');
   ```

5. Llena el formulario con los datos del insumo

6. Muestra el modal con la clase correcta
   ```javascript
   document.getElementById('modal-insumo').classList.add('show');
   ```

7. El CSS aplica los estilos
   ```css
   .modal.show {
       display: flex;  /* El modal ahora es visible */
   }
   ```

## Pruebas Realizadas

- Hacer clic en "Editar" desde la tabla de insumos
- Verificar que el modal se abre correctamente
- Verificar que los datos del insumo se cargan en el formulario
- Verificar que se puede cerrar el modal
- Verificar que se puede guardar cambios

## Nota Técnica

La clase `active` se usa en otras partes del código para secciones y tabs, pero los modales específicamente requieren la clase `show` según lo definido en `_modals.css`.

## Estado Final

✅ Modal se abre correctamente al hacer clic en "Editar"
✅ Datos del insumo se cargan en el formulario
✅ Modal se cierra correctamente
✅ Funcionalidad completamente restaurada
