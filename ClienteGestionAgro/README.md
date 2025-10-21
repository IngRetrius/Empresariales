# Sistema Agropecuario - Cliente C#

Aplicación de escritorio para la gestión de productos agrícolas que consume servicios web REST.

## Descripción

Cliente desarrollado en C# con Windows Forms que permite realizar operaciones CRUD sobre productos agrícolas mediante una interfaz gráfica intuitiva. Se comunica con un microservicio Java a través de HTTP REST.

## Tecnologías

- C# .NET Framework
- Windows Forms
- HttpClient
- Newtonsoft.Json
- Visual Studio

## Requisitos Previos

- Windows 7 o superior
- .NET Framework 4.7.2 o superior
- Visual Studio 2019 o superior (para desarrollo)
- Microservicio agropecuario ejecutándose en `http://localhost:8081`

## Instalación

### Para Desarrollo
1. Clonar el repositorio
```bash
git clone [url-repositorio]
cd AgropecuarioCliente
```

2. Abrir en Visual Studio
```
AgropecuarioCliente.sln
```

3. Restaurar paquetes NuGet
```
Tools > NuGet Package Manager > Restore NuGet Packages
```

4. Compilar y ejecutar
```
Build > Build Solution
Debug > Start Debugging (F5)
```

### Para Usuario Final
1. Descargar el archivo ejecutable
2. Ejecutar `AgropecuarioCliente.exe`
3. Verificar que el servidor esté ejecutándose en puerto 8081

## Configuración

### Configuración de API
El cliente está configurado para conectarse al servidor en:
```csharp
private readonly string _baseUrl = "http://localhost:8081/api/productos";
```

Para cambiar la URL del servidor, modificar en `Services/ApiService.cs`.

## Funcionalidades

### Menú Principal
- Acceso a todas las funcionalidades
- Atajos de teclado (Ctrl+L, Ctrl+N, etc.)
- Información del proyecto en "Acerca de"

### Gestión de Productos

#### Crear Producto (Ctrl+N)
- Formulario con validaciones
- Campos obligatorios y opcionales
- Confirmación de creación exitosa

#### Listar Productos (Ctrl+L)
- Visualización en grilla
- Filtros por tipo de cultivo, nombre y temporada
- Contador de registros
- Actualización en tiempo real

#### Buscar Producto (Ctrl+F)
- Búsqueda por ID
- Búsqueda por nombre (parcial)
- Búsqueda por tipo de cultivo
- Búsqueda por rango de hectáreas

#### Actualizar Producto (Ctrl+E)
- Búsqueda previa del producto
- Carga automática de datos
- Modificación de campos
- Confirmación de cambios

#### Eliminar Producto (Ctrl+D)
- Búsqueda previa del producto
- Visualización completa de datos
- Confirmación doble para seguridad
- Eliminación permanente

#### Estadísticas (Ctrl+S)
- Resumen general del sistema
- Estadísticas por tipo de cultivo
- Promedios y totales
- Exportación a CSV

## Estructura del Proyecto

```
AgropecuarioCliente/
├── Forms/
│   ├── FormPrincipal.cs          # Menú principal
│   ├── FormCrearProducto.cs      # Crear productos
│   ├── FormActualizarProducto.cs # Actualizar productos
│   ├── FormEliminarProducto.cs   # Eliminar productos
│   ├── FormBuscarProducto.cs     # Buscar productos
│   ├── FormListarProductos.cs    # Listar con filtros
│   ├── FormSelectorProducto.cs   # Selector reutilizable
│   ├── FormEstadisticas.cs       # Reportes
│   └── FormAcercaDe.cs           # Información
├── Models/
│   ├── ProductoAgricola.cs       # Modelo de datos
│   └── ApiResponse.cs            # Respuesta de API
├── Services/
│   └── ApiService.cs             # Comunicación con API
└── Utils/
    └── MessageHelper.cs          # Mensajes al usuario
```

## Modelo de Datos

### ProductoAgricola
```csharp
public class ProductoAgricola
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public double HectareasCultivadas { get; set; }
    public int CantidadProducida { get; set; }
    public DateTime FechaProduccion { get; set; }
    public string TipoCultivo { get; set; }
    public double PrecioVenta { get; set; }
    public double CostoProduccion { get; set; }
    public string Temporada { get; set; }
    public string TipoSuelo { get; set; }
    public string CodigoFinca { get; set; }
}
```

