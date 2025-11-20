using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormInsumosDeProducto : Form
    {
        private readonly ApiService _apiService;
        private ProductoAgricola _productoSeleccionado;
        private List<Insumo> _insumos;

        public FormInsumosDeProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productoSeleccionado = null;
            _insumos = new List<Insumo>();
        }

        private void FormInsumosDeProducto_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            LimpiarFormulario();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnidadMedida",
                HeaderText = "Unidad",
                DataPropertyName = "UnidadMedida",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CostoTotal",
                HeaderText = "Costo Total",
                DataPropertyName = "CostoTotal",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Proveedor",
                HeaderText = "Proveedor",
                DataPropertyName = "Proveedor",
                Width = 150
            });
        }

        private void LimpiarFormulario()
        {
            _productoSeleccionado = null;
            _insumos.Clear();

            lblProductoIdValor.Text = "--";
            lblProductoNombreValor.Text = "--";
            lblProductoTipoValor.Text = "--";

            lblTotalInsumosValor.Text = "0";
            lblCostoTotalInsumosValor.Text = "$0";

            dataGridView1.DataSource = null;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var formSelector = new FormSelectorProducto();
                if (formSelector.ShowDialog() == DialogResult.OK)
                {
                    _productoSeleccionado = formSelector.ProductoSeleccionado;
                    if (_productoSeleccionado != null)
                    {
                        await CargarInsumosDeProducto();
                    }
                }
                formSelector.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al seleccionar producto:\n{ex.Message}");
            }
        }

        private async System.Threading.Tasks.Task CargarInsumosDeProducto()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                lblProductoIdValor.Text = _productoSeleccionado.Id;
                lblProductoNombreValor.Text = _productoSeleccionado.Nombre;
                lblProductoTipoValor.Text = _productoSeleccionado.TipoCultivo;

                _insumos = await _apiService.ObtenerInsumosPorProductoAsync(_productoSeleccionado.Id);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _insumos;
                dataGridView1.Refresh();

                lblTotalInsumosValor.Text = _insumos.Count.ToString();

                double costoTotal = 0;
                foreach (var insumo in _insumos)
                {
                    costoTotal += insumo.CostoTotal;
                }
                lblCostoTotalInsumosValor.Text = costoTotal.ToString("C0");

                if (_insumos.Count == 0)
                {
                    MessageHelper.ShowInfo($"El producto '{_productoSeleccionado.Nombre}' no tiene insumos asociados.");
                }
                else
                {
                    MessageHelper.ShowSuccess($"Se encontraron {_insumos.Count} insumos para el producto '{_productoSeleccionado.Nombre}'.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar insumos del producto:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado != null)
            {
                await CargarInsumosDeProducto();
            }
            else
            {
                MessageHelper.ShowWarning("Primero debe seleccionar un producto.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
