namespace AgropecuarioCliente.Forms
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCosechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCosechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCosechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCosechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCosechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.verPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblAtajos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.cosechasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarProductosToolStripMenuItem,
            this.crearProductoToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.buscarProductoToolStripMenuItem,
            this.toolStripSeparator1,
            this.estadísticasToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.listarProductosToolStripMenuItem.Text = "Listar Productos";
            this.listarProductosToolStripMenuItem.Click += new System.EventHandler(this.listarProductosToolStripMenuItem_Click);
            // 
            // crearProductoToolStripMenuItem
            // 
            this.crearProductoToolStripMenuItem.Name = "crearProductoToolStripMenuItem";
            this.crearProductoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.crearProductoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.crearProductoToolStripMenuItem.Text = "Crear Producto";
            this.crearProductoToolStripMenuItem.Click += new System.EventHandler(this.crearProductoToolStripMenuItem_Click);
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            this.buscarProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cosechasToolStripMenuItem
            // 
            this.cosechasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCosechasToolStripMenuItem,
            this.crearCosechaToolStripMenuItem,
            this.editarCosechaToolStripMenuItem,
            this.eliminarCosechaToolStripMenuItem,
            this.buscarCosechaToolStripMenuItem,
            this.toolStripSeparator2,
            this.verPorProductoToolStripMenuItem});
            this.cosechasToolStripMenuItem.Name = "cosechasToolStripMenuItem";
            this.cosechasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cosechasToolStripMenuItem.Text = "Cosechas";
            // 
            // listarCosechasToolStripMenuItem
            // 
            this.listarCosechasToolStripMenuItem.Name = "listarCosechasToolStripMenuItem";
            this.listarCosechasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.listarCosechasToolStripMenuItem.Text = "Listar Cosechas";
            this.listarCosechasToolStripMenuItem.Click += new System.EventHandler(this.listarCosechasToolStripMenuItem_Click);
            // 
            // crearCosechaToolStripMenuItem
            //
            this.crearCosechaToolStripMenuItem.Name = "crearCosechaToolStripMenuItem";
            this.crearCosechaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.crearCosechaToolStripMenuItem.Text = "Crear Cosecha";
            this.crearCosechaToolStripMenuItem.Click += new System.EventHandler(this.crearCosechaToolStripMenuItem_Click);
            //
            // editarCosechaToolStripMenuItem
            //
            this.editarCosechaToolStripMenuItem.Name = "editarCosechaToolStripMenuItem";
            this.editarCosechaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.editarCosechaToolStripMenuItem.Text = "Editar Cosecha";
            this.editarCosechaToolStripMenuItem.Click += new System.EventHandler(this.editarCosechaToolStripMenuItem_Click);
            // 
            // eliminarCosechaToolStripMenuItem
            //
            this.eliminarCosechaToolStripMenuItem.Name = "eliminarCosechaToolStripMenuItem";
            this.eliminarCosechaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.eliminarCosechaToolStripMenuItem.Text = "Eliminar Cosecha";
            this.eliminarCosechaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCosechaToolStripMenuItem_Click);
            //
            // buscarCosechaToolStripMenuItem
            //
            this.buscarCosechaToolStripMenuItem.Name = "buscarCosechaToolStripMenuItem";
            this.buscarCosechaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.buscarCosechaToolStripMenuItem.Text = "Buscar Cosecha";
            this.buscarCosechaToolStripMenuItem.Click += new System.EventHandler(this.buscarCosechaToolStripMenuItem_Click);
            //
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // verPorProductoToolStripMenuItem
            // 
            this.verPorProductoToolStripMenuItem.Name = "verPorProductoToolStripMenuItem";
            this.verPorProductoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.verPorProductoToolStripMenuItem.Text = "Ver por Producto ⭐";
            this.verPorProductoToolStripMenuItem.Click += new System.EventHandler(this.verPorProductoToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(150, 41);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(404, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Gestión Agropecuaria";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(188, 77);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(298, 20);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gestión completa de productos agrícolas";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.LightGreen;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnListar.Location = new System.Drawing.Point(38, 24);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 57);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Productos\n(Ctrl+L)";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(225, 24);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 57);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Producto\n(Ctrl+N)";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightYellow;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(412, 24);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 57);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Producto\n(Ctrl+E)";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(38, 106);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 57);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Producto\n(Ctrl+D)";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(225, 106);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 57);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Producto\n(Ctrl+F)";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Plum;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.Location = new System.Drawing.Point(412, 106);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(150, 57);
            this.btnEstadisticas.TabIndex = 5;
            this.btnEstadisticas.Text = "Estadísticas\n(Ctrl+S)";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblUniversidad.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUniversidad.Location = new System.Drawing.Point(225, 414);
            this.lblUniversidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(261, 18);
            this.lblUniversidad.TabIndex = 5;
            this.lblUniversidad.Text = "Universidad de Ibagué - Colombia";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(300, 439);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(78, 15);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Versión 2.0.0";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblInstrucciones.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInstrucciones.Location = new System.Drawing.Point(75, 366);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(525, 32);
            this.lblInstrucciones.TabIndex = 4;
            this.lblInstrucciones.Text = "Seleccione una opción del menú superior o haga clic en uno de los botones para ge" +
    "stionar los productos agrícolas del sistema.";
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnListar);
            this.panelBotones.Controls.Add(this.btnCrear);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnBuscar);
            this.panelBotones.Controls.Add(this.btnEstadisticas);
            this.panelBotones.Location = new System.Drawing.Point(38, 122);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(600, 228);
            this.panelBotones.TabIndex = 3;
            // 
            // lblAtajos
            // 
            this.lblAtajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAtajos.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAtajos.Location = new System.Drawing.Point(38, 463);
            this.lblAtajos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtajos.Name = "lblAtajos";
            this.lblAtajos.Size = new System.Drawing.Size(600, 32);
            this.lblAtajos.TabIndex = 7;
            this.lblAtajos.Text = "Atajos de teclado: Ctrl+L (Listar), Ctrl+N (Crear), Ctrl+E (Editar), Ctrl+D (Elim" +
    "inar), Ctrl+F (Buscar), Ctrl+S (Estadísticas), Ctrl+Q (Salir)";
            this.lblAtajos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(675, 512);
            this.Controls.Add(this.lblAtajos);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Agropecuario - Universidad de Ibagué";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        // Menu items for Cosechas (added manually in InitializeComponent)
        private System.Windows.Forms.ToolStripMenuItem cosechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCosechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCosechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCosechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCosechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCosechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem verPorProductoToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblAtajos;
    }
}