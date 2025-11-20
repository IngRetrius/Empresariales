# Microservicio C - Gestión de Insumos Agrícolas

Universidad de Ibagué - Desarrollo de Aplicaciones Empresariales
Tercer Proyecto 2025B

## Descripción

Microservicio para la gestión de insumos agrícolas (fertilizantes, semillas, pesticidas, herramientas) asociados a productos agrícolas. Este microservicio utiliza Oracle Database y se comunica con el Microservicio A-B (Productos y Cosechas) para mantener integridad referencial lógica.

## Características Principales

- **Base de Datos**: Oracle Database
- **Puerto**: 8082
- **Arquitectura**: Spring Boot 3.2.0 + JPA/Hibernate
- **Comunicación**: WebClient (Spring WebFlux) para integración con Microservicio A-B
- **Validación**: Jakarta Validation con reglas de negocio personalizadas
- **Gestión de Errores**: Manejo centralizado con @RestControllerAdvice

## Modelo de Datos

### Entidad: Insumo

| Campo              | Tipo          | Descripción                                    |
|--------------------|---------------|------------------------------------------------|
| id                 | String (PK)   | Identificador único (INS001, INS002, ...)      |
| productoId         | String        | ID del producto agrícola (relación lógica)     |
| nombre             | String        | Nombre del insumo                              |
| cantidad           | Integer       | Cantidad disponible                            |
| costoUnitario      | Double        | Costo por unidad                               |
| fechaCompra        | LocalDateTime | Fecha de adquisición                           |
| proveedor          | String        | Nombre del proveedor                           |
| tipo               | String        | FERTILIZANTE, SEMILLA, PESTICIDA, HERRAMIENTA  |
| descripcion        | String        | Descripción detallada                          |
| unidadMedida       | String        | KG, LITROS, UNIDAD, etc.                       |
| stockMinimo        | Integer       | Cantidad mínima recomendada                    |
| ubicacionAlmacen   | String        | Ubicación física                               |
| fechaVencimiento   | LocalDateTime | Fecha de vencimiento (opcional)                |
| lote               | String        | Número de lote                                 |

### Métodos de Negocio

- `calcularCostoTotal()`: Calcula cantidad × costoUnitario
- `estaVencido()`: Verifica si el insumo está vencido
- `estaProximoAVencer()`: Verifica si vence en 30 días
- `requiereReabastecimiento()`: Verifica si cantidad < stockMinimo

## Requisitos Previos

### 1. Oracle Database

Instalar Oracle Database XE (Express Edition):

**Windows:**
```bash
# Descargar Oracle Database XE desde:
# https://www.oracle.com/database/technologies/xe-downloads.html

# Después de instalar, verificar:
sqlplus sys/admin@localhost:1521/XE as sysdba
```

**Linux/Mac:**
```bash
# Usar Docker (recomendado):
docker run -d -p 1521:1521 -p 5500:5500 \
  --name oracle-xe \
  -e ORACLE_PWD=admin \
  gvenzl/oracle-xe:latest

# Verificar:
docker logs oracle-xe
```

### 2. Crear Base de Datos

Ejecutar en SQL*Plus o SQL Developer:

```sql
-- Conectar como SYSDBA
CONNECT sys/password AS SYSDBA;

-- Crear usuario
CREATE USER microservicio_c IDENTIFIED BY admin;

-- Otorgar permisos
GRANT CONNECT, RESOURCE TO microservicio_c;
GRANT CREATE SESSION TO microservicio_c;
GRANT CREATE TABLE TO microservicio_c;
GRANT CREATE SEQUENCE TO microservicio_c;
GRANT UNLIMITED TABLESPACE TO microservicio_c;

-- Verificar
SELECT username FROM dba_users WHERE username = 'MICROSERVICIO_C';
```

### 3. Java y Maven

```bash
# Verificar instalación
java -version   # Debe ser Java 21
mvn -version    # Debe ser Maven 3.8+
```

