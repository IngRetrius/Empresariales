using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormSelectorInsumo : Form
    {
        private readonly ApiService _apiService;
        private List<Insumo> _insumos;
        public Insumo InsumoSeleccionado { get; private set; }

        public FormSelectorInsumo()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _insumos = new List<Insumo>();
            InsumoSeleccionado = null;
        }

        private async void FormSelectorInsumo_Load(object sender, EventArgs e)
        {
            await CargarInsumosAsync();
        }

        private async System.Threading.Tasks.Task CargarInsumosAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lblEstado.Text = "Cargando insumos...";
                lblEstado.ForeColor = Color.Blue;

                _insumos = await _apiService.ObtenerTodosInsumosAsync();

                if (_insumos == null || _insumos.Count == 0)
                {
                    lblEstado.Text = "No hay insumos disponibles.";
                    lblEstado.ForeColor = Color.Red;
                    dgvInsumos.DataSource = null;
                    return;
                }

                ConfigurarDataGridView();
                dgvInsumos.DataSource = _insumos;
                lblEstado.Text = $"Total de insumos: {_insumos.Count}";
                lblEstado.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar insumos:\n{ex.Message}");
                lblEstado.Text = "Error al cargar insumos.";
                lblEstado.ForeColor = Color.Red;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvInsumos.AutoGenerateColumns = false;
            dgvInsumos.Columns.Clear();

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                Width = 80
            });

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Name = "Nombre",
                Width = 200
            });

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Name = "Tipo",
                Width = 120
            });

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Name = "Cantidad",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnidadMedida",
                HeaderText = "Unidad",
                Name = "UnidadMedida",
                Width = 100
            });

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Proveedor",
                HeaderText = "Proveedor",
                Name = "Proveedor",
                Width = 150
            });

            dgvInsumos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductoId",
                HeaderText = "Producto ID",
                Name = "ProductoId",
                Width = 100
            });

            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.MultiSelect = false;
            dgvInsumos.ReadOnly = true;
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToDeleteRows = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarInsumos();
        }

        private void FiltrarInsumos()
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                dgvInsumos.DataSource = null;
                dgvInsumos.DataSource = _insumos;
                lblEstado.Text = $"Total de insumos: {_insumos.Count}";
                return;
            }

            var insumosFiltrados = _insumos.Where(i =>
                (i.Id != null && i.Id.ToLower().Contains(textoBusqueda)) ||
                (i.Nombre != null && i.Nombre.ToLower().Contains(textoBusqueda)) ||
                (i.Tipo != null && i.Tipo.ToLower().Contains(textoBusqueda)) ||
                (i.Proveedor != null && i.Proveedor.ToLower().Contains(textoBusqueda)) ||
                (i.ProductoId != null && i.ProductoId.ToLower().Contains(textoBusqueda))
            ).ToList();

            dgvInsumos.DataSource = null;
            dgvInsumos.DataSource = insumosFiltrados;
            lblEstado.Text = $"Insumos encontrados: {insumosFiltrados.Count} de {_insumos.Count}";
            lblEstado.ForeColor = insumosFiltrados.Count > 0 ? Color.Green : Color.Red;
        }

        private void dgvInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SeleccionarInsumo();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarInsumo();
        }

        private void SeleccionarInsumo()
        {
            if (dgvInsumos.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Por favor, seleccione un insumo de la lista.");
                return;
            }

            InsumoSeleccionado = dgvInsumos.SelectedRows[0].DataBoundItem as Insumo;

            if (InsumoSeleccionado != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InsumoSeleccionado = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarInsumosAsync();
        }
    }
}
