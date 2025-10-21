using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormEliminarCosecha : Form
    {
        private readonly ApiService _apiService;
        private string _cosechaId;

        public FormEliminarCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        public void SetCosechaId(string id)
        {
            _cosechaId = id;
        }

        private void FormEliminarCosecha_Load(object sender, EventArgs e)
        {
            // Inicializar estados de controles
            try
            {
                btnEliminar.Enabled = false;
                lblIdValor.Text = "--";
                lblProductoValor.Text = "--";
                lblFechaValor.Text = "--";
                lblCantidadValor.Text = "--";
                lblCalidadValor.Text = "--";
                lblTrabajadoresValor.Text = "--";
                lblCostoValor.Text = "--";
                lblCondicionesValor.Text = "--";
                lblEstadoValor.Text = "--";
                lblObservacionesValor.Text = "--";
                lblCostoPorKgValor.Text = "--";
                lblRendimientoValor.Text = "--";
            }
            catch
            {
                // Ignorar en inicialización
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_cosechaId))
            {
                MessageHelper.ShowWarning("No hay cosecha seleccionada.");
                return;
            }

            try
            {
                bool ok = await _apiService.EliminarCosechaAsync(_cosechaId);
                if (ok)
                {
                    MessageHelper.ShowSuccess("Cosecha eliminada correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageHelper.ShowError("No se pudo eliminar la cosecha.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al eliminar cosecha:");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var formSelector = new FormSelectorCosecha();
                if (formSelector.ShowDialog() == DialogResult.OK)
                {
                    var cosecha = formSelector.CosechaSeleccionada;
                    if (cosecha != null)
                    {
                        _cosechaId = cosecha.Id;

                        lblIdValor.Text = cosecha.Id;
                        lblProductoValor.Text = cosecha.ProductoId;
                        lblFechaValor.Text = cosecha.FechaCosecha.ToString("dd/MM/yyyy HH:mm");
                        lblCantidadValor.Text = cosecha.CantidadRecolectada.ToString("N0");
                        lblCalidadValor.Text = cosecha.CalidadProducto ?? "--";
                        lblTrabajadoresValor.Text = cosecha.NumeroTrabajadores.ToString();
                        lblCostoValor.Text = $"${cosecha.CostoManoObra:N2}";
                        lblCondicionesValor.Text = cosecha.CondicionesClimaticas ?? "--";
                        lblEstadoValor.Text = cosecha.EstadoCosecha ?? "--";
                        lblObservacionesValor.Text = string.IsNullOrEmpty(cosecha.Observaciones) ? "Sin observaciones" : cosecha.Observaciones;

                        // Cálculos
                        try
                        {
                            lblCostoPorKgValor.Text = $"${cosecha.CalcularCostoPorKg():N2}";
                        }
                        catch
                        {
                            lblCostoPorKgValor.Text = "--";
                        }

                        try
                        {
                            lblRendimientoValor.Text = $"{cosecha.CalcularRendimiento():N2}";
                        }
                        catch
                        {
                            lblRendimientoValor.Text = "--";
                        }

                        btnEliminar.Enabled = true;
                    }
                }
                formSelector.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al buscar cosecha:");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar formulario (botón Cerrar en el diseñador)
            this.Close();
        }
    }
}
