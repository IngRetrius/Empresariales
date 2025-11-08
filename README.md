# Sistema de Gestión Agropecuaria

Sistema multi-tier de gestión agropecuaria desarrollado para la Universidad de Ibagué. Proyecto académico de Desarrollo de Aplicaciones Empresariales.

**Estudiante:** Juan Camilo Perea Possos
**Institución:** Universidad de Ibagué - Facultad de Ingeniería
**Periodo:** 2025B

## Descripción General

Sistema completo de gestión agropecuaria que permite administrar productos agrícolas y sus cosechas a través de múltiples interfaces de usuario, todas conectadas a un backend REST centralizado.

## Arquitectura del Sistema

```
┌──────────────────────┐         ┌──────────────────────┐
│  Cliente Desktop     │         │   Cliente Web        │
│  (C# WinForms)       │         │   (HTML/JS/CSS)      │
└──────────┬───────────┘         └──────────┬───────────┘
           │                                │
           │         HTTP REST              │
           │         (JSON)                 │
           └────────────┬───────────────────┘
                        │
                        ▼
           ┌────────────────────────┐
           │  API REST Spring Boot  │
           │  (AgroMicroservicio)   │
           │  Puerto: 8081          │
           └────────────┬───────────┘
                        │
                        │ JDBC/JPA
                        ▼
           ┌────────────────────────┐
           │    MySQL Database      │
           │  agropecuario_db       │
           │  Puerto: 3306          │
           └────────────────────────┘
```

## Componentes del Proyecto

### 1. AgroMicroservicio (Backend)
- **Tecnología:** Java 21 + Spring Boot
- **Base de datos:** MySQL 8.0+
- **Arquitectura:** REST API con 4 capas (Controller, Service, Repository, Model)
- **Puerto:** 8081
- **Documentación:** [AgroMicroservicio/README.md](AgroMicroservicio/README.md)

### 2. ClienteGestionAgro (Cliente Desktop)
- **Tecnología:** C# Windows Forms + .NET Framework 4.7.2
- **Plataforma:** Windows
- **Documentación:** [ClienteGestionAgro/README.md](ClienteGestionAgro/README.md)

### 3. Cliente2GestionAgro (Cliente Web)
- **Tecnología:** HTML5 + CSS3 + JavaScript vanilla
- **Características:** Responsive, sin frameworks
- **Puerto:** 8080
- **Documentación:** [Cliente2GestionAgro/cliente-web/README.md](Cliente2GestionAgro/cliente-web/README.md)

## Inicio Rápido

### Prerrequisitos

- **Java 21** o superior
- **Maven 3.8+**
- **MySQL 8.0+**
- **Visual Studio** (para cliente desktop)
- **Python 3** o servidor HTTP (para cliente web)

### 1. Configurar la Base de Datos

```bash
cd AgroMicroservicio/database
mysql -u root -p < schema.sql
```

Esto crea:
- Base de datos: `agropecuario_db`
- Usuario: `agropecuario_user`
- Contraseña: `agropecuario_password`

### 2. Iniciar el Backend

```bash
cd AgroMicroservicio
mvn spring-boot:run
```

El servidor estará disponible en `http://localhost:8081`

### 3. Iniciar Cliente Web

```bash
cd Cliente2GestionAgro/cliente-web
python -m http.server 8080
```

Acceder a `http://localhost:8080`

### 4. Iniciar Cliente Desktop

1. Abrir `ClienteGestionAgro/AgropecuarioCliente.sln` en Visual Studio
2. Restaurar paquetes NuGet
3. Compilar solución (Ctrl+Shift+B)
4. Ejecutar (F5)

## Funcionalidades Principales

### Gestión de Productos Agrícolas (Maestro)
- Crear, leer, actualizar y eliminar productos
- Filtrar por tipo de cultivo
- Estadísticas de productos

### Gestión de Cosechas (Detalle)
- Registrar cosechas asociadas a productos
- Consultar historial de cosechas
- Estadísticas por producto
- Relación maestro-detalle (1:N)

## Endpoints de la API

### Productos
- `GET /api/productos` - Listar todos los productos
- `GET /api/productos/{id}` - Obtener producto por ID
- `POST /api/productos` - Crear producto
- `PUT /api/productos/{id}` - Actualizar producto
- `DELETE /api/productos/{id}` - Eliminar producto

### Cosechas (acceso directo)
- `GET /api/cosechas` - Listar todas las cosechas
- `GET /api/cosechas/{id}` - Obtener cosecha por ID
- `POST /api/cosechas` - Crear cosecha
- `PUT /api/cosechas/{id}` - Actualizar cosecha
- `DELETE /api/cosechas/{id}` - Eliminar cosecha

