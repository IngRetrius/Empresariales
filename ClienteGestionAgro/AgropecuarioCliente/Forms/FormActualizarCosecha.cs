using System;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormActualizarCosecha : Form
    {
        private readonly ApiService _apiService;
        private Cosecha _cosechaSeleccionada;
        private Cosecha _cosechaOriginal;

        public FormActualizarCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _cosechaSeleccionada = null;
            _cosechaOriginal = null;
        }

        private void FormActualizarCosecha_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarControles(false);
        }

        private void LimpiarFormulario()
        {
            _cosechaSeleccionada = null;
            _cosechaOriginal = null;

            lblIdValor.Text = "--";
            lblProductoValor.Text = "--";
            dtpFecha.Value = DateTime.Now;
            numCantidad.Value = 0;
            numTrabajadores.Value = 0;
            numCostoManoObra.Value = 0;
            txtObservaciones.Clear();

            if (cmbCalidad.Items.Count > 0)
                cmbCalidad.SelectedIndex = 0;
            if (cmbCondiciones.Items.Count > 0)
                cmbCondiciones.SelectedIndex = 0;
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            HabilitarControles(false);
        }

        private void HabilitarControles(bool habilitar)
        {
            dtpFecha.Enabled = habilitar;
            numCantidad.Enabled = habilitar;
            cmbCalidad.Enabled = habilitar;
            numTrabajadores.Enabled = habilitar;
            numCostoManoObra.Enabled = habilitar;
            cmbCondiciones.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
            txtObservaciones.Enabled = habilitar;
            btnActualizar.Enabled = habilitar;
            btnCancelarCambios.Enabled = habilitar;

            groupBoxDatos.ForeColor = habilitar ? System.Drawing.Color.DarkBlue : System.Drawing.Color.Gray;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var formSelector = new FormSelectorCosecha();
                if (formSelector.ShowDialog() == DialogResult.OK)
                {
                    _cosechaSeleccionada = formSelector.CosechaSeleccionada;
                    if (_cosechaSeleccionada != null)
                    {
                        // Guardar copia del original para poder cancelar cambios
                        _cosechaOriginal = new Cosecha
                        {
                            Id = _cosechaSeleccionada.Id,
                            ProductoId = _cosechaSeleccionada.ProductoId,
                            FechaCosecha = _cosechaSeleccionada.FechaCosecha,
                            CantidadRecolectada = _cosechaSeleccionada.CantidadRecolectada,
                            CalidadProducto = _cosechaSeleccionada.CalidadProducto,
                            NumeroTrabajadores = _cosechaSeleccionada.NumeroTrabajadores,
                            CostoManoObra = _cosechaSeleccionada.CostoManoObra,
                            CondicionesClimaticas = _cosechaSeleccionada.CondicionesClimaticas,
                            EstadoCosecha = _cosechaSeleccionada.EstadoCosecha,
                            Observaciones = _cosechaSeleccionada.Observaciones
                        };

                        CargarDatosCosecha(_cosechaSeleccionada);
                        HabilitarControles(true);
                    }
                }
                formSelector.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al buscar cosecha:\n{ex.Message}");
            }
        }

        private void CargarDatosCosecha(Cosecha cosecha)
        {
            lblIdValor.Text = cosecha.Id;
            lblProductoValor.Text = $"ID: {cosecha.ProductoId}";

            dtpFecha.Value = cosecha.FechaCosecha;
            numCantidad.Value = cosecha.CantidadRecolectada;
            numTrabajadores.Value = cosecha.NumeroTrabajadores;
            numCostoManoObra.Value = (decimal)cosecha.CostoManoObra;
            txtObservaciones.Text = cosecha.Observaciones ?? "";

            SeleccionarEnComboBox(cmbCalidad, cosecha.CalidadProducto);
            SeleccionarEnComboBox(cmbCondiciones, cosecha.CondicionesClimaticas);
            SeleccionarEnComboBox(cmbEstado, cosecha.EstadoCosecha);
        }

        private void SeleccionarEnComboBox(ComboBox combo, string valor)
        {
            if (combo == null || string.IsNullOrEmpty(valor)) return;

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

        private bool ValidarDatos()
        {
            if (dtpFecha.Value > DateTime.Now)
            {
                MessageHelper.ShowWarning("La fecha de cosecha no puede ser futura.");
                dtpFecha.Focus();
                return false;
            }

            if (numCantidad.Value <= 0)
            {
                MessageHelper.ShowWarning("La cantidad recolectada debe ser mayor a cero.");
                numCantidad.Focus();
                return false;
            }

            if (cmbCalidad.SelectedIndex < 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar la calidad del producto.");
                cmbCalidad.Focus();
                return false;
            }

            if (numTrabajadores.Value <= 0)
            {
                MessageHelper.ShowWarning("El número de trabajadores debe ser mayor a cero.");
                numTrabajadores.Focus();
                return false;
            }

            if (numCostoManoObra.Value <= 0)
            {
                MessageHelper.ShowWarning("El costo de mano de obra debe ser mayor a cero.");
                numCostoManoObra.Focus();
                return false;
            }

            if (cmbCondiciones.SelectedIndex < 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar las condiciones climáticas.");
                cmbCondiciones.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex < 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar el estado de la cosecha.");
                cmbEstado.Focus();
                return false;
            }

            return true;
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_cosechaSeleccionada == null)
            {
                MessageHelper.ShowWarning("No hay ninguna cosecha seleccionada para actualizar.");
                return;
            }

            if (!ValidarDatos())
                return;

            string mensaje = $"¿Está seguro que desea actualizar la cosecha?\n\n" +
                           $"ID: {_cosechaSeleccionada.Id}\n" +
                           $"Producto ID: {_cosechaSeleccionada.ProductoId}";

            if (!MessageHelper.ShowConfirmation(mensaje))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnActualizar.Enabled = false;

                // Actualizar los valores
                _cosechaSeleccionada.FechaCosecha = dtpFecha.Value;
                _cosechaSeleccionada.CantidadRecolectada = (int)numCantidad.Value;
                _cosechaSeleccionada.CalidadProducto = cmbCalidad.SelectedItem?.ToString();
                _cosechaSeleccionada.NumeroTrabajadores = (int)numTrabajadores.Value;
                _cosechaSeleccionada.CostoManoObra = (double)numCostoManoObra.Value;
                _cosechaSeleccionada.CondicionesClimaticas = cmbCondiciones.SelectedItem?.ToString();
                _cosechaSeleccionada.EstadoCosecha = cmbEstado.SelectedItem?.ToString();
                _cosechaSeleccionada.Observaciones = txtObservaciones.Text.Trim();

                var resultado = await _apiService.ActualizarCosechaAsync(_cosechaSeleccionada.Id, _cosechaSeleccionada);

                if (resultado != null)
                {
                    MessageHelper.ShowSuccess("La cosecha ha sido actualizada exitosamente.");
                    _cosechaSeleccionada = resultado;
                    _cosechaOriginal = resultado;
                    CargarDatosCosecha(_cosechaSeleccionada);
                }
                else
                {
                    MessageHelper.ShowError("No se pudo actualizar la cosecha.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al actualizar la cosecha:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnActualizar.Enabled = true;
            }
        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            if (_cosechaOriginal != null)
            {
                if (MessageHelper.ShowConfirmation("¿Está seguro que desea cancelar los cambios?\nSe restaurarán los valores originales."))
                {
                    CargarDatosCosecha(_cosechaOriginal);
                    _cosechaSeleccionada = _cosechaOriginal;
                }
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (_cosechaSeleccionada != null)
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