## Configuración con Variables de Entorno (Etapa 5)

### Opción 1: Archivo .env (Recomendado para Desarrollo)

1. **Copiar el archivo de ejemplo**:
   ```bash
   cp .env.example .env
   ```

2. **Editar el archivo .env** con tus valores:
   ```bash
   # En Windows
   notepad .env

   # En Linux/Mac
   vim .env
   ```

3. **Cargar las variables de entorno**:

   **Windows (PowerShell)**:
   ```powershell
   Get-Content .env | ForEach-Object {
       if ($_ -match '^([^=]+)=(.*)$') {
           [Environment]::SetEnvironmentVariable($matches[1], $matches[2], "Process")
       }
   }
   ```

   **Linux/Mac (Bash)**:
   ```bash
   export $(cat .env | xargs)
   ```

4. **Ejecutar el microservicio**:
   ```bash
   mvn spring-boot:run
   ```

### Opción 2: Variables de Entorno del Sistema

**Windows**:
```powershell
$env:MICROSERVICIO_C_ORACLE_HOST="localhost"
$env:MICROSERVICIO_C_ORACLE_PORT="1521"
$env:MICROSERVICIO_C_ORACLE_SID="XE"
$env:MICROSERVICIO_C_ORACLE_USERNAME="microservicio_c"
$env:MICROSERVICIO_C_ORACLE_PASSWORD="admin"
$env:MICROSERVICIO_AB_URL="http://localhost:8081"
```

**Linux/Mac**:
```bash
export MICROSERVICIO_C_ORACLE_HOST=localhost
export MICROSERVICIO_C_ORACLE_PORT=1521
export MICROSERVICIO_C_ORACLE_SID=XE
export MICROSERVICIO_C_ORACLE_USERNAME=microservicio_c
export MICROSERVICIO_C_ORACLE_PASSWORD=admin
export MICROSERVICIO_AB_URL=http://localhost:8081
```

### Variables de Entorno Disponibles

#### Servidor

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `MICROSERVICIO_C_PORT` | Puerto del microservicio | 8082 | No |

#### Base de Datos Oracle

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `MICROSERVICIO_C_ORACLE_HOST` | Host del servidor Oracle | localhost | No |
| `MICROSERVICIO_C_ORACLE_PORT` | Puerto del servidor Oracle | 1521 | No |
| `MICROSERVICIO_C_ORACLE_SID` | SID de Oracle (XE para Express) | XE | No |
| `MICROSERVICIO_C_ORACLE_USERNAME` | Usuario de la base de datos | microservicio_c | Sí |
| `MICROSERVICIO_C_ORACLE_PASSWORD` | Contraseña del usuario | oracle123 | Sí |

#### JPA/Hibernate

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `JPA_DDL_AUTO` | Estrategia DDL (update, validate, create) | update | No |
| `JPA_SHOW_SQL` | Mostrar SQL en logs (true/false) | true | No |
| `JPA_FORMAT_SQL` | Formatear SQL en logs (true/false) | true | No |

#### CORS

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `CORS_ALLOWED_ORIGINS` | Orígenes permitidos (separados por coma) | * | No |
| `CORS_ALLOWED_METHODS` | Métodos HTTP permitidos | GET,POST,PUT,DELETE,OPTIONS | No |
| `CORS_ALLOWED_HEADERS` | Headers permitidos | * | No |
| `CORS_MAX_AGE` | Tiempo máximo de caché preflight (segundos) | 3600 | No |

#### Integración con Microservicio A-B

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `MICROSERVICIO_AB_URL` | URL base del Microservicio A-B | http://localhost:8081 | Sí |
| `MICROSERVICIO_AB_TIMEOUT` | Timeout en milisegundos | 5000 | No |
| `MICROSERVICIO_AB_MAX_RETRIES` | Número máximo de reintentos | 3 | No |

