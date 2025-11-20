using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormListarInsumos : Form
    {
        private readonly ApiService _apiService;
        private List<Insumo> _insumosFiltrados;

        public FormListarInsumos()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _insumosFiltrados = new List<Insumo>();
        }

        private async void FormListarInsumos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarComboBoxes();
            await CargarInsumos();
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
                Name = "CostoUnitario",
                HeaderText = "Costo Unitario",
                DataPropertyName = "CostoUnitario",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
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

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "StockBajo",
                HeaderText = "Stock Bajo",
                DataPropertyName = "StockBajo",
                Width = 90
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "EstaVencido",
                HeaderText = "Vencido",
                DataPropertyName = "EstaVencido",
                Width = 80
            });
        }

        private void CargarComboBoxes()
        {
            cmbTipoInsumo.Items.Clear();
            cmbTipoInsumo.Items.Add("-- Todos --");
            var tiposFormateados = Insumo.TiposInsumo.ObtenerTodosFormateados();
            cmbTipoInsumo.Items.AddRange(tiposFormateados);
            cmbTipoInsumo.SelectedIndex = 0;
        }

        private async System.Threading.Tasks.Task CargarInsumos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _insumosFiltrados = await _apiService.ObtenerTodosInsumosAsync();

                ActualizarDataGridView();
                ActualizarContadorRegistros();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar los insumos:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _insumosFiltrados;
            dataGridView1.Refresh();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem is Insumo insumo)
                {
                    if (insumo.EstaVencido)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    }
                    else if (insumo.StockBajo)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                    }
                }
            }
        }

        private void ActualizarContadorRegistros()
        {
            lblTotalRegistros.Text = $"Total de registros: {_insumosFiltrados.Count}";
        }

        private async System.Threading.Tasks.Task AplicarFiltros()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnFiltrar.Enabled = false;

                bool tieneFiltroDeTipo = cmbTipoInsumo.SelectedIndex > 0;
                bool tieneFiltroDeNombre = !string.IsNullOrWhiteSpace(txtNombre.Text);
                bool tieneFiltroDeProveedor = !string.IsNullOrWhiteSpace(txtProveedor.Text);

                if (tieneFiltroDeTipo && !tieneFiltroDeNombre && !tieneFiltroDeProveedor)
                {
                    string tipoFormateado = cmbTipoInsumo.SelectedItem.ToString();
                    string tipoOriginal = ConvertirTipoFormateadoAOriginal(tipoFormateado);
                    _insumosFiltrados = await _apiService.BuscarInsumosPorTipoAsync(tipoOriginal);
                }
                else if (!tieneFiltroDeTipo && !tieneFiltroDeNombre && tieneFiltroDeProveedor)
                {
                    string proveedor = txtProveedor.Text.Trim();
                    _insumosFiltrados = await _apiService.BuscarInsumosPorProveedorAsync(proveedor);
                }
                else if (!tieneFiltroDeTipo && tieneFiltroDeNombre && !tieneFiltroDeProveedor)
                {
                    string nombreFiltro = txtNombre.Text.Trim();
                    var todosLosInsumos = await _apiService.ObtenerTodosInsumosAsync();
                    _insumosFiltrados = todosLosInsumos.Where(i =>
                        i.Nombre != null &&
                        i.Nombre.IndexOf(nombreFiltro, StringComparison.OrdinalIgnoreCase) >= 0
                    ).ToList();
                }
                else if (tieneFiltroDeTipo || tieneFiltroDeNombre || tieneFiltroDeProveedor)
                {
                    List<Insumo> resultadosServidor;

                    if (tieneFiltroDeTipo)
                    {
                        string tipoFormateado = cmbTipoInsumo.SelectedItem.ToString();
                        string tipoOriginal = ConvertirTipoFormateadoAOriginal(tipoFormateado);
                        resultadosServidor = await _apiService.BuscarInsumosPorTipoAsync(tipoOriginal);
                    }
                    else if (tieneFiltroDeProveedor)
                    {
                        string proveedor = txtProveedor.Text.Trim();
                        resultadosServidor = await _apiService.BuscarInsumosPorProveedorAsync(proveedor);
                    }
                    else
                    {
                        resultadosServidor = await _apiService.ObtenerTodosInsumosAsync();
                    }

                    _insumosFiltrados = resultadosServidor;

                    if (tieneFiltroDeNombre && !string.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        string nombreFiltro = txtNombre.Text.Trim().ToLower();
                        _insumosFiltrados = _insumosFiltrados
                            .Where(i => i.Nombre != null && i.Nombre.ToLower().Contains(nombreFiltro))
                            .ToList();
                    }

                    if (tieneFiltroDeProveedor && !string.IsNullOrWhiteSpace(txtProveedor.Text))
                    {
                        string proveedorFiltro = txtProveedor.Text.Trim().ToLower();
                        if (tieneFiltroDeTipo || tieneFiltroDeNombre)
                        {
                            _insumosFiltrados = _insumosFiltrados
                                .Where(i => i.Proveedor != null && i.Proveedor.ToLower().Contains(proveedorFiltro))
                                .ToList();
                        }
                    }

                    if (tieneFiltroDeTipo)
                    {
                        string tipoFormateado = cmbTipoInsumo.SelectedItem.ToString();
                        string tipoOriginal = ConvertirTipoFormateadoAOriginal(tipoFormateado);
                        if (tieneFiltroDeNombre || tieneFiltroDeProveedor)
                        {
                            _insumosFiltrados = _insumosFiltrados
                                .Where(i => i.Tipo != null && i.Tipo.Equals(tipoOriginal, StringComparison.OrdinalIgnoreCase))
                                .ToList();
                        }
                    }
                }
                else
                {
                    _insumosFiltrados = await _apiService.ObtenerTodosInsumosAsync();
                }

                ActualizarDataGridView();
                ActualizarContadorRegistros();

                if (_insumosFiltrados.Count == 0)
                {
                    MessageHelper.ShowInfo("No se encontraron insumos con los criterios de búsqueda especificados.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al aplicar filtros:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnFiltrar.Enabled = true;
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

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            await AplicarFiltros();
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoInsumo.SelectedIndex = 0;
            txtNombre.Clear();
            txtProveedor.Clear();

            await CargarInsumos();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarInsumos();
            MessageHelper.ShowSuccess("Lista de insumos actualizada correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
