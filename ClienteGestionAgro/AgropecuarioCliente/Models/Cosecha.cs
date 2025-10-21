using System;

namespace AgropecuarioCliente.Models
{
    public class Cosecha
    {
        public string Id { get; set; }
        public string ProductoId { get; set; }
        public DateTime FechaCosecha { get; set; }
        public int CantidadRecolectada { get; set; }
        public string CalidadProducto { get; set; }
        public int NumeroTrabajadores { get; set; }
        public double CostoManoObra { get; set; }
        public string CondicionesClimaticas { get; set; }
        public string EstadoCosecha { get; set; }
        public string Observaciones { get; set; }

        // Métodos de cálculo
        public double CalcularCostoPorKg()
        {
            if (CantidadRecolectada > 0)
                return CostoManoObra / CantidadRecolectada;
            return 0;
        }

        public double CalcularCostoPorTrabajador()
        {
            if (NumeroTrabajadores > 0)
                return CostoManoObra / NumeroTrabajadores;
            return 0;
        }

        public double CalcularRendimiento()
        {
            if (NumeroTrabajadores > 0)
                return (double)CantidadRecolectada / NumeroTrabajadores;
            return 0;
        }
    }
}