#### WebClient

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `WEBCLIENT_TIMEOUT_MS` | Timeout general de WebClient (ms) | 5000 | No |

#### Logging

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `LOGGING_LEVEL_APP` | Nivel de log (DEBUG, INFO, WARN) | DEBUG | No |
| `LOGGING_LEVEL_WEB` | Nivel de log para Spring Web | INFO | No |
| `LOGGING_LEVEL_SQL` | Nivel de log para Hibernate SQL | DEBUG | No |

#### Actuator

| Variable | Descripción | Valor por Defecto | Requerida |
|----------|-------------|-------------------|-----------|
| `ACTUATOR_ENDPOINTS` | Endpoints expuestos (separados por coma) | health,info,metrics | No |
| `ACTUATOR_HEALTH_SHOW_DETAILS` | Mostrar detalles (always, when-authorized, never) | always | No |

### Configuración Directa (No Recomendado para Producción)

### Variables de Entorno (Recomendado)

Crear archivo `.env` en la raíz del proyecto:

```properties
# Puerto del microservicio
MICROSERVICIO_C_PORT=8082

# Configuración de Oracle
MICROSERVICIO_C_ORACLE_HOST=localhost
MICROSERVICIO_C_ORACLE_PORT=1521
MICROSERVICIO_C_ORACLE_SID=XE
MICROSERVICIO_C_ORACLE_USERNAME=microservicio_c
MICROSERVICIO_C_ORACLE_PASSWORD=oracle123

# URL del Microservicio A-B
MICROSERVICIO_AB_URL=http://localhost:8081

# CORS
CORS_ALLOWED_ORIGINS=http://localhost:3000,http://localhost:4200

# Timeout WebClient (ms)
WEBCLIENT_TIMEOUT_MS=5000
```

### Configuración Directa (application.properties)

Si no usas variables de entorno, editar `src/main/resources/application.properties`:

```properties
spring.datasource.url=jdbc:oracle:thin:@localhost:1521:XE
spring.datasource.username=microservicio_c
spring.datasource.password=oracle123
```

## Instalación y Ejecución

### 1. Compilar el Proyecto

```bash
cd MicroservicioC
mvn clean install
```

### 2. Ejecutar el Microservicio

**Opción A: Con Maven**
```bash
mvn spring-boot:run
```

**Opción B: Con JAR**
```bash
mvn clean package
java -jar target/microservicio-insumo-1.0.0.jar
```

**Opción C: Con variables de entorno**
```bash
# Windows (PowerShell)
$env:MICROSERVICIO_C_ORACLE_PASSWORD="oracle123"
mvn spring-boot:run

# Linux/Mac
export MICROSERVICIO_C_ORACLE_PASSWORD=oracle123
mvn spring-boot:run
```

### 3. Verificar Inicio

Deberías ver en la consola:

```
===========================================
MICROSERVICIO C - INSUMOS AGRÍCOLAS
Universidad de Ibagué
Puerto: 8082
Base de Datos: Oracle
API: http://localhost:8082/api/insumos
===========================================
```

### 4. Datos Iniciales

El microservicio carga automáticamente 5 insumos de ejemplo:
- INS001: Fertilizante NPK 15-15-15
- INS002: Semilla de Arroz Fedearroz 2000
- INS003: Pesticida Orgánico BioControl
- INS004: Tijeras de Poda Profesionales
- INS005: Abono Orgánico Compostado

## API REST - Endpoints

### Base URL
```
http://localhost:8082/api/insumos
```

### 1. Crear Insumo

**POST** `/api/insumos`

**Request Body:**
```json
{
  "productoId": "AGR001",
  "nombre": "Fertilizante NPK 15-15-15",
  "cantidad": 50,
  "costoUnitario": 45000.0,
  "fechaCompra": "2025-11-10T10:30:00",
  "proveedor": "Agroquímicos del Valle",
  "tipo": "FERTILIZANTE",
  "descripcion": "Fertilizante balanceado para café",
  "unidadMedida": "KG",
  "stockMinimo": 10,
  "ubicacionAlmacen": "Bodega A-12",
  "lote": "LOTE-2025-001"
}
```

