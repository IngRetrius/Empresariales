using System;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormEliminarInsumo : Form
    {
        private readonly ApiService _apiService;
        private Insumo _insumoSeleccionado;

        public FormEliminarInsumo()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _insumoSeleccionado = null;
        }

        private void FormEliminarInsumo_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            btnEliminar.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            _insumoSeleccionado = null;

            lblIdValor.Text = "--";
            lblNombreValor.Text = "--";
            lblProductoIdValor.Text = "--";
            lblTipoValor.Text = "--";
            lblCantidadValor.Text = "--";
            lblUnidadMedidaValor.Text = "--";
            lblCostoUnitarioValor.Text = "--";
            lblCostoTotalValor.Text = "--";
            lblProveedorValor.Text = "--";
            lblFechaCompraValor.Text = "--";
            lblLoteValor.Text = "--";
            lblDescripcionValor.Text = "--";
            lblStockMinimoValor.Text = "--";
            lblUbicacionValor.Text = "--";
            lblFechaVencimientoValor.Text = "--";

            lblStockBajo.Visible = false;
            lblVencido.Visible = false;

            groupBoxDatos.ForeColor = System.Drawing.Color.Gray;
            btnEliminar.Enabled = false;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el ID del insumo a eliminar:",
                "Buscar Insumo",
                "INS");

            if (string.IsNullOrWhiteSpace(id))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                _insumoSeleccionado = await _apiService.ObtenerInsumoPorIdAsync(id.Trim());

                if (_insumoSeleccionado != null)
                {
                    CargarDatosInsumo(_insumoSeleccionado);
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageHelper.ShowWarning($"No se encontró el insumo con ID: {id}");
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al buscar insumo:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CargarDatosInsumo(Insumo insumo)
        {
            lblIdValor.Text = insumo.Id;
            lblNombreValor.Text = insumo.Nombre;
            lblProductoIdValor.Text = insumo.ProductoId ?? "N/A";
            lblTipoValor.Text = Insumo.FormatearTipo(insumo.Tipo);
            lblCantidadValor.Text = $"{insumo.Cantidad:N0}";
            lblUnidadMedidaValor.Text = insumo.UnidadMedida;
            lblCostoUnitarioValor.Text = $"{insumo.CostoUnitario:C0}";
            lblCostoTotalValor.Text = $"{insumo.CostoTotal:C0}";
            lblProveedorValor.Text = insumo.Proveedor;
            lblFechaCompraValor.Text = insumo.FechaCompra.ToString("dd/MM/yyyy");
            lblLoteValor.Text = insumo.Lote ?? "N/A";
            lblDescripcionValor.Text = insumo.Descripcion ?? "N/A";
            lblStockMinimoValor.Text = insumo.StockMinimo?.ToString("N0") ?? "N/A";
            lblUbicacionValor.Text = insumo.UbicacionAlmacen ?? "N/A";
            lblFechaVencimientoValor.Text = insumo.FechaVencimiento?.ToString("dd/MM/yyyy") ?? "N/A";

            lblStockBajo.Visible = insumo.StockBajo;
            lblVencido.Visible = insumo.EstaVencido;

            groupBoxDatos.ForeColor = System.Drawing.Color.DarkRed;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_insumoSeleccionado == null)
            {
                MessageHelper.ShowWarning("No hay ningún insumo seleccionado para eliminar.");
                return;
            }

            string mensaje = $"¡ATENCIÓN! Está a punto de eliminar el siguiente insumo:\n\n" +
                           $"ID: {_insumoSeleccionado.Id}\n" +
                           $"Nombre: {_insumoSeleccionado.Nombre}\n" +
                           $"Tipo: {Insumo.FormatearTipo(_insumoSeleccionado.Tipo)}\n" +
                           $"Cantidad: {_insumoSeleccionado.Cantidad} {_insumoSeleccionado.UnidadMedida}\n" +
                           $"Costo Total: {_insumoSeleccionado.CostoTotal:C0}\n\n" +
                           $"Esta acción NO se puede deshacer.\n" +
                           $"¿Está COMPLETAMENTE SEGURO que desea eliminar este insumo?";

            var resultado = MessageBox.Show(mensaje, "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (resultado != DialogResult.Yes)
                return;

            var segundaConfirmacion = MessageBox.Show(
                "¿Está ABSOLUTAMENTE SEGURO?\n\nEsta es su última oportunidad para cancelar.\nEl insumo será eliminado permanentemente.",
                "Última Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

            if (segundaConfirmacion != DialogResult.Yes)
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;

                bool eliminado = await _apiService.EliminarInsumoAsync(_insumoSeleccionado.Id);

                if (eliminado)
                {
                    MessageHelper.ShowSuccess($"El insumo '{_insumoSeleccionado.Nombre}' ha sido eliminado exitosamente.");
                    LimpiarFormulario();
                }
                else
                {
                    MessageHelper.ShowError("No se pudo eliminar el insumo. Verifique la conexión con el servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al eliminar el insumo:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnEliminar.Enabled = _insumoSeleccionado != null;
                btnBuscar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
