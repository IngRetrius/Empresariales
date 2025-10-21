# Sistema de Gestión Agropecuaria - Cliente Web

**Universidad de Ibagué**  
**Facultad de Ingeniería**  
**Desarrollo de Aplicaciones Empresariales**  
**Versión: 2.0.0**

---

## Descripción

Cliente web HTML/JavaScript/CSS para consumir la API REST del Sistema de Gestión Agropecuaria. Permite la gestión completa de productos agrícolas y sus cosechas asociadas mediante una interfaz web moderna y responsive.

---

## Características Principales

### Gestión de Productos (Maestro)
- **Crear**: Registrar nuevos productos agrícolas con todos sus atributos
- **Leer**: Listar todos los productos o buscar por tipo de cultivo
- **Actualizar**: Modificar información de productos existentes
- **Eliminar**: Borrar productos del sistema

### Gestión de Cosechas (Detalle)
- **Crear**: Registrar nuevas cosechas asociadas a productos
- **Leer**: Listar todas las cosechas o buscar por calidad
- **Actualizar**: Modificar información de cosechas existentes
- **Eliminar**: Borrar cosechas del sistema

### Relación Maestro-Detalle
- Visualización de productos y sus cosechas asociadas
- Navegación interactiva entre maestro y detalle
- Creación de cosechas directamente desde un producto
- Estadísticas de cosechas por producto
- Panel dividido para mejor experiencia de usuario

### Estadísticas del Sistema
- Total de productos registrados
- Total de cosechas registradas
- Total de kilogramos recolectados
- Producto con más cosechas

---

## Requisitos del Sistema

### Software Necesario
- **Navegador Web Moderno**:
  - Google Chrome 90+
  - Mozilla Firefox 88+
  - Microsoft Edge 90+
  - Safari 14+

- **Servidor REST API**:
  - El servidor debe estar ejecutándose en `http://localhost:8081`
  - Java Spring Boot 3.x
  - Maven 3.6+

### Requisitos Mínimos de Hardware
- Procesador: 1 GHz o superior
- RAM: 2 GB mínimo
- Espacio en disco: 50 MB
- Conexión a Internet: No requerida (funciona en red local)

---

## Instalación

### Opción 1: Abrir directamente en el navegador

1. **Clonar o descargar el proyecto**:
   ```bash
   git clone [URL_DEL_REPOSITORIO]
   cd cliente-web
   ```

2. **Abrir el archivo index.html**:
   - **Windows**: Doble clic en `index.html`
   - **Mac**: `open index.html`
   - **Linux**: `xdg-open index.html`

> **Nota**: Esta opción puede tener problemas de CORS en algunos navegadores.

---

### Opción 2: Usar un servidor local (RECOMENDADO)

#### Con Python 3:
```bash
cd cliente-web
python -m http.server 8080
```
Luego abrir: `http://localhost:8080`

#### Con Node.js (http-server):
```bash
npx http-server cliente-web -p 8080
```
Luego abrir: `http://localhost:8080`

#### Con PHP:
```bash
cd cliente-web
php -S localhost:8080
```
Luego abrir: `http://localhost:8080`

#### Con Visual Studio Code (Live Server):
1. Instalar la extensión "Live Server"
2. Click derecho en `index.html`
3. Seleccionar "Open with Live Server"

---

## Estructura del Proyecto

```
cliente-web/
├── index.html              # Página principal de la aplicación
├── css/
│   └── styles.css          # Estilos CSS completos
├── js/
│   ├── config.js           # Configuración global (URLs, constantes)
│   ├── api.js              # Comunicación con API REST
│   ├── ui.js               # Manipulación del DOM
│   └── app.js              # Lógica principal y controladores
├── assets/                 # Recursos estáticos (opcional)
│   ├── images/
│   └── icons/
└── README.md              # Este archivo
```

---

## Configuración

### Cambiar URL del Servidor

Si el servidor REST está en un puerto diferente, editar `js/config.js`:

```javascript
const CONFIG = {
    API_BASE_URL: 'http://localhost:8081/api',  // Cambiar aquí
    // ...
};
```

### Otras Configuraciones

En `js/config.js` también puedes modificar:
- Timeout de peticiones HTTP
- Opciones de calidad, estados, tipos de cultivo
- Mensajes del sistema
- Validaciones de campos

---

## Uso de la Aplicación