**Response:** (201 Created)
```json
{
  "success": true,
  "message": "Insumo creado exitosamente",
  "data": {
    "id": "INS006",
    "productoId": "AGR001",
    "nombre": "Fertilizante NPK 15-15-15",
    "cantidad": 50,
    "costoUnitario": 45000.0,
    "costoTotal": 2250000.0,
    "tipo": "FERTILIZANTE",
    "stockBajo": false,
    "estaVencido": false
  },
  "timestamp": "2025-11-19T10:30:00"
}
```

### 2. Listar Todos los Insumos

**GET** `/api/insumos`

**Response:** (200 OK)
```json
{
  "success": true,
  "message": "Insumos obtenidos exitosamente",
  "data": [
    {
      "id": "INS001",
      "productoId": "AGR001",
      "nombre": "Fertilizante NPK 15-15-15",
      "costoTotal": 2250000.0
    }
  ],
  "timestamp": "2025-11-19T10:30:00"
}
```

### 3. Obtener Insumo por ID

**GET** `/api/insumos/{id}`

```bash
curl http://localhost:8082/api/insumos/INS001
```

### 4. Buscar por Tipo

**GET** `/api/insumos?tipo={tipo}`

Valores válidos: `FERTILIZANTE`, `SEMILLA`, `PESTICIDA`, `HERRAMIENTA`

```bash
curl http://localhost:8082/api/insumos?tipo=FERTILIZANTE
```

### 5. Buscar por Proveedor

**GET** `/api/insumos/proveedor/{proveedor}`

```bash
curl http://localhost:8082/api/insumos/proveedor/Agroquimicos%20del%20Valle
```

### 6. Obtener Insumos por Producto

**GET** `/api/insumos/producto/{productoId}`

```bash
curl http://localhost:8082/api/insumos/producto/AGR001
```

### 7. Buscar por Rango de Fechas

**GET** `/api/insumos/fecha-compra?inicio={inicio}&fin={fin}`

```bash
curl "http://localhost:8082/api/insumos/fecha-compra?inicio=2025-01-01T00:00:00&fin=2025-12-31T23:59:59"
```

### 8. Obtener Stock Bajo

**GET** `/api/insumos/stock-bajo`

Retorna insumos donde cantidad < stockMinimo

### 9. Obtener Vencidos

**GET** `/api/insumos/vencidos`

### 10. Obtener Próximos a Vencer

**GET** `/api/insumos/proximos-vencer`

Retorna insumos que vencen en los próximos 30 días

### 11. Calcular Costo Total por Producto

**GET** `/api/insumos/costo-total/{productoId}`

```json
{
  "success": true,
  "message": "Costo total calculado",
  "data": 5750000.0,
  "timestamp": "2025-11-19T10:30:00"
}
```

### 12. Actualizar Insumo

**PUT** `/api/insumos/{id}`

**Request Body:** Igual que crear

### 13. Eliminar Insumo

**DELETE** `/api/insumos/{id}`

### 14. Verificar Existencia de Producto (Integridad)

**GET** `/api/insumos/verificar-producto/{productoId}`

Consulta al Microservicio A-B para verificar que el producto existe

```json
{
  "success": true,
  "message": "Producto verificado",
  "data": {
    "entidad": "ProductoAgricola",
    "id": "AGR001",
    "existe": true,
    "nombre": "Café Arábico Premium"
  },
  "timestamp": "2025-11-19T10:30:00"
}
```

## Validaciones

### Validaciones Automáticas (Jakarta Validation)

