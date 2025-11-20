package co.unibague.agropecuario.insumos.utils;

import co.unibague.agropecuario.insumos.dto.request.InsumoRequestDTO;
import co.unibague.agropecuario.insumos.dto.response.InsumoResponseDTO;
import co.unibague.agropecuario.insumos.model.Insumo;

import java.util.List;
import java.util.stream.Collectors;

/**
 * Mapper para conversión entre entidad Insumo y DTOs
 * Universidad de Ibagué - Microservicio C
 */
public class InsumoMapper {

    /**
     * Convierte una entidad Insumo a InsumoResponseDTO
     */
    public static InsumoResponseDTO toResponseDTO(Insumo entity) {
        if (entity == null) {
            return null;
        }

        return InsumoResponseDTO.builder()
                .id(entity.getId())
                .productoId(entity.getProductoId())
                .nombre(entity.getNombre())
                .cantidad(entity.getCantidad())
                .costoUnitario(entity.getCostoUnitario())
                .fechaCompra(entity.getFechaCompra())
                .proveedor(entity.getProveedor())
                .tipo(entity.getTipo())
                .descripcion(entity.getDescripcion())
                .unidadMedida(entity.getUnidadMedida())
                .fechaVencimiento(entity.getFechaVencimiento())
                .lote(entity.getLote())
                .activo(entity.getActivo())
                // Campos calculados
                .costoTotal(entity.calcularCostoTotal())
                .estaVencido(entity.estaVencido())
                .proximoAVencer(entity.estaProximoAVencer())
                .stockBajo(entity.esStockBajo())
                .build();
    }

    /**
     * Convierte un InsumoRequestDTO a entidad Insumo
     */
    public static Insumo toEntity(InsumoRequestDTO dto) {
        if (dto == null) {
            return null;
        }

        Insumo entity = new Insumo();
        entity.setProductoId(dto.getProductoId());
        entity.setNombre(dto.getNombre());
        entity.setCantidad(dto.getCantidad());
        entity.setCostoUnitario(dto.getCostoUnitario());
        entity.setFechaCompra(dto.getFechaCompra() != null ? dto.getFechaCompra() : java.time.LocalDateTime.now());
        entity.setProveedor(dto.getProveedor());
        entity.setTipo(dto.getTipo());
        entity.setDescripcion(dto.getDescripcion());
        entity.setUnidadMedida(dto.getUnidadMedida() != null ? dto.getUnidadMedida() : "UNIDAD");
        entity.setFechaVencimiento(dto.getFechaVencimiento());
        entity.setLote(dto.getLote());
        entity.setActivo(dto.getActivo() != null ? dto.getActivo() : true);
        return entity;
    }

    /**
     * Actualiza una entidad existente con datos del DTO
     */
    public static void updateEntityFromDTO(Insumo entity, InsumoRequestDTO dto) {
        if (entity == null || dto == null) {
            return;
        }

        if (dto.getProductoId() != null) {
            entity.setProductoId(dto.getProductoId());
        }
        if (dto.getNombre() != null) {
            entity.setNombre(dto.getNombre());
        }
        if (dto.getCantidad() != null) {
            entity.setCantidad(dto.getCantidad());
        }
        if (dto.getCostoUnitario() != null) {
            entity.setCostoUnitario(dto.getCostoUnitario());
        }
        if (dto.getFechaCompra() != null) {
            entity.setFechaCompra(dto.getFechaCompra());
        }
        if (dto.getProveedor() != null) {
            entity.setProveedor(dto.getProveedor());
        }
        if (dto.getTipo() != null) {
            entity.setTipo(dto.getTipo());
        }
        if (dto.getDescripcion() != null) {
            entity.setDescripcion(dto.getDescripcion());
        }
        if (dto.getUnidadMedida() != null) {
            entity.setUnidadMedida(dto.getUnidadMedida());
        }
        if (dto.getFechaVencimiento() != null) {
            entity.setFechaVencimiento(dto.getFechaVencimiento());
        }
        if (dto.getLote() != null) {
            entity.setLote(dto.getLote());
        }
        if (dto.getActivo() != null) {
            entity.setActivo(dto.getActivo());
        }
    }

    /**
     * Convierte una lista de entidades a lista de DTOs
     */
    public static List<InsumoResponseDTO> toResponseDTOList(List<Insumo> entities) {
        if (entities == null) {
            return List.of();
        }

        return entities.stream()
                .map(InsumoMapper::toResponseDTO)
                .collect(Collectors.toList());
    }

    // Constructor privado
    private InsumoMapper() {
        throw new IllegalStateException("Clase utilitaria - no instanciable");
    }
}