## Validaciones

### Campos Obligatorios
- Nombre del producto (mínimo 2 caracteres)
- Tipo de cultivo
- Hectáreas cultivadas (0.1 - 10,000)
- Cantidad producida (mínimo 1)
- Precio de venta (mínimo $100)
- Costo de producción (mínimo $100)
- Código de finca

### Validaciones de Negocio
- Precio de venta mayor al costo por unidad
- Rangos válidos para hectáreas y cantidades
- Formato correcto de fechas

## Comunicación con API

### Configuración HTTP
```csharp
private readonly HttpClient _httpClient;
private readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings
{
    ContractResolver = new CamelCasePropertyNamesContractResolver(),
    NullValueHandling = NullValueHandling.Include,
    DateFormatString = "yyyy-MM-ddTHH:mm:ss"
};
```

### Operaciones Principales
- `ObtenerTodosAsync()` - Listar productos
- `ObtenerPorIdAsync(id)` - Obtener por ID
- `CrearAsync(producto)` - Crear producto
- `ActualizarAsync(id, producto)` - Actualizar producto
- `EliminarAsync(id)` - Eliminar producto
- `BuscarPorNombreAsync(nombre)` - Buscar por nombre
- `BuscarPorTipoAsync(tipo)` - Buscar por tipo

## Manejo de Errores

### Tipos de Error
- Errores de conexión (servidor no disponible)
- Errores de validación (datos inválidos)
- Errores de negocio (producto no encontrado)
- Timeouts de red

### Estrategia de Manejo
- Mensajes informativos al usuario
- Reintentos automáticos para errores de red
- Validación previa en cliente
- Degradación elegante de funcionalidades

## Características de Usabilidad

### Interfaz de Usuario
- Un formulario por funcionalidad
- Navegación intuitiva
- Confirmaciones para operaciones críticas
- Mensajes de estado claros
- Atajos de teclado

### Experiencia de Usuario
- Validación en tiempo real
- Autocompletado en campos
- Filtros dinámicos
- Carga asíncrona sin bloqueo
- Mensajes de progreso

## Atajos de Teclado

- `Ctrl+L` - Listar Productos
- `Ctrl+N` - Crear Producto
- `Ctrl+E` - Editar Producto
- `Ctrl+D` - Eliminar Producto
- `Ctrl+F` - Buscar Producto
- `Ctrl+S` - Estadísticas
- `Ctrl+Q` - Salir

## Solución de Problemas

### El cliente no se conecta al servidor
1. Verificar que el servidor esté ejecutándose
2. Comprobar la URL en `ApiService.cs`
3. Verificar conectividad de red
4. Revisar configuración de firewall

### Error de validación al crear producto
1. Verificar campos obligatorios
2. Comprobar rangos de valores numéricos
3. Validar formato de datos
4. Revisar conexión con servidor

### Datos no se actualizan
1. Hacer clic en "Actualizar Lista"
2. Verificar filtros aplicados
3. Reiniciar la aplicación
4. Comprobar estado del servidor

## Desarrollo

### Agregar Nuevo Formulario
1. Crear nueva clase heredando de `Form`
2. Diseñar interfaz en diseñador
3. Implementar lógica de negocio
4. Agregar navegación desde menú principal

### Modificar Modelo de Datos
1. Actualizar `ProductoAgricola.cs`
2. Modificar formularios afectados
3. Actualizar validaciones
4. Probar serialización JSON

### Cambiar URL del Servidor
1. Modificar `_baseUrl` en `ApiService.cs`
2. Actualizar configuraciones de timeout
3. Probar conectividad
4. Actualizar documentación

## Compilación

### Debug
```
Build > Build Solution
```

### Release
```
Build > Configuration Manager > Release
Build > Build Solution
```

### Distribución
1. Copiar archivos de `bin/Release/`
2. Incluir dependencias .NET Framework
3. Crear instalador (opcional)
4. Distribuir ejecutable

## Contribución

Universidad de Ibagué - Facultad de Ingeniería  
Desarrollo de Aplicaciones Empresariales  
Segundo Taller 2025B

### Integrantes del Equipo
- Juan Camilo Perea Possos

## Licencia

Proyecto académico - Universidad de Ibagué
