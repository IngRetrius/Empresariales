using System;
using Newtonsoft.Json;

namespace AgropecuarioCliente.Models
{
    public class ProductoAgricola
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("hectareasCultivadas")]
        public double HectareasCultivadas { get; set; }

        [JsonProperty("cantidadProducida")]
        public int CantidadProducida { get; set; }

        [JsonProperty("fechaProduccion")]
        public DateTime FechaProduccion { get; set; }

        [JsonProperty("tipoCultivo")]
        public string TipoCultivo { get; set; }

        [JsonProperty("precioVenta")]
        public double PrecioVenta { get; set; }

        [JsonProperty("costoProduccion")]
        public double CostoProduccion { get; set; }

        [JsonProperty("rendimientoPorHa")]
        public double? RendimientoPorHa { get; set; }

        [JsonProperty("temporada")]
        public string Temporada { get; set; } = "Todo el año";

        [JsonProperty("tipoSuelo")]
        public string TipoSuelo { get; set; } = "Franco";

        [JsonProperty("codigoFinca")]
        public string CodigoFinca { get; set; }

        public ProductoAgricola()
        {
            FechaProduccion = DateTime.Now;
        }

        public double CalcularIngresoTotal()
        {
            return CantidadProducida * PrecioVenta;
        }

        public double CalcularRentabilidad()
        {
            if (HectareasCultivadas == 0) return 0;
            double ingresoTotal = CalcularIngresoTotal();
            double costoTotal = CostoProduccion * HectareasCultivadas;
            double utilidadNeta = ingresoTotal - costoTotal;
            return utilidadNeta / HectareasCultivadas;
        }

        public double CalcularMargenGanancia()
        {
            if (CostoProduccion == 0) return 0;
            return ((PrecioVenta - CostoProduccion) / CostoProduccion) * 100;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} ({TipoCultivo})";
        }

        // Métodos de validación
        public static class Validations
        {
            public static bool ValidarNombre(string nombre, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    error = "El nombre es obligatorio";
                    return false;
                }
                if (nombre.Trim().Length < 2)
                {
                    error = "El nombre debe tener al menos 2 caracteres";
                    return false;
                }
                return true;
            }

            public static bool ValidarHectareas(double hectareas, out string error)
            {
                error = "";
                if (hectareas < 0.1 || hectareas > 10000)
                {
                    error = "Las hectáreas deben estar entre 0.1 y 10,000";
                    return false;
                }
                return true;
            }

            public static bool ValidarCantidad(int cantidad, out string error)
            {
                error = "";
                if (cantidad < 1)
                {
                    error = "La cantidad debe ser mayor a 0";
                    return false;
                }
                return true;
            }

            public static bool ValidarPrecio(double precio, out string error)
            {
                error = "";
                if (precio < 100 || precio > 1000000)
                {
                    error = "El precio debe estar entre $100 y $1,000,000";
                    return false;
                }
                return true;
            }

            public static bool ValidarCosto(double costo, out string error)
            {
                error = "";
                if (costo < 100)
                {
                    error = "El costo debe ser mayor a $100";
                    return false;
                }
                return true;
            }

            public static bool ValidarTipoCultivo(string tipoCultivo, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(tipoCultivo))
                {
                    error = "El tipo de cultivo es obligatorio";
                    return false;
                }
                return true;
            }
        }
    }
}