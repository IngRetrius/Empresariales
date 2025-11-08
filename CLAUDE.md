# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This is a multi-tier agricultural management system for Universidad de Ibagué consisting of three main components:

1. **AgroMicroservicio** - Spring Boot REST API (backend microservice)
2. **ClienteGestionAgro** - C# Windows Forms desktop client
3. **Cliente2GestionAgro** - HTML/JavaScript/CSS web client

**Architecture Pattern:** Client-Server with REST API
- Backend: Java 21 + Spring Boot + MySQL
- Clients: C# Desktop + JavaScript Web (both consume the same REST API)

## Quick Start Commands

### Backend (AgroMicroservicio)

```bash
cd AgroMicroservicio

# Run in development mode
mvn spring-boot:run

# Run tests
mvn test

# Build JAR
mvn clean package

# Run packaged JAR
java -jar target/agropecuario-rest-server-1.0.0.jar
```

**Default URL:** `http://localhost:8081`
**Health check:** `http://localhost:8081/actuator/health`

### C# Desktop Client (ClienteGestionAgro)

```bash
cd ClienteGestionAgro

# Open solution in Visual Studio
start AgropecuarioCliente.sln
```

Then in Visual Studio:
1. Restore NuGet packages
2. Build Solution (Ctrl+Shift+B)
3. Start Debugging (F5)

**Requires:** .NET Framework 4.7.2+, Windows, Backend running on port 8081

### Web Client (Cliente2GestionAgro)

```bash
cd Cliente2GestionAgro/cliente-web

# Option 1: Python
python -m http.server 8080

# Option 2: Node.js
npx http-server -p 8080

# Option 3: PHP
php -S localhost:8080
```

**Access:** `http://localhost:8080`
**Requires:** Backend running on port 8081

## Database Setup

The backend requires MySQL 8.0+. Run once before first startup:

```bash
cd AgroMicroservicio/database

# Connect to MySQL and execute
mysql -u root -p < schema.sql
```

**Database credentials:**
- Database: `agropecuario_db`
- User: `agropecuario_user`
- Password: `agropecuario_password`
- Host: `localhost:3306`

See `AgroMicroservicio/database/README_DATABASE.md` for detailed setup instructions.

## High-Level Architecture

```
┌──────────────────────┐         ┌──────────────────────┐
│  C# Desktop Client   │         │   Web Client (HTML)  │
│  (Windows Forms)     │         │   (JavaScript/CSS)   │
│  Port: N/A           │         │   Port: 8080         │
└──────────┬───────────┘         └──────────┬───────────┘
           │                                │
           │         HTTP REST              │
           │         (JSON)                 │
           └────────────┬───────────────────┘
                        │
                        ▼
           ┌────────────────────────┐
           │  Spring Boot REST API  │
           │  (AgroMicroservicio)   │
           │  Port: 8081            │
           └────────────┬───────────┘
                        │
                        │ JDBC/JPA
                        ▼
           ┌────────────────────────┐
           │    MySQL Database      │
           │  agropecuario_db       │
           │  Port: 3306            │
           └────────────────────────┘
```

## Backend Architecture (AgroMicroservicio)

The backend follows a strict 4-layer architecture:

1. **Controller Layer** - REST endpoints, validation
2. **Service Layer** - Business logic, transactions
3. **Repository Layer** - Data access with JPA
4. **Model/DTO Layer** - Entities and data transfer objects

**Master-Detail Relationship:**
- **Master:** `ProductoAgricola` (Agricultural Product)
- **Detail:** `Cosecha` (Harvest) - contains `productoId` foreign key
- Relationship: One product has many harvests (1:N)

**Two ways to access harvests:**
1. **Nested routes** (preferred for master-detail): `/api/productos/{productoId}/cosechas`
2. **Direct routes**: `/api/cosechas`

**Key architectural detail:** Nested harvest endpoints are in `ProductoAgricolaController`, not `CosechaController`.

For complete backend architecture details, see: `AgroMicroservicio/CLAUDE.md`

## API Endpoints

### Products (Master)
- `GET /api/productos` - List all products
- `GET /api/productos/{id}` - Get product by ID
- `POST /api/productos` - Create product
- `PUT /api/productos/{id}` - Update product
- `DELETE /api/productos/{id}` - Delete product
- `GET /api/productos?tipo={tipo}` - Filter by type
- `GET /api/productos/estadisticas` - Statistics

### Harvests (Detail) - Direct Access
- `GET /api/cosechas` - List all harvests
- `GET /api/cosechas/{id}` - Get harvest by ID
- `POST /api/cosechas` - Create harvest
- `PUT /api/cosechas/{id}` - Update harvest
- `DELETE /api/cosechas/{id}` - Delete harvest

