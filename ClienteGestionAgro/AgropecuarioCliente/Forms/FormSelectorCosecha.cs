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
    public partial class FormSelectorCosecha : Form
    {
        private readonly ApiService _apiService;
        public Cosecha CosechaSeleccionada { get; private set; }

        public FormSelectorCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void FormSelectorCosecha_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var cosechas = await _apiService.ObtenerTodasCosechasAsync();
                dataGridView1.DataSource = cosechas;
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            CosechaSeleccionada = dataGridView1.CurrentRow.DataBoundItem as Cosecha;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
