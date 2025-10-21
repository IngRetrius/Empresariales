using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormListarProductos : Form
    {
        private readonly ApiService _apiService;
        private List<ProductoAgricola> _productosFiltrados;

        public FormListarProductos()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productosFiltrados = new List<ProductoAgricola>();
        }

        private async void FormListarProductos_Load(object sender, EventArgs e)
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

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadProducida",
                HeaderText = "Cantidad Producida",
                DataPropertyName = "CantidadProducida",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioVenta",
                HeaderText = "Precio Venta",
                DataPropertyName = "PrecioVenta",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Temporada",
                HeaderText = "Temporada",
                DataPropertyName = "Temporada",
                Width = 150
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

            cmbTemporada.Items.Clear();
            cmbTemporada.Items.Add("-- Todas --");
            cmbTemporada.Items.AddRange(new string[]
            {
                "Todo el año", "Temporada seca", "Temporada lluviosa",
                "Cosecha principal", "Cosecha mitaca", "Temporada alta", "Temporada baja"
            });
            cmbTemporada.SelectedIndex = 0;
        }

        private async System.Threading.Tasks.Task CargarProductos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // Carga inicial sin filtros - trae todos los productos
                _productosFiltrados = await _apiService.ObtenerTodosAsync();

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

        private async System.Threading.Tasks.Task AplicarFiltros()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnFiltrar.Enabled = false;

                bool tieneFiltroDeTipo = cmbTipoCultivo.SelectedIndex > 0;
                bool tieneFiltroDeNombre = !string.IsNullOrWhiteSpace(txtNombre.Text);
                bool tieneFiltroDeTemporada = cmbTemporada.SelectedIndex > 0;

                // OPCIÓN 1: Filtro por TIPO (servidor)
                if (tieneFiltroDeTipo && !tieneFiltroDeNombre && !tieneFiltroDeTemporada)
                {
                    string tipoSeleccionado = cmbTipoCultivo.SelectedItem.ToString();
                    _productosFiltrados = await _apiService.BuscarPorTipoAsync(tipoSeleccionado);
                }
                // OPCIÓN 2: Filtro por NOMBRE (servidor)
                else if (!tieneFiltroDeTipo && tieneFiltroDeNombre && !tieneFiltroDeTemporada)
                {
                    string nombreFiltro = txtNombre.Text.Trim();
                    _productosFiltrados = await _apiService.BuscarPorNombreAsync(nombreFiltro);
                }
                // OPCIÓN 3: Filtro por TEMPORADA (servidor)
                else if (!tieneFiltroDeTipo && !tieneFiltroDeNombre && tieneFiltroDeTemporada)
                {
                    string temporadaSeleccionada = cmbTemporada.SelectedItem.ToString();
                    _productosFiltrados = await _apiService.BuscarPorTemporadaAsync(temporadaSeleccionada);
                }
                // OPCIÓN 4: Múltiples filtros - primero filtra en servidor, luego complementa en cliente
                else if (tieneFiltroDeTipo || tieneFiltroDeNombre || tieneFiltroDeTemporada)
                {
                    // Paso 1: Obtener datos del servidor con el filtro principal
                    List<ProductoAgricola> resultadosServidor;

                    if (tieneFiltroDeTipo)
                    {
                        string tipoSeleccionado = cmbTipoCultivo.SelectedItem.ToString();
                        resultadosServidor = await _apiService.BuscarPorTipoAsync(tipoSeleccionado);
                    }
                    else if (tieneFiltroDeNombre)
                    {
                        string nombreFiltro = txtNombre.Text.Trim();
                        resultadosServidor = await _apiService.BuscarPorNombreAsync(nombreFiltro);
                    }
                    else // tieneFiltroDeTemporada
                    {
                        string temporadaSeleccionada = cmbTemporada.SelectedItem.ToString();
                        resultadosServidor = await _apiService.BuscarPorTemporadaAsync(temporadaSeleccionada);
                    }

                    // Paso 2: Aplicar filtros adicionales en cliente (solo si hay múltiples filtros)
                    _productosFiltrados = resultadosServidor;

                    // Aplicar filtro adicional de nombre (si existe y no fue el principal)
                    if (tieneFiltroDeNombre && !string.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        string nombreFiltro = txtNombre.Text.Trim().ToLower();
                        if (!tieneFiltroDeTipo || tieneFiltroDeTemporada)
                        {
                            _productosFiltrados = _productosFiltrados
                                .Where(p => p.Nombre.ToLower().Contains(nombreFiltro))
                                .ToList();
                        }
                    }

                    // Aplicar filtro adicional de tipo (si existe y no fue el principal)
                    if (tieneFiltroDeTipo)
                    {
                        string tipoSeleccionado = cmbTipoCultivo.SelectedItem.ToString().ToLower();
                        if (tieneFiltroDeNombre || tieneFiltroDeTemporada)
                        {
                            _productosFiltrados = _productosFiltrados
                                .Where(p => p.TipoCultivo.ToLower().Contains(tipoSeleccionado))
                                .ToList();
                        }
                    }

                    // Aplicar filtro adicional de temporada (si existe y no fue el principal)
                    if (tieneFiltroDeTemporada)
                    {
                        string temporadaSeleccionada = cmbTemporada.SelectedItem.ToString().ToLower();
                        if (tieneFiltroDeTipo || tieneFiltroDeNombre)
                        {
                            _productosFiltrados = _productosFiltrados
                                .Where(p => !string.IsNullOrEmpty(p.Temporada) &&
                                           p.Temporada.ToLower().Contains(temporadaSeleccionada))
                                .ToList();
                        }
                    }
                }
                // OPCIÓN 5: Sin filtros - traer todos
                else
                {
                    _productosFiltrados = await _apiService.ObtenerTodosAsync();
                }

                ActualizarDataGridView();
                ActualizarContadorRegistros();

                if (_productosFiltrados.Count == 0)
                {
                    MessageHelper.ShowInfo("No se encontraron productos con los criterios de búsqueda especificados.");
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

        // Eventos
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            await AplicarFiltros();
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoCultivo.SelectedIndex = 0;
            txtNombre.Clear();
            cmbTemporada.SelectedIndex = 0;

            await CargarProductos();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarProductos();
            MessageHelper.ShowSuccess("Lista de productos actualizada correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}