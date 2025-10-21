using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormSelectorProducto : Form
    {
        private readonly ApiService _apiService;
        private List<ProductoAgricola> _todosLosProductos;
        private List<ProductoAgricola> _productosFiltrados;

        public ProductoAgricola ProductoSeleccionado { get; private set; }

        public FormSelectorProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _todosLosProductos = new List<ProductoAgricola>();
            _productosFiltrados = new List<ProductoAgricola>();
            ProductoSeleccionado = null;
        }

        private async void FormSelectorProducto_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarComboBoxes();
            await CargarProductos();
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
                Name = "TipoCultivo",
                HeaderText = "Tipo de Cultivo",
                DataPropertyName = "TipoCultivo",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HectareasCultivadas",
                HeaderText = "Hectáreas",
                DataPropertyName = "HectareasCultivadas",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
        }

        private void CargarComboBoxes()
        {
            cmbTipoCultivo.Items.Clear();
            cmbTipoCultivo.Items.Add("-- Todos --");
            cmbTipoCultivo.Items.AddRange(new string[]
            {
                "Café", "Arroz", "Cacao", "Mango", "Aguacate",
                "Cítricos", "Maracuyá", "Sorgo", "Algodón", "Plátano"
            });
            cmbTipoCultivo.SelectedIndex = 0;
        }

        private async System.Threading.Tasks.Task CargarProductos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _todosLosProductos = await _apiService.ObtenerTodosAsync();
                _productosFiltrados = new List<ProductoAgricola>(_todosLosProductos);
                ActualizarDataGridView();
                ActualizarContadorRegistros();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar los productos:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _productosFiltrados;
            dataGridView1.Refresh();
        }

        private void ActualizarContadorRegistros()
        {
            lblTotalRegistros.Text = $"Total de registros: {_productosFiltrados.Count}";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            _productosFiltrados = new List<ProductoAgricola>(_todosLosProductos);

            if (cmbTipoCultivo.SelectedIndex > 0)
            {
                string tipoSeleccionado = cmbTipoCultivo.SelectedItem.ToString().ToLower();
                _productosFiltrados = _productosFiltrados
                    .Where(p => p.TipoCultivo.ToLower().Contains(tipoSeleccionado))
                    .ToList();
            }

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                string nombreFiltro = txtNombre.Text.Trim().ToLower();
                _productosFiltrados = _productosFiltrados
                    .Where(p => p.Nombre.ToLower().Contains(nombreFiltro))
                    .ToList();
            }

            ActualizarDataGridView();
            ActualizarContadorRegistros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoCultivo.SelectedIndex = 0;
            txtNombre.Clear();
            _productosFiltrados = new List<ProductoAgricola>(_todosLosProductos);
            ActualizarDataGridView();
            ActualizarContadorRegistros();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SeleccionarProducto();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar un producto de la lista.");
                return;
            }
            SeleccionarProducto();
        }

        private void SeleccionarProducto()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ProductoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as ProductoAgricola;
                if (ProductoSeleccionado != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ProductoSeleccionado = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}