### Cosechas (anidadas en productos)
- `GET /api/productos/{productoId}/cosechas` - Cosechas de un producto
- `POST /api/productos/{productoId}/cosechas` - Crear cosecha para producto
- `GET /api/productos/{productoId}/cosechas/{cosechaId}` - Cosecha específica
- `PUT /api/productos/{productoId}/cosechas/{cosechaId}` - Actualizar cosecha
- `DELETE /api/productos/{productoId}/cosechas/{cosechaId}` - Eliminar cosecha

## Configuración

### Backend
Editar `AgroMicroservicio/src/main/resources/application.properties`:
```properties
server.port=8081
spring.datasource.url=jdbc:mysql://localhost:3306/agropecuario_db
spring.datasource.username=agropecuario_user
spring.datasource.password=agropecuario_password
```

### Cliente Web
Editar `Cliente2GestionAgro/cliente-web/js/config.js`:
```javascript
const CONFIG = {
    API_BASE_URL: 'http://localhost:8081/api'
};
```

### Cliente Desktop
Editar `ClienteGestionAgro/AgropecuarioCliente/Services/ApiService.cs`:
```csharp
private readonly string _baseUrl = "http://localhost:8081/api/productos";
```

## Pruebas

### Verificar Backend
```bash
curl http://localhost:8081/actuator/health
curl http://localhost:8081/api/productos
```

### Ejecutar Tests
```bash
cd AgroMicroservicio
mvn test
```

## Estructura del Proyecto

```
.
├── AgroMicroservicio/           # Backend Spring Boot
│   ├── src/main/java/          # Código fuente Java
│   ├── src/main/resources/     # Configuración
│   ├── database/               # Scripts SQL
│   └── pom.xml                 # Dependencias Maven
│
├── ClienteGestionAgro/         # Cliente Desktop C#
│   ├── AgropecuarioCliente/    # Proyecto principal
│   └── AgropecuarioCliente.sln # Solución Visual Studio
│
├── Cliente2GestionAgro/        # Cliente Web
│   └── cliente-web/
│       ├── index.html          # Página principal
│       ├── css/                # Estilos
│       └── js/                 # JavaScript
│
├── CLAUDE.md                   # Documentación detallada para Claude Code
└── README.md                   # Este archivo
```

## Tecnologías Utilizadas

### Backend
- Java 21
- Spring Boot 3.2.0
- Spring Data JPA
- MySQL 8.0
- Maven
- Hibernate

### Cliente Desktop
- C# / .NET Framework 4.7.2
- Windows Forms
- Newtonsoft.Json
- HttpClient

### Cliente Web
- HTML5
- CSS3
- JavaScript (ES6+)
- Fetch API

## Características Técnicas

- **Patrón Arquitectónico:** Cliente-Servidor con API REST
- **Base de Datos:** MySQL con JPA/Hibernate
- **Seguridad:** CORS configurado para desarrollo
- **Validación:** Bean Validation (backend) + validación en clientes
- **Generación de IDs:** Automática (AGR001, COS001, etc.)
- **Respuestas:** Formato estandarizado con `ApiResponseDTO`
- **Manejo de Errores:** `GlobalExceptionHandler` centralizado
- **Zona Horaria:** America/Bogota

## Solución de Problemas

### El backend no inicia
1. Verificar que MySQL esté corriendo
2. Confirmar que existe la base de datos `agropecuario_db`
3. Revisar el puerto 8081 esté disponible
4. Verificar credenciales en `application.properties`

### Los clientes no se conectan
1. Verificar que el backend esté corriendo: `curl http://localhost:8081/actuator/health`
2. Revisar configuración CORS en el backend
3. Confirmar URL correcta en configuración de clientes

### Error CORS en cliente web
1. Ejecutar cliente web desde servidor HTTP (no desde `file://`)
2. Verificar configuración CORS en `application.properties`

## Documentación Adicional

- [Documentación completa del Backend](AgroMicroservicio/README.md)
- [Guía de configuración](AgroMicroservicio/CONFIGURATION.md)
- [Explicación de conexión a BD](AgroMicroservicio/EXPLICACION_CONEXION_BD.md)
- [Guía para Claude Code](CLAUDE.md)

## Licencia

Proyecto académico - Universidad de Ibagué

## Contacto

**Estudiante:** Juan Camilo Perea Possos
**Universidad:** Universidad de Ibagué
**Facultad:** Ingeniería
**Curso:** Desarrollo de Aplicaciones Empresariales
