using System;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormCrearCosecha : Form
    {
        private readonly ApiService _apiService;
        private ProductoAgricola _productoSeleccionado;
        private string _productoIdPreseleccionado;

        public FormCrearCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productoSeleccionado = null;
            _productoIdPreseleccionado = null;
        }

        // Constructor sobrecargado que recibe el ID del producto
        public FormCrearCosecha(string productoId) : this()
        {
            _productoIdPreseleccionado = productoId;
        }

        private async void FormCrearCosecha_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            LimpiarFormulario();

            // Si se pasó un producto preseleccionado, cargarlo
            if (!string.IsNullOrEmpty(_productoIdPreseleccionado))
            {
                await CargarProductoPreseleccionado(_productoIdPreseleccionado);
            }
        }

        private async System.Threading.Tasks.Task CargarProductoPreseleccionado(string productoId)
        {
            try
            {
                var producto = await _apiService.ObtenerPorIdAsync(productoId);
                if (producto != null)
                {
                    _productoSeleccionado = producto;
                    lblProductoSeleccionado.Text = $"ID: {producto.Id} - {producto.Nombre} ({producto.TipoCultivo})";
                    lblProductoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
                    btnCrear.Enabled = true;

                    // Deshabilitar el botón de selección ya que el producto ya está seleccionado
                    btnSeleccionarProducto.Enabled = false;
                    btnSeleccionarProducto.Text = "Producto Asignado";
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar el producto:\n{ex.Message}");
            }
        }

        private void ConfigurarControles()
        {
            // Configurar valores por defecto
            dtpFecha.Value = DateTime.Now;

            if (cmbCalidad.Items.Count > 0)
                cmbCalidad.SelectedIndex = 1; // "Buena"

            if (cmbCondiciones.Items.Count > 0)
                cmbCondiciones.SelectedIndex = 0; // "Soleado"

            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 1; // "En Proceso"
        }

        private void LimpiarFormulario()
        {
            _productoSeleccionado = null;
            lblProductoSeleccionado.Text = "-- Sin seleccionar --";
            lblProductoSeleccionado.ForeColor = System.Drawing.Color.Gray;

            dtpFecha.Value = DateTime.Now;
            numCantidad.Value = 100;
            numTrabajadores.Value = 5;
            numCostoManoObra.Value = 50000;
            txtObservaciones.Clear();

            if (cmbCalidad.Items.Count > 0)
                cmbCalidad.SelectedIndex = 1;
            if (cmbCondiciones.Items.Count > 0)
                cmbCondiciones.SelectedIndex = 0;
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 1;

            btnCrear.Enabled = false;
            dtpFecha.Focus();
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var formSelector = new FormSelectorProducto();
                if (formSelector.ShowDialog() == DialogResult.OK)
                {
                    _productoSeleccionado = formSelector.ProductoSeleccionado;
                    if (_productoSeleccionado != null)
                    {
                        lblProductoSeleccionado.Text = $"ID: {_productoSeleccionado.Id} - {_productoSeleccionado.Nombre} ({_productoSeleccionado.TipoCultivo})";
                        lblProductoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
                        btnCrear.Enabled = true;
                    }
                }
                formSelector.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al seleccionar producto:\n{ex.Message}");
            }
        }

        private bool ValidarDatos()
        {
            if (_productoSeleccionado == null)
            {
                MessageHelper.ShowWarning("Debe seleccionar un producto para la cosecha.");
                btnSeleccionarProducto.Focus();
                return false;
            }

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

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnCrear.Enabled = false;

                var cosecha = new Cosecha
                {
                    ProductoId = _productoSeleccionado.Id,
                    FechaCosecha = dtpFecha.Value,
                    CantidadRecolectada = (int)numCantidad.Value,
                    CalidadProducto = cmbCalidad.SelectedItem.ToString(),
                    NumeroTrabajadores = (int)numTrabajadores.Value,
                    CostoManoObra = (double)numCostoManoObra.Value,
                    CondicionesClimaticas = cmbCondiciones.SelectedItem.ToString(),
                    EstadoCosecha = cmbEstado.SelectedItem.ToString(),
                    Observaciones = txtObservaciones.Text.Trim()
                };

                var cosechaCreada = await _apiService.CrearCosechaAsync(cosecha);

                if (cosechaCreada != null)
                {
                    MessageHelper.ShowSuccess($"Cosecha creada exitosamente con ID: {cosechaCreada.Id}");

                    if (MessageHelper.ShowConfirmation("¿Desea crear otra cosecha?"))
                    {
                        LimpiarFormulario();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageHelper.ShowError("No se pudo crear la cosecha.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al crear la cosecha:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnCrear.Enabled = _productoSeleccionado != null;
            }
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
            if (_productoSeleccionado != null || !string.IsNullOrWhiteSpace(txtObservaciones.Text))
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
    }
}