using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormListarCosechas : Form
    {
        private readonly ApiService _apiService;
        private List<Cosecha> _cosechas;

        public FormListarCosechas()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _cosechas = new List<Cosecha>();
        }

        private async void FormListarCosechas_Load(object sender, EventArgs e)
        {
            await CargarCosechas();
        }

        private async System.Threading.Tasks.Task CargarCosechas()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _cosechas = await _apiService.ObtenerTodasCosechasAsync();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _cosechas;
                lblTotalRegistros.Text = $"Total de registros: {_cosechas.Count}";
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al cargar cosechas:");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarCosechas();
            MessageHelper.ShowSuccess("Lista de cosechas actualizada correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