### Harvests (Detail) - Nested via Product
- `GET /api/productos/{productoId}/cosechas` - Get product's harvests
- `POST /api/productos/{productoId}/cosechas` - Create harvest for product
- `GET /api/productos/{productoId}/cosechas/{cosechaId}` - Get specific harvest
- `PUT /api/productos/{productoId}/cosechas/{cosechaId}` - Update harvest
- `DELETE /api/productos/{productoId}/cosechas/{cosechaId}` - Delete harvest
- `GET /api/productos/{productoId}/cosechas/estadisticas` - Harvest statistics for product

All responses use standardized `ApiResponseDTO<T>` format.

## Configuration

### Backend Configuration
All backend settings centralized in `application.properties`:
- Server port: `server.port=8081`
- Database: `spring.datasource.*`
- CORS: `cors.*`
- Logging: `logging.level.*`

See `AgroMicroservicio/CONFIGURATION.md` for complete configuration guide.

### Web Client Configuration
Edit `Cliente2GestionAgro/cliente-web/js/config.js`:
```javascript
const CONFIG = {
    API_BASE_URL: 'http://localhost:8081/api',
    // ...
};
```

### C# Desktop Client Configuration
Edit `ClienteGestionAgro/AgropecuarioCliente/Services/ApiService.cs`:
```csharp
private readonly string _baseUrl = "http://localhost:8081/api/productos";
```

## Development Workflow

### Starting the full stack:

1. **Start MySQL** (if not running)
2. **Start Backend:**
   ```bash
   cd AgroMicroservicio
   mvn spring-boot:run
   ```
3. **Start Web Client:**
   ```bash
   cd Cliente2GestionAgro/cliente-web
   python -m http.server 8080
   ```
4. **Or Start Desktop Client:**
   - Open Visual Studio solution
   - Press F5

### Making changes to the API:

1. Modify backend code in `AgroMicroservicio/`
2. Spring Boot DevTools auto-reloads (no restart needed)
3. Test with: `curl http://localhost:8081/api/productos`
4. Clients automatically use updated API (no changes needed if endpoints unchanged)

## Testing

### Backend Tests
```bash
cd AgroMicroservicio
mvn test                    # Run all tests
mvn test -Dtest=ClassName   # Run specific test
mvn test jacoco:report      # Run with coverage
```

### Manual API Testing
```bash
# Health check
curl http://localhost:8081/actuator/health

# Get all products
curl http://localhost:8081/api/productos

# Get product's harvests
curl http://localhost:8081/api/productos/AGR001/cosechas

# Create product
curl -X POST http://localhost:8081/api/productos \
  -H "Content-Type: application/json" \
  -d '{"nombre":"Café Premium","tipoCultivo":"Café",...}'
```

## Key Files and Directories

```
.
├── AgroMicroservicio/                    # Backend microservice
│   ├── CLAUDE.md                         # Detailed backend documentation
│   ├── CONFIGURATION.md                  # Configuration guide
│   ├── EXPLICACION_CONEXION_BD.md        # Database connection explained
│   ├── database/
│   │   ├── schema.sql                    # Database creation script
│   │   └── README_DATABASE.md            # Database setup guide
│   ├── pom.xml                           # Maven dependencies
│   ├── src/main/java/.../rest/
│   │   ├── controller/                   # REST endpoints
│   │   │   ├── ProductoAgricolaController.java  # Products + nested harvests
│   │   │   └── CosechaController.java           # Direct harvest access
│   │   ├── service/impl/                 # Business logic
│   │   ├── repository/                   # JPA repositories
│   │   ├── model/                        # JPA entities
│   │   │   ├── ProductoAgricola.java     # Master entity
│   │   │   └── Cosecha.java              # Detail entity with @ManyToOne
│   │   ├── dto/                          # DTOs
│   │   ├── exception/                    # Custom exceptions
│   │   ├── utils/                        # Utilities
│   │   └── config/                       # Configuration classes
│   │       ├── WebConfig.java            # CORS configuration
│   │       └── DataLoader.java           # Initial data loader
│   └── src/main/resources/
│       ├── application.properties        # Main config
│       ├── application-dev.properties    # Dev profile
│       └── application-prod.properties   # Prod profile
│
├── ClienteGestionAgro/                   # C# Desktop Client
│   ├── README.md                         # Desktop client documentation
│   ├── AgropecuarioCliente.sln           # Visual Studio solution
│   └── AgropecuarioCliente/
│       ├── Forms/                        # Windows Forms
│       ├── Models/                       # Data models
│       ├── Services/                     # API service layer
│       │   └── ApiService.cs             # HTTP client for REST API
│       └── Utils/                        # Utilities
│
└── Cliente2GestionAgro/                  # Web Client
    └── cliente-web/
        ├── README.md                     # Web client documentation
        ├── index.html                    # Main HTML page
        ├── css/
        │   └── styles.css                # All styles
        └── js/
            ├── config.js                 # Configuration constants
            ├── api.js                    # API calls with Fetch
            ├── ui.js                     # DOM manipulation
            └── app.js                    # Main application logic
```

