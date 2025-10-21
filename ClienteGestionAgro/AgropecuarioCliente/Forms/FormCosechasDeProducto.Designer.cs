namespace AgropecuarioCliente.Forms
{
    partial class FormCosechasDeProducto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxMaestro = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.lblIdProductoValor = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblHectareasValor = new System.Windows.Forms.Label();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.dataGridViewCosechas = new System.Windows.Forms.DataGridView();
            this.lblTotalCosechas = new System.Windows.Forms.Label();
            this.lblTotalRecolectado = new System.Windows.Forms.Label();
            this.lblCalidadPromedio = new System.Windows.Forms.Label();
            this.btnAgregarCosecha = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnEliminarCosecha = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxMaestro.SuspendLayout();
            this.groupBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCosechas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cosechas de Producto (Maestro-Detalle)";
            // 
            // groupBoxMaestro
            // 
            this.groupBoxMaestro.Controls.Add(this.lblHectareasValor);
            this.groupBoxMaestro.Controls.Add(this.lblHectareas);
            this.groupBoxMaestro.Controls.Add(this.lblTipoValor);
            this.groupBoxMaestro.Controls.Add(this.lblTipo);
            this.groupBoxMaestro.Controls.Add(this.lblNombreValor);
            this.groupBoxMaestro.Controls.Add(this.lblNombre);
            this.groupBoxMaestro.Controls.Add(this.lblIdProductoValor);
            this.groupBoxMaestro.Controls.Add(this.lblIdProducto);
            this.groupBoxMaestro.Controls.Add(this.btnSeleccionarProducto);
            this.groupBoxMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxMaestro.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxMaestro.Location = new System.Drawing.Point(30, 70);
            this.groupBoxMaestro.Name = "groupBoxMaestro";
            this.groupBoxMaestro.Size = new System.Drawing.Size(840, 140);
            this.groupBoxMaestro.TabIndex = 1;
            this.groupBoxMaestro.TabStop = false;
            this.groupBoxMaestro.Text = "PRODUCTO SELECCIONADO (MAESTRO)";
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(620, 40);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(190, 80);
            this.btnSeleccionarProducto.TabIndex = 0;
            this.btnSeleccionarProducto.Text = "Seleccionar\r\nProducto";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProducto.ForeColor = System.Drawing.Color.Black;
            this.lblIdProducto.Location = new System.Drawing.Point(30, 40);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(99, 18);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // lblIdProductoValor
            // 
            this.lblIdProductoValor.AutoSize = true;
            this.lblIdProductoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProductoValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdProductoValor.Location = new System.Drawing.Point(140, 40);
            this.lblIdProductoValor.Name = "lblIdProductoValor";
            this.lblIdProductoValor.Size = new System.Drawing.Size(122, 18);
            this.lblIdProductoValor.TabIndex = 2;
            this.lblIdProductoValor.Text = "-- Sin Seleccionar --";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombreValor.ForeColor = System.Drawing.Color.Black;
            this.lblNombreValor.Location = new System.Drawing.Point(140, 70);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(20, 18);
            this.lblNombreValor.TabIndex = 4;
            this.lblNombreValor.Text = "--";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(30, 100);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(104, 18);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de Cultivo:";
            // 
            // lblTipoValor
            // 
            this.lblTipoValor.AutoSize = true;
            this.lblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoValor.ForeColor = System.Drawing.Color.Black;
            this.lblTipoValor.Location = new System.Drawing.Point(140, 100);
            this.lblTipoValor.Name = "lblTipoValor";
            this.lblTipoValor.Size = new System.Drawing.Size(20, 18);
            this.lblTipoValor.TabIndex = 6;
            this.lblTipoValor.Text = "--";
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareas.ForeColor = System.Drawing.Color.Black;
            this.lblHectareas.Location = new System.Drawing.Point(350, 40);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(79, 18);
            this.lblHectareas.TabIndex = 7;
            this.lblHectareas.Text = "Hectáreas:";
            // 
            // lblHectareasValor
            // 
            this.lblHectareasValor.AutoSize = true;
            this.lblHectareasValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareasValor.ForeColor = System.Drawing.Color.Black;
            this.lblHectareasValor.Location = new System.Drawing.Point(450, 40);
            this.lblHectareasValor.Name = "lblHectareasValor";
            this.lblHectareasValor.Size = new System.Drawing.Size(20, 18);
            this.lblHectareasValor.TabIndex = 8;
            this.lblHectareasValor.Text = "--";
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.lblCalidadPromedio);
            this.groupBoxDetalle.Controls.Add(this.lblTotalRecolectado);
            this.groupBoxDetalle.Controls.Add(this.lblTotalCosechas);
            this.groupBoxDetalle.Controls.Add(this.dataGridViewCosechas);
            this.groupBoxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDetalle.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBoxDetalle.Location = new System.Drawing.Point(30, 230);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(840, 340);
            this.groupBoxDetalle.TabIndex = 2;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "COSECHAS DEL PRODUCTO (DETALLE)";
            // 
            // dataGridViewCosechas
            // 
            this.dataGridViewCosechas.AllowUserToAddRows = false;
            this.dataGridViewCosechas.AllowUserToDeleteRows = false;
            this.dataGridViewCosechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCosechas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCosechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCosechas.Location = new System.Drawing.Point(20, 30);
            this.dataGridViewCosechas.MultiSelect = false;
            this.dataGridViewCosechas.Name = "dataGridViewCosechas";
            this.dataGridViewCosechas.ReadOnly = true;
            this.dataGridViewCosechas.RowHeadersWidth = 51;
            this.dataGridViewCosechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCosechas.Size = new System.Drawing.Size(800, 230);
            this.dataGridViewCosechas.TabIndex = 0;
            this.dataGridViewCosechas.SelectionChanged += new System.EventHandler(this.dataGridViewCosechas_SelectionChanged);
            // 
            // lblTotalCosechas
            // 
            this.lblTotalCosechas.AutoSize = true;
            this.lblTotalCosechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCosechas.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalCosechas.Location = new System.Drawing.Point(20, 275);
            this.lblTotalCosechas.Name = "lblTotalCosechas";
            this.lblTotalCosechas.Size = new System.Drawing.Size(180, 20);
            this.lblTotalCosechas.TabIndex = 1;
            this.lblTotalCosechas.Text = "Total Cosechas: 0";
            // 
            // lblTotalRecolectado
            // 
            this.lblTotalRecolectado.AutoSize = true;
            this.lblTotalRecolectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalRecolectado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalRecolectado.Location = new System.Drawing.Point(20, 300);
            this.lblTotalRecolectado.Name = "lblTotalRecolectado";
            this.lblTotalRecolectado.Size = new System.Drawing.Size(210, 20);
            this.lblTotalRecolectado.TabIndex = 2;
            this.lblTotalRecolectado.Text = "Total Recolectado: 0 kg";
            // 
            // lblCalidadPromedio
            // 
            this.lblCalidadPromedio.AutoSize = true;
            this.lblCalidadPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalidadPromedio.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCalidadPromedio.Location = new System.Drawing.Point(400, 275);
            this.lblCalidadPromedio.Name = "lblCalidadPromedio";
            this.lblCalidadPromedio.Size = new System.Drawing.Size(200, 20);
            this.lblCalidadPromedio.TabIndex = 3;
            this.lblCalidadPromedio.Text = "Calidad Promedio: --";
            // 
            // btnAgregarCosecha
            // 
            this.btnAgregarCosecha.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarCosecha.Enabled = false;
            this.btnAgregarCosecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCosecha.Location = new System.Drawing.Point(50, 590);
            this.btnAgregarCosecha.Name = "btnAgregarCosecha";
            this.btnAgregarCosecha.Size = new System.Drawing.Size(150, 45);
            this.btnAgregarCosecha.TabIndex = 3;
            this.btnAgregarCosecha.Text = "Agregar\r\nNueva Cosecha";
            this.btnAgregarCosecha.UseVisualStyleBackColor = false;
            this.btnAgregarCosecha.Click += new System.EventHandler(this.btnAgregarCosecha_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.LightBlue;
            this.btnVerDetalles.Enabled = false;
            this.btnVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerDetalles.Location = new System.Drawing.Point(230, 590);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(150, 45);
            this.btnVerDetalles.TabIndex = 4;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnEliminarCosecha
            // 
            this.btnEliminarCosecha.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCosecha.Enabled = false;
            this.btnEliminarCosecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarCosecha.Location = new System.Drawing.Point(410, 590);
            this.btnEliminarCosecha.Name = "btnEliminarCosecha";
            this.btnEliminarCosecha.Size = new System.Drawing.Size(150, 45);
            this.btnEliminarCosecha.TabIndex = 5;
            this.btnEliminarCosecha.Text = "Eliminar\r\nCosecha";
            this.btnEliminarCosecha.UseVisualStyleBackColor = false;
            this.btnEliminarCosecha.Click += new System.EventHandler(this.btnEliminarCosecha_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.LightYellow;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(590, 590);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(120, 45);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(740, 590);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 45);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormCosechasDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 660);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminarCosecha);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnAgregarCosecha);
            this.Controls.Add(this.groupBoxDetalle);
            this.Controls.Add(this.groupBoxMaestro);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCosechasDeProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cosechas de Producto - Relación Maestro-Detalle";
            this.Load += new System.EventHandler(this.FormCosechasDeProducto_Load);
            this.groupBoxMaestro.ResumeLayout(false);
            this.groupBoxMaestro.PerformLayout();
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCosechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxMaestro;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblIdProductoValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoValor;
        private System.Windows.Forms.Label lblHectareas;
        private System.Windows.Forms.Label lblHectareasValor;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.DataGridView dataGridViewCosechas;
        private System.Windows.Forms.Label lblTotalCosechas;
        private System.Windows.Forms.Label lblTotalRecolectado;
        private System.Windows.Forms.Label lblCalidadPromedio;
        private System.Windows.Forms.Button btnAgregarCosecha;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnEliminarCosecha;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCerrar;
    }
}