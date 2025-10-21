using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormCrearProducto : Form
    {
        private readonly ApiService _apiService;

        public FormCrearProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private void FormCrearProducto_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            LimpiarFormulario();
        }

        private void CargarComboBoxes()
        {
            // Tipos de cultivo
            cmbTipoCultivo.Items.AddRange(new string[]
            {
                "Café", "Arroz", "Cacao", "Mango", "Aguacate",
                "Cítricos", "Maracuyá", "Sorgo", "Algodón", "Plátano"
            });
            cmbTipoCultivo.SelectedIndex = 0;

            // Temporadas
            cmbTemporada.Items.AddRange(new string[]
            {
                "Todo el año", "Temporada seca", "Temporada lluviosa",
                "Cosecha principal", "Cosecha mitaca", "Temporada alta", "Temporada baja"
            });
            cmbTemporada.SelectedIndex = 0;

            // Tipos de suelo
            cmbTipoSuelo.Items.AddRange(new string[]
            {
                "Franco", "Franco arcilloso", "Franco arenoso",
                "Arcilloso", "Arenoso", "Limoso"
            });
            cmbTipoSuelo.SelectedIndex = 0;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCodigoFinca.Clear();
            numHectareas.Value = numHectareas.Minimum;
            numCantidad.Value = numCantidad.Minimum;
            numPrecio.Value = 1000;
            numCosto.Value = 100000;

            if (cmbTipoCultivo.Items.Count > 0) cmbTipoCultivo.SelectedIndex = 0;
            if (cmbTemporada.Items.Count > 0) cmbTemporada.SelectedIndex = 0;
            if (cmbTipoSuelo.Items.Count > 0) cmbTipoSuelo.SelectedIndex = 0;

            txtNombre.Focus();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnCrear.Enabled = false;

                var producto = new ProductoAgricola
                {
                    // NO asignar ID aquí - dejar que el servidor lo genere
                    Id = null,
                    Nombre = txtNombre.Text.Trim(),
                    TipoCultivo = cmbTipoCultivo.SelectedItem?.ToString(),
                    HectareasCultivadas = (double)numHectareas.Value,
                    CantidadProducida = (int)numCantidad.Value,
                    PrecioVenta = (double)numPrecio.Value,
                    CostoProduccion = (double)numCosto.Value,
                    Temporada = cmbTemporada.SelectedItem?.ToString(),
                    TipoSuelo = cmbTipoSuelo.SelectedItem?.ToString(),
                    CodigoFinca = string.IsNullOrWhiteSpace(txtCodigoFinca.Text) ? "F001" : txtCodigoFinca.Text.Trim(),
                    FechaProduccion = DateTime.Now
                };

                var productoCreado = await _apiService.CrearAsync(producto);

                MessageHelper.ShowSuccess($"Producto creado exitosamente con ID: {productoCreado.Id}");

                if (MessageHelper.ShowConfirmation("¿Desea crear otro producto?"))
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
                MessageHelper.ShowError($"Error al crear el producto:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnCrear.Enabled = true;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageHelper.ShowWarning("El nombre del producto es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            if (txtNombre.Text.Trim().Length < 2)
            {
                MessageHelper.ShowWarning("El nombre debe tener al menos 2 caracteres.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoFinca.Text))
            {
                MessageHelper.ShowWarning("El código de finca es obligatorio.");
                txtCodigoFinca.Focus();
                return false;
            }

            if (cmbTipoCultivo.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Debe seleccionar un tipo de cultivo.");
                cmbTipoCultivo.Focus();
                return false;
            }

            if (numPrecio.Value <= numCosto.Value / 100)
            {
                MessageHelper.ShowWarning("El precio de venta debe ser mayor al costo de producción por unidad.");
                numPrecio.Focus();
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
                   !string.IsNullOrWhiteSpace(txtCodigoFinca.Text) ||
                   numHectareas.Value != numHectareas.Minimum ||
                   numCantidad.Value != numCantidad.Minimum ||
                   numPrecio.Value != 1000 ||
                   numCosto.Value != 100000;
        }
    }
}