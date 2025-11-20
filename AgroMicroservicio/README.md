# Microservicio A-B - Gestión de Productos Agrícolas y Cosechas

Universidad de Ibagué - Desarrollo de Aplicaciones Empresariales
Tercer Proyecto 2025B

## Descripción

Microservicio para la gestión de productos agrícolas (maestro) y cosechas (detalle). Implementa una relación maestro-detalle con operaciones CRUD completas, validaciones de negocio, y comunicación con Microservicio C (Insumos).

## Características Principales

- **Base de Datos**: MySQL
- **Puerto**: 8081
- **Arquitectura**: Spring Boot 3.2.0 + JPA/Hibernate
- **Comunicación**: WebClient (Spring WebFlux) para integración con Microservicio C
- **Validación**: Jakarta Validation con reglas de negocio personalizadas
- **Health Checks**: Spring Boot Actuator con indicadores personalizados

## Configuración con Variables de Entorno

### Paso 1: Copiar archivo de ejemplo

```bash
cp .env.example .env
```

### Paso 2: Editar valores en .env

Ver sección "Variables de Entorno Disponibles" más abajo.

### Paso 3: Cargar variables

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

## Variables de Entorno Principales

| Variable | Descripción | Valor por Defecto |
|----------|-------------|-------------------|
| `SERVER_PORT` | Puerto del microservicio | 8081 |
| `MYSQL_HOST` | Host de MySQL | localhost |
| `MYSQL_PORT` | Puerto de MySQL | 3306 |
| `MYSQL_DATABASE` | Nombre de la BD | agropecuario_db |
| `MYSQL_USER` | Usuario de la BD | agropecuario_user |
| `MYSQL_PASSWORD` | Contraseña | agropecuario_password |
| `MICROSERVICIO_C_URL` | URL Microservicio C | http://localhost:8082 |

Ver .env.example para la lista completa de variables.

## Instalación Rápida

```bash
# 1. Configurar variables de entorno
cp .env.example .env
# Editar .env con tus valores

# 2. Compilar
mvn clean install

# 3. Ejecutar
mvn spring-boot:run
```

## Verificar Instalación

```bash
# Health check
curl http://localhost:8081/actuator/health

# Listar productos
curl http://localhost:8081/api/productos
```

## Documentación Completa

Ver archivo completo en el repositorio para:
- API REST endpoints
- Ejemplos de uso
- Troubleshooting
- Configuración avanzada
- Integración con Microservicio C

