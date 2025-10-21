using System;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormActualizarProducto : Form
    {
        private readonly ApiService _apiService;
        private ProductoAgricola _productoSeleccionado;

        public FormActualizarProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productoSeleccionado = null;
        }

        private void FormActualizarProducto_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            LimpiarFormulario();
            HabilitarControles(false);
        }

        private void CargarComboBoxes()
        {
            // Verificar si los ComboBox existen antes de cargarlos
            if (cmbTipoCultivo != null)
            {
                cmbTipoCultivo.Items.Clear();
                cmbTipoCultivo.Items.AddRange(new string[]
                {
                    "Café", "Arroz", "Cacao", "Mango", "Aguacate",
                    "Cítricos", "Maracuyá", "Sorgo", "Algodón", "Plátano"
                });
            }

            if (cmbTemporada != null)
            {
                cmbTemporada.Items.Clear();
                cmbTemporada.Items.AddRange(new string[]
                {
                    "Todo el año", "Temporada seca", "Temporada lluviosa",
                    "Cosecha principal", "Cosecha mitaca", "Temporada alta", "Temporada baja"
                });
            }

            if (cmbTipoSuelo != null)
            {
                cmbTipoSuelo.Items.Clear();
                cmbTipoSuelo.Items.AddRange(new string[]
                {
                    "Franco", "Franco arcilloso", "Franco arenoso",
                    "Arcilloso", "Arenoso", "Limoso"
                });
            }
        }

        private void LimpiarFormulario()
        {
            _productoSeleccionado = null;

            if (lblIdValor != null) lblIdValor.Text = "--";
            if (txtNombre != null) txtNombre.Clear();
            if (txtCodigoFinca != null) txtCodigoFinca.Clear();

            if (cmbTipoCultivo != null && cmbTipoCultivo.Items.Count > 0)
                cmbTipoCultivo.SelectedIndex = 0;
            if (cmbTemporada != null && cmbTemporada.Items.Count > 0)
                cmbTemporada.SelectedIndex = 0;
            if (cmbTipoSuelo != null && cmbTipoSuelo.Items.Count > 0)
                cmbTipoSuelo.SelectedIndex = 0;

            if (numHectareas != null) numHectareas.Value = numHectareas.Minimum;
            if (numCantidad != null) numCantidad.Value = numCantidad.Minimum;
            if (numPrecio != null) numPrecio.Value = 1000;
            if (numCosto != null) numCosto.Value = 100000;

            HabilitarControles(false);
        }

        private void HabilitarControles(bool habilitar)
        {
            if (txtNombre != null) txtNombre.Enabled = habilitar;
            if (cmbTipoCultivo != null) cmbTipoCultivo.Enabled = habilitar;
            if (numHectareas != null) numHectareas.Enabled = habilitar;
            if (numCantidad != null) numCantidad.Enabled = habilitar;
            if (numPrecio != null) numPrecio.Enabled = habilitar;
            if (numCosto != null) numCosto.Enabled = habilitar;
            if (cmbTemporada != null) cmbTemporada.Enabled = habilitar;
            if (cmbTipoSuelo != null) cmbTipoSuelo.Enabled = habilitar;
            if (txtCodigoFinca != null) txtCodigoFinca.Enabled = habilitar;
            if (btnActualizar != null) btnActualizar.Enabled = habilitar;
            if (btnCancelarCambios != null) btnCancelarCambios.Enabled = habilitar;

            if (groupBoxDatos != null)
            {
                if (habilitar)
                {
                    groupBoxDatos.ForeColor = System.Drawing.Color.DarkBlue;
                }
                else
                {
                    groupBoxDatos.ForeColor = System.Drawing.Color.Gray;
                }
            }
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
                        HabilitarControles(true);
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
            if (lblIdValor != null) lblIdValor.Text = producto.Id;
            if (txtNombre != null) txtNombre.Text = producto.Nombre;
            if (txtCodigoFinca != null) txtCodigoFinca.Text = producto.CodigoFinca ?? "";

            if (numHectareas != null) numHectareas.Value = (decimal)producto.HectareasCultivadas;
            if (numCantidad != null) numCantidad.Value = producto.CantidadProducida;
            if (numPrecio != null) numPrecio.Value = (decimal)producto.PrecioVenta;
            if (numCosto != null) numCosto.Value = (decimal)producto.CostoProduccion;

            SeleccionarEnComboBox(cmbTipoCultivo, producto.TipoCultivo);
            SeleccionarEnComboBox(cmbTemporada, producto.Temporada ?? "Todo el año");
            SeleccionarEnComboBox(cmbTipoSuelo, producto.TipoSuelo ?? "Franco");
        }

        private void SeleccionarEnComboBox(ComboBox combo, string valor)
        {
            if (combo == null) return;

            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (combo.Items[i].ToString().Equals(valor, StringComparison.OrdinalIgnoreCase))
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
            if (combo.Items.Count > 0) combo.SelectedIndex = 0;
        }

        private bool ValidarFormulario()
        {
            if (txtNombre == null || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageHelper.ShowWarning("El nombre del producto es obligatorio.");
                if (txtNombre != null) txtNombre.Focus();
                return false;
            }

            if (txtNombre.Text.Trim().Length < 2)
            {
                MessageHelper.ShowWarning("El nombre debe tener al menos 2 caracteres.");
                txtNombre.Focus();
                return false;
            }

            if (cmbTipoCultivo == null || cmbTipoCultivo.SelectedIndex < 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar un tipo de cultivo.");
                if (cmbTipoCultivo != null) cmbTipoCultivo.Focus();
                return false;
            }

            return true;
        }

        private ProductoAgricola CrearProductoActualizado()
        {
            return new ProductoAgricola
            {
                Id = _productoSeleccionado.Id,
                Nombre = txtNombre?.Text?.Trim() ?? "",
                TipoCultivo = cmbTipoCultivo?.SelectedItem?.ToString() ?? "",
                HectareasCultivadas = numHectareas != null ? (double)numHectareas.Value : 0,
                CantidadProducida = numCantidad != null ? (int)numCantidad.Value : 0,
                PrecioVenta = numPrecio != null ? (double)numPrecio.Value : 0,
                CostoProduccion = numCosto != null ? (double)numCosto.Value : 0,
                Temporada = cmbTemporada?.SelectedItem?.ToString() ?? "Todo el año",
                TipoSuelo = cmbTipoSuelo?.SelectedItem?.ToString() ?? "Franco",
                CodigoFinca = string.IsNullOrWhiteSpace(txtCodigoFinca?.Text) ? "F001" : txtCodigoFinca.Text.Trim(),
                FechaProduccion = _productoSeleccionado.FechaProduccion
            };
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageHelper.ShowWarning("No hay ningún producto seleccionado para actualizar.");
                return;
            }

            if (!ValidarFormulario())
                return;

            string mensaje = $"¿Está seguro que desea actualizar el producto?\n\n" +
                           $"ID: {_productoSeleccionado.Id}\n" +
                           $"Nombre actual: {_productoSeleccionado.Nombre}\n" +
                           $"Nuevo nombre: {txtNombre?.Text?.Trim()}";

            if (!MessageHelper.ShowConfirmation(mensaje))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (btnActualizar != null) btnActualizar.Enabled = false;

                var productoActualizado = CrearProductoActualizado();
                var resultado = await _apiService.ActualizarAsync(_productoSeleccionado.Id, productoActualizado);

                if (resultado != null)
                {
                    MessageHelper.ShowSuccess($"El producto '{resultado.Nombre}' ha sido actualizado exitosamente.");
                    _productoSeleccionado = resultado;
                    CargarDatosProducto(_productoSeleccionado);
                }
                else
                {
                    MessageHelper.ShowError("No se pudo actualizar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al actualizar el producto:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (btnActualizar != null) btnActualizar.Enabled = true;
            }
        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado != null)
            {
                if (MessageHelper.ShowConfirmation("¿Está seguro que desea cancelar los cambios?\nSe restaurarán los valores originales."))
                {
                    CargarDatosProducto(_productoSeleccionado);
                }
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado != null)
            {
                if (MessageHelper.ShowConfirmation("¿Está seguro que desea cerrar?\nSe perderán los cambios no guardados."))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}