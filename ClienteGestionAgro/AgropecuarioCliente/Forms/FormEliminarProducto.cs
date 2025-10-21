using System;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormEliminarProducto : Form
    {
        private readonly ApiService _apiService;
        private ProductoAgricola _productoSeleccionado;

        public FormEliminarProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productoSeleccionado = null;
        }

        private void FormEliminarProducto_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            btnEliminar.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            _productoSeleccionado = null;

            lblIdValor.Text = "--";
            lblNombreValor.Text = "--";
            lblTipoCultivoValor.Text = "--";
            lblHectareasValor.Text = "--";
            lblCantidadValor.Text = "--";
            lblPrecioValor.Text = "--";
            lblCostoValor.Text = "--";
            lblTemporadaValor.Text = "--";
            lblTipoSueloValor.Text = "--";
            lblCodigoFincaValor.Text = "--";
            lblFechaProduccionValor.Text = "--";
            lblIngresoTotalValor.Text = "--";
            lblRendimientoValor.Text = "--";

            groupBoxDatos.ForeColor = System.Drawing.Color.Gray;
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var formSelector = new FormSelectorProducto();
                if (formSelector.ShowDialog() == DialogResult.OK)
                {
                    _productoSeleccionado = formSelector.ProductoSeleccionado;
                    if (_productoSeleccionado != null)
                    {
                        CargarDatosProducto(_productoSeleccionado);
                        btnEliminar.Enabled = true;
                    }
                }
                formSelector.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al buscar producto:\n{ex.Message}");
            }
        }

        private void CargarDatosProducto(ProductoAgricola producto)
        {
            lblIdValor.Text = producto.Id;
            lblNombreValor.Text = producto.Nombre;
            lblTipoCultivoValor.Text = producto.TipoCultivo;
            lblHectareasValor.Text = $"{producto.HectareasCultivadas:N2} ha";
            lblCantidadValor.Text = $"{producto.CantidadProducida:N0} unidades";
            lblPrecioValor.Text = $"${producto.PrecioVenta:N2}";
            lblCostoValor.Text = $"${producto.CostoProduccion:N2}";
            lblTemporadaValor.Text = producto.Temporada ?? "No especificada";
            lblTipoSueloValor.Text = producto.TipoSuelo ?? "No especificado";
            lblCodigoFincaValor.Text = producto.CodigoFinca ?? "No especificado";
            lblFechaProduccionValor.Text = producto.FechaProduccion.ToString("dd/MM/yyyy");

            // Cálculos adicionales
            double ingresoTotal = producto.CalcularIngresoTotal();
            lblIngresoTotalValor.Text = $"${ingresoTotal:N2}";

            if (producto.HectareasCultivadas > 0)
            {
                double rendimiento = producto.CantidadProducida / producto.HectareasCultivadas;
                lblRendimientoValor.Text = $"{rendimiento:N2} unidades/ha";
            }
            else
            {
                lblRendimientoValor.Text = "N/A";
            }

            groupBoxDatos.ForeColor = System.Drawing.Color.DarkRed;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageHelper.ShowWarning("No hay ningún producto seleccionado para eliminar.");
                return;
            }

            // Confirmación múltiple para operación crítica
            string mensaje = $"¡ATENCIÓN! Está a punto de eliminar el siguiente producto:\n\n" +
                           $"ID: {_productoSeleccionado.Id}\n" +
                           $"Nombre: {_productoSeleccionado.Nombre}\n" +
                           $"Tipo: {_productoSeleccionado.TipoCultivo}\n" +
                           $"Hectáreas: {_productoSeleccionado.HectareasCultivadas:N2}\n\n" +
                           $"Esta acción NO se puede deshacer.\n" +
                           $"¿Está COMPLETAMENTE SEGURO que desea eliminar este producto?";

            var resultado = MessageBox.Show(mensaje, "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (resultado != DialogResult.Yes)
                return;

            // Segunda confirmación
            var segundaConfirmacion = MessageBox.Show(
                "¿Está ABSOLUTAMENTE SEGURO?\n\nEsta es su última oportunidad para cancelar.\nEl producto será eliminado permanentemente.",
                "Última Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

            if (segundaConfirmacion != DialogResult.Yes)
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;

                bool eliminado = await _apiService.EliminarAsync(_productoSeleccionado.Id);

                if (eliminado)
                {
                    MessageHelper.ShowSuccess($"El producto '{_productoSeleccionado.Nombre}' ha sido eliminado exitosamente.");
                    LimpiarFormulario();
                }
                else
                {
                    MessageHelper.ShowError("No se pudo eliminar el producto. Verifique la conexión con el servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al eliminar el producto:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnEliminar.Enabled = _productoSeleccionado != null;
                btnBuscar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}