- **productoId**: No vacío, formato AGR### (ej: AGR001)
- **nombre**: No vacío, máximo 200 caracteres
- **cantidad**: Mínimo 1
- **costoUnitario**: Mínimo 0.01
- **tipo**: Solo valores: FERTILIZANTE, SEMILLA, PESTICIDA, HERRAMIENTA
- **unidadMedida**: KG, LITROS, UNIDAD, GRAMOS, TONELADAS

### Validaciones de Negocio

- **Integridad Referencial**: Antes de crear un insumo, verifica que el productoId exista en Microservicio A-B
- **ID Único**: No permite duplicados
- **Cantidades**: No permite valores negativos
- **Fechas**: fechaVencimiento debe ser futura si se proporciona

## Manejo de Errores

Todos los errores retornan el formato estándar:

```json
{
  "success": false,
  "message": "El insumo con ID INS999 no existe",
  "data": null,
  "timestamp": "2025-11-19T10:30:00"
}
```

### Códigos HTTP

- **200 OK**: Operación exitosa
- **201 Created**: Recurso creado
- **400 Bad Request**: Validación fallida
- **404 Not Found**: Recurso no encontrado
- **409 Conflict**: Insumo ya existe
- **503 Service Unavailable**: Error comunicación con Microservicio A-B
- **500 Internal Server Error**: Error inesperado

## Integración con Microservicio A-B

El Microservicio C se comunica con el Microservicio A-B para:

1. **Verificar Existencia de Productos**: Antes de crear un insumo, valida que el productoId exista
2. **Consultar Información**: Obtiene datos del producto para enriquecer respuestas

### Requisito

El Microservicio A-B debe estar ejecutándose en `http://localhost:8081` y debe implementar el endpoint:

```
GET http://localhost:8081/api/productos/verificar/{productoId}
```

### Configuración de Timeout

Por defecto, las llamadas WebClient tienen timeout de 5 segundos. Se puede configurar:

```properties
webclient.timeout-ms=10000
```

## Pruebas con Postman

### 1. Importar Colección

Crear una nueva colección "Microservicio C - Insumos" con los siguientes requests:

### 2. Variables de Entorno

```json
{
  "base_url": "http://localhost:8082",
  "insumo_id": "INS001",
  "producto_id": "AGR001"
}
```

### 3. Casos de Prueba Recomendados

1. **Happy Path**: Crear insumo con todos los datos válidos
2. **Validación**: Intentar crear con productoId inválido
3. **Integridad**: Crear insumo con productoId que no existe
4. **Búsqueda**: Filtrar por tipo, proveedor, fechas
5. **Cálculos**: Verificar costoTotal calculado correctamente
6. **Actualización**: Modificar cantidad y costoUnitario
7. **Eliminación**: Borrar insumo y verificar 404 posterior

## Logs y Monitoreo

### Niveles de Log

```properties
# Configurar en application.properties
logging.level.co.unibague.agropecuario.insumos=DEBUG
logging.level.org.springframework.web=INFO
logging.level.org.hibernate.SQL=DEBUG
```

### Logs Importantes

```
INFO  - Verificando datos iniciales...
INFO  - Cargando datos iniciales de insumos...
INFO  - 5 insumos de ejemplo creados
DEBUG - Verificando existencia del producto: AGR001
ERROR - Insumo no encontrado: INS999
ERROR - Error al comunicarse con Microservicio A-B: Connection refused
```

## Troubleshooting

### Error: "Table or view does not exist"

**Solución**: Verificar que Hibernate creó las tablas:

```sql
-- Conectar a Oracle
sqlplus microservicio_c/oracle123@localhost:1521/XE

-- Verificar tablas
SELECT table_name FROM user_tables;

-- Debería mostrar: INSUMO, INSUMO_SEQ
```

### Error: "Connection refused" al iniciar

**Solución**: Verificar que Oracle Database está corriendo:

```bash
# Verificar servicio Oracle (Windows)
services.msc

# Verificar Docker container (Linux/Mac)
docker ps | grep oracle-xe
```

