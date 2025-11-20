using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormCrearInsumo : Form
    {
        private readonly ApiService _apiService;
        private List<ProductoAgricola> _productos;

        public FormCrearInsumo()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productos = new List<ProductoAgricola>();
        }

        private async void FormCrearInsumo_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            await CargarProductosAsync();
            LimpiarFormulario();
        }

        private void CargarComboBoxes()
        {
            cmbTipoInsumo.Items.Clear();
            var tiposFormateados = Insumo.TiposInsumo.ObtenerTodosFormateados();
            cmbTipoInsumo.Items.AddRange(tiposFormateados);
            cmbTipoInsumo.SelectedIndex = 0;

            cmbUnidadMedida.Items.Clear();
            var unidades = Insumo.UnidadesMedida.ObtenerTodas();
            cmbUnidadMedida.Items.AddRange(unidades);
            cmbUnidadMedida.SelectedIndex = 0;
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                cmbProducto.Items.Clear();
                cmbProducto.Items.Add("Cargando productos...");
                cmbProducto.SelectedIndex = 0;

                _productos = await _apiService.ObtenerTodosAsync();

                cmbProducto.Items.Clear();
                foreach (var producto in _productos)
                {
                    cmbProducto.Items.Add(producto);
                }

                if (cmbProducto.Items.Count > 0)
                {
                    cmbProducto.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar productos:\n{ex.Message}");
                cmbProducto.Items.Clear();
                cmbProducto.Items.Add("Error al cargar");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtProveedor.Clear();
            txtLote.Clear();
            txtDescripcion.Clear();
            txtUbicacion.Clear();

            numCantidad.Value = numCantidad.Minimum;
            numCostoUnitario.Value = 1000;
            numStockMinimo.Value = 0;

            dtpFechaCompra.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now.AddYears(1);
            chkTieneFechaVencimiento.Checked = false;

            if (cmbProducto.Items.Count > 0) cmbProducto.SelectedIndex = 0;
            if (cmbTipoInsumo.Items.Count > 0) cmbTipoInsumo.SelectedIndex = 0;
            if (cmbUnidadMedida.Items.Count > 0) cmbUnidadMedida.SelectedIndex = 0;

            txtNombre.Focus();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnCrear.Enabled = false;

                var productoSeleccionado = cmbProducto.SelectedItem as ProductoAgricola;
                var tipoFormateado = cmbTipoInsumo.SelectedItem?.ToString();
                var tipoOriginal = ConvertirTipoFormateadoAOriginal(tipoFormateado);

                var insumo = new Insumo
                {
                    Id = null,
                    Nombre = txtNombre.Text.Trim(),
                    ProductoId = productoSeleccionado?.Id,
                    Tipo = tipoOriginal,
                    Cantidad = (int)numCantidad.Value,
                    UnidadMedida = cmbUnidadMedida.SelectedItem?.ToString(),
                    CostoUnitario = (double)numCostoUnitario.Value,
                    Proveedor = txtProveedor.Text.Trim(),
                    FechaCompra = dtpFechaCompra.Value,
                    Lote = string.IsNullOrWhiteSpace(txtLote.Text) ? null : txtLote.Text.Trim(),
                    Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim(),
                    StockMinimo = (int)numStockMinimo.Value > 0 ? (int?)numStockMinimo.Value : null,
                    UbicacionAlmacen = string.IsNullOrWhiteSpace(txtUbicacion.Text) ? null : txtUbicacion.Text.Trim(),
                    FechaVencimiento = chkTieneFechaVencimiento.Checked ? (DateTime?)dtpFechaVencimiento.Value : null
                };

                var insumoCreado = await _apiService.CrearInsumoAsync(insumo);

                MessageHelper.ShowSuccess($"Insumo creado exitosamente con ID: {insumoCreado.Id}");

                if (MessageHelper.ShowConfirmation("¿Desea crear otro insumo?"))
                {
                    LimpiarFormulario();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al crear el insumo:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnCrear.Enabled = true;
            }
        }

        private string ConvertirTipoFormateadoAOriginal(string tipoFormateado)
        {
            if (string.IsNullOrEmpty(tipoFormateado)) return "FERTILIZANTE";

            var tiposOriginales = Insumo.TiposInsumo.ObtenerTodos();
            var tiposFormateados = Insumo.TiposInsumo.ObtenerTodosFormateados();

            for (int i = 0; i < tiposFormateados.Length; i++)
            {
                if (tiposFormateados[i] == tipoFormateado)
                {
                    return tiposOriginales[i];
                }
            }

            return "FERTILIZANTE";
        }

        private bool ValidarDatos()
        {
            string error;

            if (!Insumo.Validations.ValidarNombre(txtNombre.Text, out error))
            {
                MessageHelper.ShowWarning(error);
                txtNombre.Focus();
                return false;
            }

            if (cmbProducto.SelectedItem == null || !(cmbProducto.SelectedItem is ProductoAgricola))
            {
                MessageHelper.ShowWarning("Debe seleccionar un producto asociado.");
                cmbProducto.Focus();
                return false;
            }

            if (!Insumo.Validations.ValidarCantidad((int)numCantidad.Value, out error))
            {
                MessageHelper.ShowWarning(error);
                numCantidad.Focus();
                return false;
            }

            if (!Insumo.Validations.ValidarCostoUnitario((double)numCostoUnitario.Value, out error))
            {
                MessageHelper.ShowWarning(error);
                numCostoUnitario.Focus();
                return false;
            }

            if (!Insumo.Validations.ValidarProveedor(txtProveedor.Text, out error))
            {
                MessageHelper.ShowWarning(error);
                txtProveedor.Focus();
                return false;
            }

            if (!Insumo.Validations.ValidarFechaCompra(dtpFechaCompra.Value, out error))
            {
                MessageHelper.ShowWarning(error);
                dtpFechaCompra.Focus();
                return false;
            }

            if (cmbTipoInsumo.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Debe seleccionar un tipo de insumo.");
                cmbTipoInsumo.Focus();
                return false;
            }

            if (cmbUnidadMedida.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Debe seleccionar una unidad de medida.");
                cmbUnidadMedida.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirmation("¿Está seguro que desea limpiar todos los campos?"))
            {
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (CamposModificados())
            {
                if (MessageHelper.ShowConfirmation("Hay cambios sin guardar. ¿Está seguro que desea cancelar?"))
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private bool CamposModificados()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   !string.IsNullOrWhiteSpace(txtProveedor.Text) ||
                   numCantidad.Value != numCantidad.Minimum ||
                   numCostoUnitario.Value != 1000;
        }

        private void chkTieneFechaVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkTieneFechaVencimiento.Checked;
        }
    }
}