### 1. Gestión de Productos

#### Crear Producto
1. Ir a la pestaña "Productos"
2. Click en "Crear Producto"
3. Completar el formulario:
   - Nombre del producto (requerido)
   - Tipo de cultivo (requerido)
   - Hectáreas cultivadas (requerido)
   - Cantidad producida (requerido)
   - Precio de venta (requerido)
   - Costo de producción (requerido)
   - Temporada (opcional)
   - Tipo de suelo (opcional)
   - Código de finca (opcional)
4. Click en "Guardar"

#### Listar Productos
1. Click en "Listar Todos"
2. La tabla mostrará todos los productos registrados

#### Buscar por Tipo
1. Seleccionar un tipo de cultivo en el filtro
2. Click en "Buscar"

#### Editar Producto
1. En la tabla de productos, click en "Editar"
2. Modificar los campos deseados
3. Click en "Guardar"

#### Eliminar Producto
1. En la tabla de productos, click en "Eliminar"
2. Confirmar la eliminación

---

### 2. Gestión de Cosechas

#### Crear Cosecha
1. Ir a la pestaña "Cosechas"
2. Click en "Crear Cosecha"
3. Completar el formulario:
   - Producto (requerido)
   - Fecha de cosecha (requerido)
   - Cantidad recolectada (requerido)
   - Calidad del producto (requerido)
   - Estado (opcional)
   - Número de trabajadores (opcional)
   - Costo mano de obra (opcional)
   - Condiciones climáticas (opcional)
   - Observaciones (opcional)
4. Click en "Guardar"

#### Listar Cosechas
1. Click en "Listar Todas"
2. La tabla mostrará todas las cosechas registradas

#### Buscar por Calidad
1. Seleccionar una calidad en el filtro
2. Click en "Buscar"

---

### 3. Maestro-Detalle (CLAVE)

Esta es la funcionalidad principal que demuestra la relación entre productos y cosechas.

#### Navegar en Maestro-Detalle
1. Ir a la pestaña "Maestro-Detalle"
2. En el panel izquierdo, se muestran todos los productos
3. Click en un producto para ver sus detalles
4. El panel derecho mostrará:
   - Información completa del producto
   - Estadísticas de cosechas
   - Lista de todas las cosechas asociadas

#### Agregar Cosecha desde Producto
1. Seleccionar un producto en el panel maestro
2. Click en "Agregar Cosecha"
3. El formulario se abrirá con el producto pre-seleccionado
4. Completar los demás campos
5. Click en "Guardar"

#### Ver Cosechas desde la Lista de Productos
1. En la pestaña "Productos", click en "Ver Cosechas"
2. Automáticamente se navegará a Maestro-Detalle
3. El producto se seleccionará y mostrará sus cosechas

---

### 4. Estadísticas

1. Ir a la pestaña "Estadísticas"
2. Ver información en tiempo real:
   - Total de productos
   - Total de cosechas
   - Total de kg recolectados
   - Producto con más cosechas
   - Información del servidor

---

## Endpoints Utilizados

### Productos (MAESTRO)
```
GET    /api/productos                          # Listar todos
GET    /api/productos/{id}                     # Obtener por ID
GET    /api/productos?tipo={tipo}              # Buscar por tipo
POST   /api/productos                          # Crear
PUT    /api/productos/{id}                     # Actualizar
DELETE /api/productos/{id}                     # Eliminar
GET    /api/productos/estadisticas             # Estadísticas
```

### Cosechas (DETALLE)
```
GET    /api/cosechas                           # Listar todas
GET    /api/cosechas/{id}                      # Obtener por ID
GET    /api/cosechas?calidad={calidad}         # Buscar por calidad
POST   /api/cosechas                           # Crear
PUT    /api/cosechas/{id}                      # Actualizar
DELETE /api/cosechas/{id}                      # Eliminar
```

### Maestro-Detalle (CRÍTICO)
```
GET    /api/productos/{productoId}/cosechas                    # Obtener cosechas del producto
POST   /api/productos/{productoId}/cosechas                    # Crear cosecha para producto
GET    /api/productos/{productoId}/cosechas/{cosechaId}        # Obtener cosecha específica
PUT    /api/productos/{productoId}/cosechas/{cosechaId}        # Actualizar cosecha
DELETE /api/productos/{productoId}/cosechas/{cosechaId}        # Eliminar cosecha
GET    /api/productos/{productoId}/cosechas/estadisticas       # Estadísticas del producto
```

