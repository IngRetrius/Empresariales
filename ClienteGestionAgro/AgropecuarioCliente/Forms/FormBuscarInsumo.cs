using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormBuscarInsumo : Form
    {
        private readonly ApiService _apiService;
        private List<Insumo> _resultados;

        public FormBuscarInsumo()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _resultados = new List<Insumo>();
        }

        private void FormBuscarInsumo_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            ConfigurarControlesBusqueda();
            LimpiarCamposResultado();
        }

        private void btnBuscarLista_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formSelector = new FormSelectorInsumo())
                {
                    if (formSelector.ShowDialog() == DialogResult.OK)
                    {
                        var insumoSeleccionado = formSelector.InsumoSeleccionado;

                        if (insumoSeleccionado != null)
                        {
                            _resultados.Clear();
                            _resultados.Add(insumoSeleccionado);
                            ActualizarResultados();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al seleccionar insumo:\n{ex.Message}");
            }
        }

        private void CargarComboBoxes()
        {
            cmbTipoInsumo.Items.Clear();
            var tiposFormateados = Insumo.TiposInsumo.ObtenerTodosFormateados();
            cmbTipoInsumo.Items.AddRange(tiposFormateados);
        }

        private void ConfigurarControlesBusqueda()
        {
            txtBusqueda.Visible = true;
            cmbTipoInsumo.Visible = false;
            txtProveedor.Visible = false;

            RadioButton_CheckedChanged(rbPorId, EventArgs.Empty);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Visible = false;
            cmbTipoInsumo.Visible = false;
            txtProveedor.Visible = false;

            if (rbPorId.Checked)
            {
                lblCriterio.Text = "Ingrese el ID del insumo:";
                txtBusqueda.Visible = true;
                txtBusqueda.Clear();
                txtBusqueda.Focus();
            }
            else if (rbPorNombre.Checked)
            {
                lblCriterio.Text = "Ingrese parte del nombre:";
                txtBusqueda.Visible = true;
                txtBusqueda.Clear();
                txtBusqueda.Focus();
            }
            else if (rbPorTipo.Checked)
            {
                lblCriterio.Text = "Seleccione el tipo de insumo:";
                cmbTipoInsumo.Visible = true;
                if (cmbTipoInsumo.Items.Count > 0)
                    cmbTipoInsumo.SelectedIndex = 0;
                cmbTipoInsumo.Focus();
            }
            else if (rbPorProveedor.Checked)
            {
                lblCriterio.Text = "Ingrese el nombre del proveedor:";
                txtProveedor.Visible = true;
                txtProveedor.Clear();
                txtProveedor.Focus();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarBusqueda())
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnBuscar.Enabled = false;

                _resultados.Clear();

                if (rbPorId.Checked)
                {
                    await BuscarPorId();
                }
                else if (rbPorNombre.Checked)
                {
                    await BuscarPorNombre();
                }
                else if (rbPorTipo.Checked)
                {
                    await BuscarPorTipo();
                }
                else if (rbPorProveedor.Checked)
                {
                    await BuscarPorProveedor();
                }

                ActualizarResultados();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al realizar la búsqueda:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnBuscar.Enabled = true;
            }
        }

        private bool ValidarBusqueda()
        {
            if (rbPorId.Checked || rbPorNombre.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    MessageHelper.ShowWarning("Debe ingresar un valor para buscar.");
                    txtBusqueda.Focus();
                    return false;
                }
            }
            else if (rbPorTipo.Checked)
            {
                if (cmbTipoInsumo.SelectedIndex < 0)
                {
                    MessageHelper.ShowWarning("Debe seleccionar un tipo de insumo.");
                    cmbTipoInsumo.Focus();
                    return false;
                }
            }
            else if (rbPorProveedor.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtProveedor.Text))
                {
                    MessageHelper.ShowWarning("Debe ingresar el nombre del proveedor.");
                    txtProveedor.Focus();
                    return false;
                }
            }

            return true;
        }

        private async System.Threading.Tasks.Task BuscarPorId()
        {
            string id = txtBusqueda.Text.Trim();
            var insumo = await _apiService.ObtenerInsumoPorIdAsync(id);
            if (insumo != null)
            {
                _resultados.Add(insumo);
            }
        }

        private async System.Threading.Tasks.Task BuscarPorNombre()
        {
            string nombre = txtBusqueda.Text.Trim();
            var todosLosInsumos = await _apiService.ObtenerTodosInsumosAsync();
            _resultados = todosLosInsumos.Where(i =>
                i.Nombre != null &&
                i.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();
        }

        private async System.Threading.Tasks.Task BuscarPorTipo()
        {
            string tipoFormateado = cmbTipoInsumo.SelectedItem.ToString();
            string tipoOriginal = ConvertirTipoFormateadoAOriginal(tipoFormateado);
            _resultados = await _apiService.BuscarInsumosPorTipoAsync(tipoOriginal);
        }

        private async System.Threading.Tasks.Task BuscarPorProveedor()
        {
            string proveedor = txtProveedor.Text.Trim();
            _resultados = await _apiService.BuscarInsumosPorProveedorAsync(proveedor);
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

        private void ActualizarResultados()
        {
            if (_resultados.Count == 0)
            {
                LimpiarCamposResultado();
                lblResultados.Text = "No se encontraron resultados.";
                lblResultados.ForeColor = System.Drawing.Color.Red;
                MessageHelper.ShowInfo("No se encontraron insumos que coincidan con los criterios de búsqueda.");
                return;
            }

            var insumo = _resultados[0];

            txtResultadoId.Text = insumo.Id ?? "";
            txtResultadoNombre.Text = insumo.Nombre ?? "";
            txtResultadoProductoId.Text = insumo.ProductoId ?? "";
            txtResultadoTipo.Text = Insumo.FormatearTipo(insumo.Tipo);
            txtResultadoCantidad.Text = insumo.Cantidad.ToString("N0");
            txtResultadoUnidadMedida.Text = insumo.UnidadMedida ?? "";
            txtResultadoCostoUnitario.Text = insumo.CostoUnitario.ToString("C0");
            txtResultadoCostoTotal.Text = insumo.CostoTotal.ToString("C0");
            txtResultadoProveedor.Text = insumo.Proveedor ?? "";
            txtResultadoFechaCompra.Text = insumo.FechaCompra.ToString("dd/MM/yyyy");
            txtResultadoLote.Text = insumo.Lote ?? "N/A";
            txtResultadoDescripcion.Text = insumo.Descripcion ?? "N/A";
            txtResultadoStockMinimo.Text = insumo.StockMinimo?.ToString("N0") ?? "N/A";
            txtResultadoUbicacion.Text = insumo.UbicacionAlmacen ?? "N/A";
            txtResultadoFechaVencimiento.Text = insumo.FechaVencimiento?.ToString("dd/MM/yyyy") ?? "N/A";

            lblStockBajo.Visible = insumo.StockBajo;
            lblVencido.Visible = insumo.EstaVencido;

            if (_resultados.Count == 1)
            {
                lblResultados.Text = "Se encontró 1 insumo.";
                lblResultados.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResultados.Text = $"Se encontraron {_resultados.Count} insumos. Mostrando el primero.";
                lblResultados.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void LimpiarCamposResultado()
        {
            txtResultadoId.Clear();
            txtResultadoNombre.Clear();
            txtResultadoProductoId.Clear();
            txtResultadoTipo.Clear();
            txtResultadoCantidad.Clear();
            txtResultadoUnidadMedida.Clear();
            txtResultadoCostoUnitario.Clear();
            txtResultadoCostoTotal.Clear();
            txtResultadoProveedor.Clear();
            txtResultadoFechaCompra.Clear();
            txtResultadoLote.Clear();
            txtResultadoDescripcion.Clear();
            txtResultadoStockMinimo.Clear();
            txtResultadoUbicacion.Clear();
            txtResultadoFechaVencimiento.Clear();
            lblResultados.Text = "";
            lblStockBajo.Visible = false;
            lblVencido.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            txtProveedor.Clear();
            if (cmbTipoInsumo.Items.Count > 0)
                cmbTipoInsumo.SelectedIndex = 0;

            _resultados.Clear();
            LimpiarCamposResultado();

            rbPorId.Checked = true;
            RadioButton_CheckedChanged(rbPorId, EventArgs.Empty);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