### Error: "ORA-01017: invalid username/password"

**Solución**: Resetear password del usuario:

```sql
CONNECT sys/password AS SYSDBA;
ALTER USER microservicio_c IDENTIFIED BY oracle123;
```

### Error: "Microservicio A-B no disponible"

**Solución**:
1. Verificar que Microservicio A-B está corriendo en puerto 8081
2. Probar manualmente: `curl http://localhost:8081/api/productos`
3. Revisar configuración `app.microservicio-ab.base-url` en properties

### Error: "Port 8082 already in use"

**Solución**: Cambiar puerto en application.properties:

```properties
server.port=8083
```

O terminar el proceso que usa el puerto 8082.

## Estructura del Proyecto

```
MicroservicioC/
├── src/
│   ├── main/
│   │   ├── java/co/unibague/agropecuario/insumos/
│   │   │   ├── config/
│   │   │   │   ├── DataLoader.java
│   │   │   │   ├── WebClientConfig.java
│   │   │   │   └── WebConfig.java
│   │   │   ├── controller/
│   │   │   │   ├── GlobalExceptionHandler.java
│   │   │   │   └── InsumoController.java
│   │   │   ├── dto/
│   │   │   │   ├── request/
│   │   │   │   │   ├── InsumoRequestDTO.java
│   │   │   │   │   └── IntegridadRequestDTO.java
│   │   │   │   └── response/
│   │   │   │       ├── ApiResponseDTO.java
│   │   │   │       ├── ErrorResponseDTO.java
│   │   │   │       ├── InsumoResponseDTO.java
│   │   │   │       └── IntegridadResponseDTO.java
│   │   │   ├── exception/
│   │   │   │   ├── InsumoAlreadyExistsException.java
│   │   │   │   ├── InsumoNotFoundException.java
│   │   │   │   ├── MicroserviceClientException.java
│   │   │   │   └── ValidationException.java
│   │   │   ├── model/
│   │   │   │   └── Insumo.java
│   │   │   ├── repository/
│   │   │   │   └── InsumoJpaRepository.java
│   │   │   ├── service/
│   │   │   │   ├── IdGeneratorService.java
│   │   │   │   ├── InsumoService.java
│   │   │   │   └── InsumoServiceImpl.java
│   │   │   ├── utils/
│   │   │   │   ├── Constantes.java
│   │   │   │   ├── InsumoMapper.java
│   │   │   │   ├── ResponseBuilder.java
│   │   │   │   └── Validador.java
│   │   │   └── MicroservicioInsumoApplication.java
│   │   └── resources/
│   │       └── application.properties
│   └── test/
│       └── java/ (tests pendientes - Etapa 7)
├── pom.xml
└── README.md
```

## Dependencias Principales

- **Spring Boot Starter Data JPA**: 3.2.0
- **Spring Boot Starter Web**: 3.2.0
- **Spring Boot Starter WebFlux**: 3.2.0 (WebClient)
- **Spring Boot Starter Validation**: 3.2.0
- **Oracle JDBC Driver**: ojdbc11
- **Lombok**: 1.18.30 (opcional)
- **Spring Boot DevTools**: Para desarrollo

## Próximos Pasos (Siguientes Etapas)

- **Etapa 2**: Integrar endpoints de integridad en Microservicio A-B
- **Etapa 3**: Implementar health checks (local, DB, remoto)
- **Etapa 4**: Agregar validaciones bidireccionales de integridad
- **Etapa 5**: Externalizar todas las configuraciones a variables de entorno
- **Etapa 6**: Actualizar clientes (C# Windows Forms y Web)
- **Etapa 7**: Testing completo (unitario, integración, Postman)
- **Etapa 8**: Documentación final y video demostrativo

## Autor

Universidad de Ibagué
Desarrollo de Aplicaciones Empresariales
Tercer Proyecto 2025B

## Licencia

Proyecto académico - Universidad de Ibagué
