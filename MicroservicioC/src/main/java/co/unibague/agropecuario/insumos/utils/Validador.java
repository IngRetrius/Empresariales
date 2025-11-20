package co.unibague.agropecuario.insumos.utils;

import co.unibague.agropecuario.insumos.exception.ValidationException;

/**
 * Validador centralizado para reglas de negocio
 * Universidad de Ibagué - Microservicio C
 */
public class Validador {

    /**
     * Valida que el ID del producto no esté vacío y tenga el formato correcto
     */
    public static void validarProductoId(String productoId) {
        if (productoId == null || productoId.trim().isEmpty()) {
            throw new ValidationException(Constantes.ERROR_VALIDACION_PRODUCTO_ID);
        }
        if (!productoId.matches("^AGR\\d{3}$")) {
            throw new ValidationException("El ID del producto debe tener formato AGR001");
        }
    }

    /**
     * Valida que la cantidad sea válida
     */
    public static void validarCantidad(Integer cantidad) {
        if (cantidad == null) {
            throw new ValidationException("La cantidad es obligatoria");
        }
        if (cantidad < Constantes.CANTIDAD_MIN) {
            throw new ValidationException(Constantes.ERROR_VALIDACION_CANTIDAD);
        }
        if (cantidad > Constantes.CANTIDAD_MAX) {
            throw new ValidationException("La cantidad no puede exceder " + Constantes.CANTIDAD_MAX);
        }
    }

    /**
     * Valida que el costo unitario sea válido
     */
    public static void validarCostoUnitario(Double costo) {
        if (costo == null) {
            throw new ValidationException("El costo unitario es obligatorio");
        }
        if (costo < Constantes.COSTO_MIN) {
            throw new ValidationException(Constantes.ERROR_VALIDACION_COSTO);
        }
        if (costo > Constantes.COSTO_MAX) {
            throw new ValidationException("El costo no puede exceder $" + Constantes.COSTO_MAX);
        }
    }

    /**
     * Valida que el tipo de insumo sea válido
     */
    public static void validarTipoInsumo(String tipo) {
        if (tipo == null || tipo.trim().isEmpty()) {
            throw new ValidationException("El tipo de insumo es obligatorio");
        }

        if (!tipo.equals(Constantes.TIPO_FERTILIZANTE) &&
            !tipo.equals(Constantes.TIPO_SEMILLA) &&
            !tipo.equals(Constantes.TIPO_PESTICIDA) &&
            !tipo.equals(Constantes.TIPO_HERRAMIENTA)) {
            throw new ValidationException(
                "El tipo debe ser: FERTILIZANTE, SEMILLA, PESTICIDA o HERRAMIENTA"
            );
        }
    }

    /**
     * Valida que el nombre no esté vacío
     */
    public static void validarNombre(String nombre) {
        if (nombre == null || nombre.trim().isEmpty()) {
            throw new ValidationException("El nombre del insumo es obligatorio");
        }
        if (nombre.length() < 2 || nombre.length() > 100) {
            throw new ValidationException("El nombre debe tener entre 2 y 100 caracteres");
        }
    }

    /**
     * Valida que el proveedor no esté vacío
     */
    public static void validarProveedor(String proveedor) {
        if (proveedor == null || proveedor.trim().isEmpty()) {
            throw new ValidationException("El proveedor es obligatorio");
        }
        if (proveedor.length() < 2 || proveedor.length() > 100) {
            throw new ValidationException("El proveedor debe tener entre 2 y 100 caracteres");
        }
    }

    /**
     * Valida que el ID del insumo no esté vacío
     */
    public static void validarInsumoId(String id) {
        if (id == null || id.trim().isEmpty()) {
            throw new ValidationException("El ID del insumo es obligatorio");
        }
        if (!id.matches("^INS\\d{3}$")) {
            throw new ValidationException("El ID del insumo debe tener formato INS001");
        }
    }

    // Constructor privado
    private Validador() {
        throw new IllegalStateException("Clase utilitaria - no instanciable");
    }
}
