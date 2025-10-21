using System;
using System.Windows.Forms;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
        }

        // =========================
        // EVENTOS DE BOTONES PRINCIPALES
        // =========================

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormListar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormCrear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormBuscar();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormEstadisticas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormEditar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormEliminar();
        }

        // =========================
        // EVENTOS DEL MENÚ
        // =========================

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirmation("¿Está seguro que desea salir de la aplicación?"))
            {
                Application.Exit();
            }
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormListar();
        }

        private void crearProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormCrear();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEditar();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEliminar();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormBuscar();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEstadisticas();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormAcercaDe();
        }

        // =========================
        // MÉTODOS PARA ABRIR FORMULARIOS
        // =========================

        private void AbrirFormListar()
        {
            try
            {
                var formListar = new FormListarProductos();
                formListar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de listado:\n{ex.Message}");
            }
        }

        private void AbrirFormCrear()
        {
            try
            {
                var formCrear = new FormCrearProducto();
                if (formCrear.ShowDialog() == DialogResult.OK)
                {
                    MessageHelper.ShowSuccess("Producto creado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de creación:\n{ex.Message}");
            }
        }

        private void AbrirFormEditar()
        {
            try
            {
                // CAMBIO AQUÍ: usar FormActualizarProducto en lugar de FormEditarProducto
                var formEditar = new FormActualizarProducto();
                formEditar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de edición:\n{ex.Message}");
            }
        }

        private void AbrirFormEliminar()
        {
            try
            {
                var formEliminar = new FormEliminarProducto();
                formEliminar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de eliminación:\n{ex.Message}");
            }
        }

        private void AbrirFormBuscar()
        {
            try
            {
                var formBuscar = new FormBuscarProducto();
                formBuscar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de búsqueda:\n{ex.Message}");
            }
        }

        private void AbrirFormEstadisticas()
        {
            try
            {
                var formEstadisticas = new FormEstadisticas();
                formEstadisticas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir las estadísticas:\n{ex.Message}");
            }
        }

        private void AbrirFormAcercaDe()
        {
            try
            {
                var formAcercaDe = new FormAcercaDe();
                formAcercaDe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir la información:\n{ex.Message}");
            }
        }

        // =========================
        // EVENTOS ADICIONALES
        // =========================

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!MessageHelper.ShowConfirmation("¿Está seguro que desea cerrar la aplicación?"))
                {
                    e.Cancel = true;
                }
            }
        }

        private async void VerificarConexionAPI()
        {
            try
            {
                var apiService = new AgropecuarioCliente.Services.ApiService();
                await apiService.ObtenerTodosAsync();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowWarning($"No se pudo conectar con el servidor de la API.\n" +
                                        $"Verifique que el servidor esté ejecutándose en http://localhost:8081\n\n" +
                                        $"Error: {ex.Message}");
            }
        }

        private async void FormPrincipal_Shown(object sender, EventArgs e)
        {
            await System.Threading.Tasks.Task.Delay(1000);
            VerificarConexionAPI();
        }
        // ===== MÉTODOS PARA COSECHAS =====

        private void listarCosechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formListar = new FormListarCosechas();
                formListar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de listado de cosechas:\n{ex.Message}");
            }
        }

        private void crearCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formCrear = new FormCrearCosecha();
                if (formCrear.ShowDialog() == DialogResult.OK)
                {
                    MessageHelper.ShowSuccess("Cosecha creada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de creación:\n{ex.Message}");
            }
        }

        private void editarCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formEditar = new FormActualizarCosecha();
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    MessageHelper.ShowSuccess("Cosecha actualizada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de edición:\n{ex.Message}");
            }
        }

        private void buscarCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formBuscar = new FormBuscarCosecha();
                formBuscar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de búsqueda:\n{ex.Message}");
            }
        }

        private void eliminarCosechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formEliminar = new FormEliminarCosecha();
                if (formEliminar.ShowDialog() == DialogResult.OK)
                {
                    MessageHelper.ShowSuccess("Cosecha eliminada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario de eliminación:\n{ex.Message}");
            }
        }

        private void verPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formCosechas = new FormCosechasDeProducto();
                formCosechas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir cosechas por producto:\n{ex.Message}");
            }
        }
        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.L:
                        AbrirFormListar();
                        break;
                    case Keys.N:
                        AbrirFormCrear();
                        break;
                    case Keys.E:
                        AbrirFormEditar();
                        break;
                    case Keys.D:
                        AbrirFormEliminar();
                        break;
                    case Keys.F:
                        AbrirFormBuscar();
                        break;
                    case Keys.S:
                        AbrirFormEstadisticas();
                        break;
                    case Keys.Q:
                        this.Close();
                        break;
                }
            }
        }
    }
}