## Common Development Patterns

### Adding a New Backend Endpoint

1. Add method to service interface (e.g., `ProductoAgricolaService`)
2. Implement in service implementation (e.g., `ProductoAgricolaServiceImpl`)
3. Add repository method if needed (e.g., `ProductoAgricolaJpaRepository`)
4. Create controller endpoint with `@Valid` validation
5. Return `ApiResponseDTO` for consistency

### Modifying Master-Detail Logic

- Always verify `productoId` exists before creating/updating `Cosecha`
- Nested routes in `ProductoAgricolaController` enforce referential integrity
- Service layer validates relationships at business logic level
- Database enforces with foreign key constraint (ON DELETE CASCADE)

### ID Generation Strategy

Backend auto-generates IDs using `IdGeneratorService`:
- Products: `AGR001`, `AGR002`, `AGR003`, ...
- Harvests: `COS001`, `COS002`, `COS003`, ...

**Never provide IDs in POST requests** - the backend generates them.

## Important Notes

### Backend
- Uses **MySQL with JPA/Hibernate** for persistence (not in-memory anymore)
- Port 8081 must be available (configurable in `application.properties`)
- **All configuration is centralized** in `application.properties`
- Timezone: `America/Bogota` (Colombia)
- CORS configured for all origins in development (restrict in production)
- Auto-loads test data on first startup via `DataLoader.java`

### Database
- Foreign key with CASCADE DELETE: deleting a product deletes its harvests
- Transactions ensure data consistency
- HikariCP connection pool for performance
- Hibernate `ddl-auto=update` in development (change to `validate` in production)

### Web Client
- Pure HTML/CSS/JavaScript (no frameworks)
- Responsive design (works on desktop, tablet, mobile)
- Modular JavaScript architecture (config → api → ui → app)
- Must run from HTTP server (not file://) to avoid CORS issues

### C# Desktop Client
- Windows-only (requires .NET Framework)
- Newtonsoft.Json for JSON serialization
- Uses `HttpClient` for API communication
- Keyboard shortcuts: Ctrl+L (list), Ctrl+N (new), Ctrl+E (edit), etc.

## Response Standardization

All API responses use this format:

**Success:**
```json
{
  "success": true,
  "message": "Operation successful",
  "data": { ... },
  "timestamp": "2025-10-20T10:30:00"
}
```

**Error:**
```json
{
  "success": false,
  "error": "Error type",
  "message": "Error description",
  "timestamp": "2025-10-20T10:30:00"
}
```

Built using `ResponseBuilder` utility class in backend.

## Validation

### Backend Validation (Bean Validation)
- `@NotNull`, `@NotBlank` for required fields
- `@Min`, `@Max` for numeric ranges
- `@Size` for string length
- Custom business logic validation in service layer
- All handled by `GlobalExceptionHandler`

### Client-Side Validation
Both clients validate before sending to API:
- Required fields
- Numeric ranges
- String lengths
- Business rules (e.g., price > cost)

## Exception Handling

Backend custom exceptions:
- `ProductoNotFoundException` - Product not found (404)
- `ProductoAlreadyExistsException` - Duplicate product (400)
- `CosechaNotFoundException` - Harvest not found (404)
- `ValidationException` - Validation errors (400)

All exceptions handled by `GlobalExceptionHandler` returning standardized `ErrorResponseDTO`.

## Troubleshooting

### Backend won't start
1. Check MySQL is running: `Get-Service MySQL80` (Windows)
2. Verify database exists: `mysql -u agropecuario_user -p`
3. Check port 8081 is available
4. Review logs for connection errors

### Clients can't connect to backend
1. Verify backend is running: `curl http://localhost:8081/actuator/health`
2. Check CORS configuration in `application.properties`
3. Verify correct API URL in client configuration
4. Check firewall/antivirus settings

### Web client CORS errors
1. Run web client from HTTP server, not `file://`
2. Verify CORS settings in backend allow your origin
3. Check browser console (F12) for specific CORS error

### Database connection failed
1. Verify MySQL is running
2. Check credentials in `application.properties`
3. Test connection: `mysql -u agropecuario_user -pagropecuario_password agropecuario_db`
4. Review `AgroMicroservicio/database/README_DATABASE.md`

## Academic Context

**Universidad de Ibagué**
Facultad de Ingeniería
Desarrollo de Aplicaciones Empresariales
Proyecto Académico 2025B

**Student:** Juan Camilo Perea Possos

This is a teaching project demonstrating:
- Microservices architecture with REST
- Master-detail relationships in databases
- Multi-platform client development
- CRUD operations with Spring Boot
- JPA/Hibernate ORM
- Client-server communication via HTTP/JSON
