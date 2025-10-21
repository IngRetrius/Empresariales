using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormCosechasDeProducto : Form
    {
        private readonly ApiService _apiService;
        private ProductoAgricola _productoSeleccionado;
        private List<Cosecha> _cosechasDelProducto;

        public FormCosechasDeProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productoSeleccionado = null;
            _cosechasDelProducto = new List<Cosecha>();
        }

        private void FormCosechasDeProducto_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            LimpiarFormulario();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewCosechas.AutoGenerateColumns = false;
            dataGridViewCosechas.Columns.Clear();

            dataGridViewCosechas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });

            dataGridViewCosechas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaCosecha",
                HeaderText = "Fecha",
                DataPropertyName = "FechaCosecha",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dataGridViewCosechas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadRecolectada",
                HeaderText = "Cantidad (kg)",
                DataPropertyName = "CantidadRecolectada",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dataGridViewCosechas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CalidadProducto",
                HeaderText = "Calidad",
                DataPropertyName = "CalidadProducto",
                Width = 100
            });

            dataGridViewCosechas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroTrabajadores",
                HeaderText = "Trabajadores",
                DataPropertyName = "NumeroTrabajadores",
                Width = 100
            });

            dataGridViewCosechas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EstadoCosecha",
                HeaderText = "Estado",
                DataPropertyName = "EstadoCosecha",
                Width = 100
            });
        }

        private void LimpiarFormulario()
        {
            _productoSeleccionado = null;
            _cosechasDelProducto.Clear();

            lblIdProductoValor.Text = "-- Sin Seleccionar --";
            lblNombreValor.Text = "--";
            lblTipoValor.Text = "--";
            lblHectareasValor.Text = "--";

            lblTotalCosechas.Text = "Total Cosechas: 0";
            lblTotalRecolectado.Text = "Total Recolectado: 0 kg";
            lblCalidadPromedio.Text = "Calidad Promedio: --";

            dataGridViewCosechas.DataSource = null;

            btnAgregarCosecha.Enabled = false;
            btnVerDetalles.Enabled = false;
            btnEliminarCosecha.Enabled = false;

            groupBoxMaestro.ForeColor = System.Drawing.Color.Gray;
            groupBoxDetalle.ForeColor = System.Drawing.Color.Gray;
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
                        CargarDatosProducto(_productoSeleccionado);
                        CargarCosechasDelProducto();
                    }
                }
                formSelector.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al seleccionar producto:\n{ex.Message}");
            }
        }

        private void CargarDatosProducto(ProductoAgricola producto)
        {
            lblIdProductoValor.Text = producto.Id;
            lblNombreValor.Text = producto.Nombre;
            lblTipoValor.Text = producto.TipoCultivo;
            lblHectareasValor.Text = $"{producto.HectareasCultivadas:N2} ha";

            btnAgregarCosecha.Enabled = true;
            groupBoxMaestro.ForeColor = System.Drawing.Color.DarkBlue;
            groupBoxDetalle.ForeColor = System.Drawing.Color.DarkGreen;
        }

        private async void CargarCosechasDelProducto()
        {
            if (_productoSeleccionado == null) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                _cosechasDelProducto = await _apiService.ObtenerCosechasPorProductoAsync(_productoSeleccionado.Id);

                ActualizarDataGridView();
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar cosechas:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridViewCosechas.DataSource = null;
            dataGridViewCosechas.DataSource = _cosechasDelProducto;
            dataGridViewCosechas.Refresh();
        }

        private void ActualizarEstadisticas()
        {
            int totalCosechas = _cosechasDelProducto.Count;
            int totalRecolectado = _cosechasDelProducto.Sum(c => c.CantidadRecolectada);

            lblTotalCosechas.Text = $"Total Cosechas: {totalCosechas}";
            lblTotalRecolectado.Text = $"Total Recolectado: {totalRecolectado:N0} kg";

            if (totalCosechas > 0)
            {
                var calidadesConteo = _cosechasDelProducto
                    .GroupBy(c => c.CalidadProducto)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault();

                if (calidadesConteo != null)
                {
                    lblCalidadPromedio.Text = $"Calidad Promedio: {calidadesConteo.Key} ({calidadesConteo.Count()})";
                }
            }
            else
            {
                lblCalidadPromedio.Text = "Calidad Promedio: --";
            }
        }

        private void dataGridViewCosechas_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dataGridViewCosechas.SelectedRows.Count > 0;
            btnVerDetalles.Enabled = haySeleccion;
            btnEliminarCosecha.Enabled = haySeleccion;
        }

        private void btnAgregarCosecha_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageHelper.ShowWarning("Primero debe seleccionar un producto.");
                return;
            }

            try
            {
                // Abrir formulario de crear cosecha pasando el producto
                var formCrear = new AgropecuarioCliente.Forms.FormCrearCosecha(_productoSeleccionado.Id);
                if (formCrear.ShowDialog() == DialogResult.OK)
                {
                    MessageHelper.ShowSuccess("Cosecha agregada exitosamente.");
                    CargarCosechasDelProducto(); // Refrescar
                }
                formCrear.Dispose();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al agregar cosecha:\n{ex.Message}");
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewCosechas.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar una cosecha para ver sus detalles.");
                return;
            }

            try
            {
                var cosechaSeleccionada = dataGridViewCosechas.SelectedRows[0].DataBoundItem as Cosecha;
                if (cosechaSeleccionada != null)
                {
                    MostrarDetallesCosecha(cosechaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al mostrar detalles:\n{ex.Message}");
            }
        }

        private void MostrarDetallesCosecha(Cosecha cosecha)
        {
            string detalles = $"=======================================\n" +
                            $"DETALLES DE LA COSECHA\n" +
                            $"=======================================\n\n" +
                            $"ID: {cosecha.Id}\n" +
                            $"Producto ID: {cosecha.ProductoId}\n" +
                            $"Fecha: {cosecha.FechaCosecha:dd/MM/yyyy HH:mm}\n" +
                            $"Cantidad Recolectada: {cosecha.CantidadRecolectada:N0} kg\n" +
                            $"Calidad: {cosecha.CalidadProducto}\n" +
                            $"Trabajadores: {cosecha.NumeroTrabajadores}\n" +
                            $"Costo Mano de Obra: ${cosecha.CostoManoObra:N2}\n" +
                            $"Condiciones Climaticas: {cosecha.CondicionesClimaticas}\n" +
                            $"Estado: {cosecha.EstadoCosecha}\n\n" +
                            $"---------------------------------------\n" +
                            $"CALCULOS\n" +
                            $"---------------------------------------\n" +
                            $"Costo por kg: ${cosecha.CalcularCostoPorKg():N2}\n" +
                            $"Costo por trabajador: ${cosecha.CalcularCostoPorTrabajador():N2}\n" +
                            $"Rendimiento: {cosecha.CalcularRendimiento():N2} kg/trabajador\n\n" +
                            $"Observaciones:\n{(string.IsNullOrEmpty(cosecha.Observaciones) ? "Sin observaciones" : cosecha.Observaciones)}";

            MessageBox.Show(detalles, "Detalles de Cosecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnEliminarCosecha_Click(object sender, EventArgs e)
        {
            if (dataGridViewCosechas.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Debe seleccionar una cosecha para eliminar.");
                return;
            }

            var cosechaSeleccionada = dataGridViewCosechas.SelectedRows[0].DataBoundItem as Cosecha;
            if (cosechaSeleccionada == null) return;

            string mensaje = $"¿Está seguro que desea eliminar la cosecha?\n\n" +
                           $"ID: {cosechaSeleccionada.Id}\n" +
                           $"Fecha: {cosechaSeleccionada.FechaCosecha:dd/MM/yyyy}\n" +
                           $"Cantidad: {cosechaSeleccionada.CantidadRecolectada} kg";

            if (!MessageHelper.ShowConfirmation(mensaje))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                bool eliminada = await _apiService.EliminarCosechaAsync(cosechaSeleccionada.Id);

                if (eliminada)
                {
                    MessageHelper.ShowSuccess("Cosecha eliminada exitosamente.");
                    CargarCosechasDelProducto(); // Refrescar
                }
                else
                {
                    MessageHelper.ShowError("No se pudo eliminar la cosecha.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al eliminar cosecha:");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado != null)
            {
                CargarCosechasDelProducto();
                MessageHelper.ShowSuccess("Datos actualizados correctamente.");
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