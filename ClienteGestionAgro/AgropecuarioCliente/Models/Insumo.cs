using System;
using Newtonsoft.Json;

namespace AgropecuarioCliente.Models
{
    public class Insumo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("productoId")]
        public string ProductoId { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("cantidad")]
        public int Cantidad { get; set; }

        [JsonProperty("costoUnitario")]
        public double CostoUnitario { get; set; }

        [JsonProperty("costoTotal")]
        public double CostoTotal { get; set; }

        [JsonProperty("fechaCompra")]
        public DateTime FechaCompra { get; set; }

        [JsonProperty("proveedor")]
        public string Proveedor { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("unidadMedida")]
        public string UnidadMedida { get; set; }

        [JsonProperty("stockMinimo")]
        public int? StockMinimo { get; set; }

        [JsonProperty("ubicacionAlmacen")]
        public string UbicacionAlmacen { get; set; }

        [JsonProperty("fechaVencimiento")]
        public DateTime? FechaVencimiento { get; set; }

        [JsonProperty("lote")]
        public string Lote { get; set; }

        // Propiedades calculadas (solo lectura desde API)
        [JsonProperty("estaVencido")]
        public bool EstaVencido { get; set; }

        [JsonProperty("stockBajo")]
        public bool StockBajo { get; set; }

        public Insumo()
        {
            FechaCompra = DateTime.Now;
            UnidadMedida = "Kilogramos";
            Tipo = "FERTILIZANTE";
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} ({FormatearTipo(Tipo)})";
        }

        /// <summary>
        /// Formatea el tipo de insumo para mostrarlo de manera legible
        /// </summary>
        public static string FormatearTipo(string tipo)
        {
            if (string.IsNullOrEmpty(tipo))
                return "N/A";

            return tipo.Replace("_", " ")
                      .ToLower()
                      .Replace("fertilizante", "Fertilizante")
                      .Replace("semilla", "Semilla")
                      .Replace("pesticida", "Pesticida")
                      .Replace("herramienta", "Herramienta")
                      .Replace("herbicida", "Herbicida")
                      .Replace("fungicida", "Fungicida")
                      .Replace("abono organico", "Abono Orgánico")
                      .Replace("riego", "Riego");
        }

        /// <summary>
        /// Validaciones de negocio para Insumo
        /// </summary>
        public static class Validations
        {
            public static bool ValidarNombre(string nombre, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    error = "El nombre del insumo es obligatorio";
                    return false;
                }
                if (nombre.Trim().Length < 3)
                {
                    error = "El nombre debe tener al menos 3 caracteres";
                    return false;
                }
                return true;
            }

            public static bool ValidarProductoId(string productoId, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(productoId))
                {
                    error = "Debe seleccionar un producto asociado";
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
                if (cantidad > 1000000)
                {
                    error = "La cantidad no puede ser mayor a 1,000,000";
                    return false;
                }
                return true;
            }

            public static bool ValidarCostoUnitario(double costoUnitario, out string error)
            {
                error = "";
                if (costoUnitario < 1)
                {
                    error = "El costo unitario debe ser mayor a $0";
                    return false;
                }
                if (costoUnitario > 10000000)
                {
                    error = "El costo unitario no puede ser mayor a $10,000,000";
                    return false;
                }
                return true;
            }

            public static bool ValidarProveedor(string proveedor, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(proveedor))
                {
                    error = "El proveedor es obligatorio";
                    return false;
                }
                if (proveedor.Trim().Length < 2)
                {
                    error = "El nombre del proveedor debe tener al menos 2 caracteres";
                    return false;
                }
                return true;
            }

            public static bool ValidarTipo(string tipo, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(tipo))
                {
                    error = "El tipo de insumo es obligatorio";
                    return false;
                }
                return true;
            }

            public static bool ValidarUnidadMedida(string unidadMedida, out string error)
            {
                error = "";
                if (string.IsNullOrWhiteSpace(unidadMedida))
                {
                    error = "La unidad de medida es obligatoria";
                    return false;
                }
                return true;
            }

            public static bool ValidarFechaCompra(DateTime fechaCompra, out string error)
            {
                error = "";
                if (fechaCompra > DateTime.Now.AddDays(1))
                {
                    error = "La fecha de compra no puede ser futura";
                    return false;
                }
                if (fechaCompra < new DateTime(2000, 1, 1))
                {
                    error = "La fecha de compra no es válida";
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Enumeración de tipos de insumo
        /// </summary>
        public static class TiposInsumo
        {
            public const string FERTILIZANTE = "FERTILIZANTE";
            public const string SEMILLA = "SEMILLA";
            public const string PESTICIDA = "PESTICIDA";
            public const string HERRAMIENTA = "HERRAMIENTA";
            public const string HERBICIDA = "HERBICIDA";
            public const string FUNGICIDA = "FUNGICIDA";
            public const string ABONO_ORGANICO = "ABONO_ORGANICO";
            public const string RIEGO = "RIEGO";

            public static string[] ObtenerTodos()
            {
                return new string[]
                {
                    FERTILIZANTE,
                    SEMILLA,
                    PESTICIDA,
                    HERRAMIENTA,
                    HERBICIDA,
                    FUNGICIDA,
                    ABONO_ORGANICO,
                    RIEGO
                };
            }

            public static string[] ObtenerTodosFormateados()
            {
                return new string[]
                {
                    FormatearTipo(FERTILIZANTE),
                    FormatearTipo(SEMILLA),
                    FormatearTipo(PESTICIDA),
                    FormatearTipo(HERRAMIENTA),
                    FormatearTipo(HERBICIDA),
                    FormatearTipo(FUNGICIDA),
                    FormatearTipo(ABONO_ORGANICO),
                    FormatearTipo(RIEGO)
                };
            }
        }

        /// <summary>
        /// Enumeración de unidades de medida
        /// </summary>
        public static class UnidadesMedida
        {
            public const string KILOGRAMOS = "Kilogramos";
            public const string LITROS = "Litros";
            public const string UNIDADES = "Unidades";
            public const string TONELADAS = "Toneladas";
            public const string BULTOS = "Bultos";
            public const string GALONES = "Galones";

            public static string[] ObtenerTodas()
            {
                return new string[]
                {
                    KILOGRAMOS,
                    LITROS,
                    UNIDADES,
                    TONELADAS,
                    BULTOS,
                    GALONES
                };
            }
        }
    }
}
