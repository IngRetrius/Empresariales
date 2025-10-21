using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormEstadisticas : Form
    {
        private readonly ApiService _apiService;
        private List<ProductoAgricola> _productos;

        public FormEstadisticas()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _productos = new List<ProductoAgricola>();
        }

        private async void FormEstadisticas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            await CargarEstadisticas();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewTipos.AutoGenerateColumns = false;
            dataGridViewTipos.Columns.Clear();

            dataGridViewTipos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo de Cultivo",
                DataPropertyName = "Tipo",
                Width = 120
            });

            dataGridViewTipos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 80
            });

            dataGridViewTipos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Hectareas",
                HeaderText = "Hectáreas",
                DataPropertyName = "Hectareas",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dataGridViewTipos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Produccion",
                HeaderText = "Producción",
                DataPropertyName = "Produccion",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
        }

        private async System.Threading.Tasks.Task CargarEstadisticas()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _productos = await _apiService.ObtenerTodosAsync();

                CalcularEstadisticasGenerales();
                CalcularEstadisticasPorTipo();
                CalcularPromedios();

                lblFechaActualizacion.Text = $"Última actualización: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar las estadísticas:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CalcularEstadisticasGenerales()
        {
            int totalProductos = _productos.Count;
            double totalHectareas = _productos.Sum(p => p.HectareasCultivadas);
            int totalProduccion = _productos.Sum(p => p.CantidadProducida);
            double ingresoTotal = _productos.Sum(p => p.CantidadProducida * p.PrecioVenta);

            lblTotalProductos.Text = $"Total de Productos: {totalProductos:N0}";
            lblTotalHectareas.Text = $"Total Hectáreas: {totalHectareas:N2}";
            lblProduccionTotal.Text = $"Producción Total: {totalProduccion:N0} unidades";
            lblIngresoTotal.Text = $"Ingreso Total: {ingresoTotal:C0}";
        }

        private void CalcularEstadisticasPorTipo()
        {
            var estadisticasPorTipo = _productos
                .GroupBy(p => p.TipoCultivo)
                .Select(g => new
                {
                    Tipo = g.Key,
                    Cantidad = g.Count(),
                    Hectareas = g.Sum(p => p.HectareasCultivadas),
                    Produccion = g.Sum(p => p.CantidadProducida)
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            dataGridViewTipos.DataSource = estadisticasPorTipo;
        }

        private void CalcularPromedios()
        {
            if (_productos.Count > 0)
            {
                double promedioHectareas = _productos.Average(p => p.HectareasCultivadas);
                double promedioProduccion = _productos.Average(p => p.CantidadProducida);
                double promedioPrecio = _productos.Average(p => p.PrecioVenta);

                // Calcular rentabilidad promedio
                double promedioRentabilidad = 0;
                var productosConRentabilidad = _productos.Where(p => p.HectareasCultivadas > 0).ToList();
                if (productosConRentabilidad.Count > 0)
                {
                    promedioRentabilidad = productosConRentabilidad
                        .Average(p => CalcularRentabilidad(p));
                }

                lblPromedioHectareas.Text = $"Promedio Hectáreas: {promedioHectareas:N2}";
                lblPromedioProduccion.Text = $"Promedio Producción: {promedioProduccion:N0}";
                lblPromedioPrecio.Text = $"Promedio Precio: {promedioPrecio:C0}";
                lblPromedioRentabilidad.Text = $"Promedio Rentabilidad: {promedioRentabilidad:C0}/Ha";
            }
            else
            {
                lblPromedioHectareas.Text = "Promedio Hectáreas: 0.00";
                lblPromedioProduccion.Text = "Promedio Producción: 0";
                lblPromedioPrecio.Text = "Promedio Precio: $0.00";
                lblPromedioRentabilidad.Text = "Promedio Rentabilidad: $0.00/Ha";
            }
        }

        private double CalcularRentabilidad(ProductoAgricola producto)
        {
            if (producto.HectareasCultivadas == 0) return 0;

            double ingresoTotal = producto.CantidadProducida * producto.PrecioVenta;
            double costoTotal = producto.CostoProduccion * producto.HectareasCultivadas;
            double utilidadNeta = ingresoTotal - costoTotal;

            return utilidadNeta / producto.HectareasCultivadas;
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarEstadisticas();
            MessageHelper.ShowSuccess("Estadísticas actualizadas correctamente.");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivos CSV (*.csv)|*.csv|Archivos de Texto (*.txt)|*.txt",
                    Title = "Exportar Estadísticas",
                    FileName = $"Estadisticas_Agropecuarias_{DateTime.Now:yyyyMMdd_HHmmss}"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportarEstadisticas(saveFileDialog.FileName);
                    MessageHelper.ShowSuccess($"Estadísticas exportadas exitosamente a:\n{saveFileDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al exportar estadísticas:\n{ex.Message}");
            }
        }

        private void ExportarEstadisticas(string filePath)
        {
            using (var writer = new System.IO.StreamWriter(filePath))
            {
                // Encabezados
                writer.WriteLine("ESTADÍSTICAS SISTEMA AGROPECUARIO");
                writer.WriteLine($"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                writer.WriteLine();

                // Estadísticas generales
                writer.WriteLine("ESTADÍSTICAS GENERALES");
                writer.WriteLine($"Total de Productos,{_productos.Count}");
                writer.WriteLine($"Total Hectáreas,{_productos.Sum(p => p.HectareasCultivadas):N2}");
                writer.WriteLine($"Producción Total,{_productos.Sum(p => p.CantidadProducida):N0}");
                writer.WriteLine($"Ingreso Total,{_productos.Sum(p => p.CantidadProducida * p.PrecioVenta):N2}");
                writer.WriteLine();

                // Estadísticas por tipo
                writer.WriteLine("ESTADÍSTICAS POR TIPO DE CULTIVO");
                writer.WriteLine("Tipo,Cantidad,Hectáreas,Producción");

                var estadisticasPorTipo = _productos
                    .GroupBy(p => p.TipoCultivo)
                    .Select(g => new
                    {
                        Tipo = g.Key,
                        Cantidad = g.Count(),
                        Hectareas = g.Sum(p => p.HectareasCultivadas),
                        Produccion = g.Sum(p => p.CantidadProducida)
                    })
                    .OrderByDescending(x => x.Cantidad);

                foreach (var item in estadisticasPorTipo)
                {
                    writer.WriteLine($"{item.Tipo},{item.Cantidad},{item.Hectareas:N2},{item.Produccion:N0}");
                }

                writer.WriteLine();

                // Promedios
                writer.WriteLine("PROMEDIOS");
                if (_productos.Count > 0)
                {
                    writer.WriteLine($"Promedio Hectáreas,{_productos.Average(p => p.HectareasCultivadas):N2}");
                    writer.WriteLine($"Promedio Producción,{_productos.Average(p => p.CantidadProducida):N0}");
                    writer.WriteLine($"Promedio Precio,{_productos.Average(p => p.PrecioVenta):N2}");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}