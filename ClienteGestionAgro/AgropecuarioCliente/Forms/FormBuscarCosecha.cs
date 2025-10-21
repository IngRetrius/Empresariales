using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormBuscarCosecha : Form
    {
        private readonly ApiService _apiService;
        private List<Cosecha> _resultados;

        public FormBuscarCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _resultados = new List<Cosecha>();
        }

        private void FormBuscarCosecha_Load(object sender, EventArgs e)
        {
            LimpiarCamposResultado();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnBuscar.Enabled = false;

                var term = txtBusqueda.Text.Trim();

                if (string.IsNullOrEmpty(term))
                {
                    MessageHelper.ShowWarning("Debe ingresar un ID de cosecha o producto para buscar.");
                    return;
                }

                // Intentar buscar por ID de cosecha primero
                var byId = await _apiService.ObtenerCosechaPorIdAsync(term);
                if (byId != null)
                {
                    _resultados = new List<Cosecha> { byId };
                }
                else
                {
                    // Buscar por ID de producto
                    var porProducto = await _apiService.ObtenerCosechasPorProductoAsync(term);
                    _resultados = porProducto ?? new List<Cosecha>();
                }

                ActualizarResultados();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al buscar cosechas:");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnBuscar.Enabled = true;
            }
        }

        private void ActualizarResultados()
        {
            if (_resultados.Count == 0)
            {
                LimpiarCamposResultado();
                lblResultados.Text = "No se encontraron resultados.";
                lblResultados.ForeColor = System.Drawing.Color.Red;
                MessageHelper.ShowInfo("No se encontraron cosechas que coincidan con el criterio de búsqueda.");
                return;
            }

            // Mostrar el primer resultado en los campos
            var cosecha = _resultados[0];

            txtResultadoId.Text = cosecha.Id ?? "";
            txtResultadoProductoId.Text = cosecha.ProductoId ?? "";
            txtResultadoFecha.Text = cosecha.FechaCosecha.ToString("dd/MM/yyyy");
            txtResultadoCantidad.Text = cosecha.CantidadRecolectada.ToString("N0") + " kg";
            txtResultadoCalidad.Text = cosecha.CalidadProducto ?? "";
            txtResultadoTrabajadores.Text = cosecha.NumeroTrabajadores.ToString();
            txtResultadoCosto.Text = cosecha.CostoManoObra.ToString("C0");
            txtResultadoCondiciones.Text = cosecha.CondicionesClimaticas ?? "";
            txtResultadoEstado.Text = cosecha.EstadoCosecha ?? "";
            txtResultadoObservaciones.Text = cosecha.Observaciones ?? "";

            if (_resultados.Count == 1)
            {
                lblResultados.Text = "Se encontró 1 cosecha.";
                lblResultados.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResultados.Text = $"Se encontraron {_resultados.Count} cosechas. Mostrando la primera.";
                lblResultados.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void LimpiarCamposResultado()
        {
            txtResultadoId.Clear();
            txtResultadoProductoId.Clear();
            txtResultadoFecha.Clear();
            txtResultadoCantidad.Clear();
            txtResultadoCalidad.Clear();
            txtResultadoTrabajadores.Clear();
            txtResultadoCosto.Clear();
            txtResultadoCondiciones.Clear();
            txtResultadoEstado.Clear();
            txtResultadoObservaciones.Clear();
            lblResultados.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            _resultados.Clear();
            LimpiarCamposResultado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