---

## Tecnologías Utilizadas

### Frontend
- **HTML5**: Estructura semántica y moderna
- **CSS3**: Estilos con variables CSS, grid, flexbox
- **JavaScript ES6+**: Código modular con async/await, arrow functions
- **Fetch API**: Comunicación asíncrona con el servidor

### Backend (Consumido)
- **Java 17**: Lenguaje del servidor
- **Spring Boot 3.x**: Framework REST API
- **Maven**: Gestor de dependencias

---

## Arquitectura de la Aplicación

```
┌─────────────────────────────────────────────────────┐
│                 CLIENTE WEB                         │
│              (HTML + CSS + JavaScript)              │
│                                                     │
│  ┌──────────────────────────────────────────────┐ │
│  │           index.html (Vista)                 │ │
│  └──────────────────────────────────────────────┘ │
│                       ↕                            │
│  ┌──────────────────────────────────────────────┐ │
│  │     ui.js (Manipulación del DOM)            │ │
│  └──────────────────────────────────────────────┘ │
│                       ↕                            │
│  ┌──────────────────────────────────────────────┐ │
│  │     app.js (Lógica de Negocio)              │ │
│  └──────────────────────────────────────────────┘ │
│                       ↕                            │
│  ┌──────────────────────────────────────────────┐ │
│  │     api.js (Comunicación HTTP)              │ │
│  └──────────────────────────────────────────────┘ │
└─────────────────────────────────────────────────────┘
                         ↕ HTTP/REST
┌─────────────────────────────────────────────────────┐
│         SERVIDOR REST API (Spring Boot)             │
│              http://localhost:8081/api              │
└─────────────────────────────────────────────────────┘
```

---

## Solución de Problemas

### El servidor no responde

**Problema**: Error de conexión con el servidor

**Solución**:
1. Verificar que el servidor esté ejecutándose:
   ```bash
   cd servidor
   mvn spring-boot:run
   ```
2. Confirmar que el servidor esté en el puerto 8081
3. Verificar en la consola del navegador (F12) los errores de red

---

### Error de CORS

**Problema**: "CORS policy: No 'Access-Control-Allow-Origin' header"

**Solución**:
1. Usar un servidor local (opción 2 de instalación)
2. Verificar que el servidor tenga CORS configurado correctamente
3. El servidor incluye `WebConfig.java` que ya configura CORS

---

### Los datos no se muestran

**Problema**: Las tablas aparecen vacías

**Solución**:
1. Verificar conexión con el servidor (F12 → Network)
2. Revisar la consola del navegador para errores JavaScript
3. Confirmar que el servidor tenga datos de prueba inicializados

---

### Formularios no se envían

**Problema**: Click en "Guardar" no hace nada

**Solución**:
1. Completar todos los campos obligatorios (marcados con *)
2. Revisar validaciones en la consola del navegador
3. Verificar que los datos estén en el formato correcto

---

## Equipo de Desarrollo

- Integrante 1
- Integrante 2
- Integrante 3
- Juan Camilo Perea Possos

---

## Profesor

**Carlos Lugo**  
Email: carlos.lugo@unibague.edu.co

---

## Licencia

© 2025 Universidad de Ibagué  
Proyecto Académico - Desarrollo de Aplicaciones Empresariales

---

## Contacto y Soporte

Para preguntas, reportar errores o sugerencias:

- Email: carlos.lugo@unibague.edu.co
- Universidad: Universidad de Ibagué
- Facultad: Ingeniería
- Curso: Desarrollo de Aplicaciones Empresariales

---

## Notas Adicionales

### Datos de Prueba

El servidor incluye datos de prueba inicializados:

**Productos**:
- AGR001: Café Arábica Premium
- AGR002: Arroz Fedearroz 67
- AGR003: Cacao Trinitario

**Cosechas**:
- 3 cosechas para Café
- 2 cosechas para Arroz
- 3 cosechas para Cacao

### Responsive Design

La aplicación es completamente responsive y funciona en:
- Desktop (1920x1080 y superiores)
- Laptop (1366x768)
- Tablet (768x1024)
- Mobile (360x640 y superiores)

---

**Última actualización**: Enero 2025  
**Versión del documento**: 2.0.0