using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormActualizarInsumo : Form
    {
        private readonly ApiService _apiService;
        private Insumo _insumoSeleccionado;
        private List<ProductoAgricola> _productos;

        public FormActualizarInsumo()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _insumoSeleccionado = null;
            _productos = new List<ProductoAgricola>();
        }

        private async void FormActualizarInsumo_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            await CargarProductosAsync();
            LimpiarFormulario();
            HabilitarControles(false);
        }

        private void CargarComboBoxes()
        {
            cmbTipoInsumo.Items.Clear();
            var tiposFormateados = Insumo.TiposInsumo.ObtenerTodosFormateados();
            cmbTipoInsumo.Items.AddRange(tiposFormateados);

            cmbUnidadMedida.Items.Clear();
            var unidades = Insumo.UnidadesMedida.ObtenerTodas();
            cmbUnidadMedida.Items.AddRange(unidades);
        }

        private async System.Threading.Tasks.Task CargarProductosAsync()
        {
            try
            {
                _productos = await _apiService.ObtenerTodosAsync();
                cmbProducto.Items.Clear();
                foreach (var producto in _productos)
                {
                    cmbProducto.Items.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar productos:\n{ex.Message}");
            }
        }

        private void LimpiarFormulario()
        {
            _insumoSeleccionado = null;
            lblIdValor.Text = "--";
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

            HabilitarControles(false);
        }

        private void HabilitarControles(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            cmbProducto.Enabled = habilitar;
            cmbTipoInsumo.Enabled = habilitar;
            numCantidad.Enabled = habilitar;
            cmbUnidadMedida.Enabled = habilitar;
            numCostoUnitario.Enabled = habilitar;
            txtProveedor.Enabled = habilitar;
            dtpFechaCompra.Enabled = habilitar;
            txtLote.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            numStockMinimo.Enabled = habilitar;
            txtUbicacion.Enabled = habilitar;
            chkTieneFechaVencimiento.Enabled = habilitar;
            dtpFechaVencimiento.Enabled = habilitar && chkTieneFechaVencimiento.Checked;
            btnActualizar.Enabled = habilitar;
            btnCancelarCambios.Enabled = habilitar;

            if (habilitar)
            {
                groupBoxDatos.ForeColor = System.Drawing.Color.DarkBlue;
            }
            else
            {
                groupBoxDatos.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el ID del insumo a actualizar:",
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
                    HabilitarControles(true);
                    MessageHelper.ShowSuccess($"Insumo {_insumoSeleccionado.Id} cargado correctamente.");
                }
                else
                {
                    MessageHelper.ShowWarning($"No se encontró el insumo con ID: {id}");
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
            txtNombre.Text = insumo.Nombre;
            txtProveedor.Text = insumo.Proveedor;
            txtLote.Text = insumo.Lote ?? "";
            txtDescripcion.Text = insumo.Descripcion ?? "";
            txtUbicacion.Text = insumo.UbicacionAlmacen ?? "";

            numCantidad.Value = insumo.Cantidad;
            numCostoUnitario.Value = (decimal)insumo.CostoUnitario;
            numStockMinimo.Value = insumo.StockMinimo ?? 0;

            dtpFechaCompra.Value = insumo.FechaCompra;

            if (insumo.FechaVencimiento.HasValue)
            {
                chkTieneFechaVencimiento.Checked = true;
                dtpFechaVencimiento.Value = insumo.FechaVencimiento.Value;
            }
            else
            {
                chkTieneFechaVencimiento.Checked = false;
            }

            SeleccionarProductoEnComboBox(insumo.ProductoId);
            SeleccionarTipoInsumoEnComboBox(insumo.Tipo);
            SeleccionarEnComboBox(cmbUnidadMedida, insumo.UnidadMedida);
        }

        private void SeleccionarProductoEnComboBox(string productoId)
        {
            for (int i = 0; i < cmbProducto.Items.Count; i++)
            {
                if (cmbProducto.Items[i] is ProductoAgricola producto && producto.Id == productoId)
                {
                    cmbProducto.SelectedIndex = i;
                    return;
                }
            }
        }

        private void SeleccionarTipoInsumoEnComboBox(string tipo)
        {
            string tipoFormateado = Insumo.FormatearTipo(tipo);
            SeleccionarEnComboBox(cmbTipoInsumo, tipoFormateado);
        }

        private void SeleccionarEnComboBox(ComboBox combo, string valor)
        {
            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (combo.Items[i].ToString().Equals(valor, StringComparison.OrdinalIgnoreCase))
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_insumoSeleccionado == null)
            {
                MessageHelper.ShowWarning("Primero debe buscar un insumo para actualizar.");
                return;
            }

            if (!ValidarDatos())
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnActualizar.Enabled = false;

                var productoSeleccionado = cmbProducto.SelectedItem as ProductoAgricola;
                var tipoFormateado = cmbTipoInsumo.SelectedItem?.ToString();
                var tipoOriginal = ConvertirTipoFormateadoAOriginal(tipoFormateado);

                var insumoActualizado = new Insumo
                {
                    Id = _insumoSeleccionado.Id,
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

                var resultado = await _apiService.ActualizarInsumoAsync(_insumoSeleccionado.Id, insumoActualizado);

                MessageHelper.ShowSuccess($"Insumo {resultado.Id} actualizado exitosamente.");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al actualizar el insumo:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnActualizar.Enabled = true;
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

            return true;
        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirmation("¿Está seguro que desea cancelar los cambios?"))
            {
                LimpiarFormulario();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTieneFechaVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkTieneFechaVencimiento.Checked;
        }
    }
}
