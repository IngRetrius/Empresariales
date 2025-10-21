namespace AgropecuarioCliente.Forms
{
    partial class FormEstadisticas
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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblTotalHectareas = new System.Windows.Forms.Label();
            this.lblProduccionTotal = new System.Windows.Forms.Label();
            this.lblIngresoTotal = new System.Windows.Forms.Label();
            this.groupBoxPorTipo = new System.Windows.Forms.GroupBox();
            this.dataGridViewTipos = new System.Windows.Forms.DataGridView();
            this.groupBoxPromedios = new System.Windows.Forms.GroupBox();
            this.lblPromedioHectareas = new System.Windows.Forms.Label();
            this.lblPromedioProduccion = new System.Windows.Forms.Label();
            this.lblPromedioPrecio = new System.Windows.Forms.Label();
            this.lblPromedioRentabilidad = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblFechaActualizacion = new System.Windows.Forms.Label();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxPorTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipos)).BeginInit();
            this.groupBoxPromedios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(350, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estadísticas del Sistema";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.lblIngresoTotal);
            this.groupBoxGeneral.Controls.Add(this.lblProduccionTotal);
            this.groupBoxGeneral.Controls.Add(this.lblTotalHectareas);
            this.groupBoxGeneral.Controls.Add(this.lblTotalProductos);
            this.groupBoxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxGeneral.Location = new System.Drawing.Point(30, 70);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(400, 180);
            this.groupBoxGeneral.TabIndex = 1;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Estadísticas Generales";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalProductos.Location = new System.Drawing.Point(20, 35);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(200, 24);
            this.lblTotalProductos.TabIndex = 0;
            this.lblTotalProductos.Text = "Total de Productos: 0";
            // 
            // lblTotalHectareas
            // 
            this.lblTotalHectareas.AutoSize = true;
            this.lblTotalHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalHectareas.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalHectareas.Location = new System.Drawing.Point(20, 70);
            this.lblTotalHectareas.Name = "lblTotalHectareas";
            this.lblTotalHectareas.Size = new System.Drawing.Size(200, 24);
            this.lblTotalHectareas.TabIndex = 1;
            this.lblTotalHectareas.Text = "Total Hectáreas: 0.00";
            // 
            // lblProduccionTotal
            // 
            this.lblProduccionTotal.AutoSize = true;
            this.lblProduccionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblProduccionTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProduccionTotal.Location = new System.Drawing.Point(20, 105);
            this.lblProduccionTotal.Name = "lblProduccionTotal";
            this.lblProduccionTotal.Size = new System.Drawing.Size(250, 24);
            this.lblProduccionTotal.TabIndex = 2;
            this.lblProduccionTotal.Text = "Producción Total: 0 unidades";
            // 
            // lblIngresoTotal
            // 
            this.lblIngresoTotal.AutoSize = true;
            this.lblIngresoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblIngresoTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIngresoTotal.Location = new System.Drawing.Point(20, 140);
            this.lblIngresoTotal.Name = "lblIngresoTotal";
            this.lblIngresoTotal.Size = new System.Drawing.Size(200, 24);
            this.lblIngresoTotal.TabIndex = 3;
            this.lblIngresoTotal.Text = "Ingreso Total: $0.00";
            // 
            // groupBoxPorTipo
            // 
            this.groupBoxPorTipo.Controls.Add(this.dataGridViewTipos);
            this.groupBoxPorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxPorTipo.Location = new System.Drawing.Point(450, 70);
            this.groupBoxPorTipo.Name = "groupBoxPorTipo";
            this.groupBoxPorTipo.Size = new System.Drawing.Size(420, 300);
            this.groupBoxPorTipo.TabIndex = 2;
            this.groupBoxPorTipo.TabStop = false;
            this.groupBoxPorTipo.Text = "Estadísticas por Tipo de Cultivo";
            // 
            // dataGridViewTipos
            // 
            this.dataGridViewTipos.AllowUserToAddRows = false;
            this.dataGridViewTipos.AllowUserToDeleteRows = false;
            this.dataGridViewTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTipos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipos.Location = new System.Drawing.Point(15, 25);
            this.dataGridViewTipos.Name = "dataGridViewTipos";
            this.dataGridViewTipos.ReadOnly = true;
            this.dataGridViewTipos.RowHeadersWidth = 51;
            this.dataGridViewTipos.Size = new System.Drawing.Size(390, 260);
            this.dataGridViewTipos.TabIndex = 0;
            // 
            // groupBoxPromedios
            // 
            this.groupBoxPromedios.Controls.Add(this.lblPromedioRentabilidad);
            this.groupBoxPromedios.Controls.Add(this.lblPromedioPrecio);
            this.groupBoxPromedios.Controls.Add(this.lblPromedioProduccion);
            this.groupBoxPromedios.Controls.Add(this.lblPromedioHectareas);
            this.groupBoxPromedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxPromedios.Location = new System.Drawing.Point(30, 270);
            this.groupBoxPromedios.Name = "groupBoxPromedios";
            this.groupBoxPromedios.Size = new System.Drawing.Size(400, 180);
            this.groupBoxPromedios.TabIndex = 3;
            this.groupBoxPromedios.TabStop = false;
            this.groupBoxPromedios.Text = "Promedios";
            // 
            // lblPromedioHectareas
            // 
            this.lblPromedioHectareas.AutoSize = true;
            this.lblPromedioHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPromedioHectareas.Location = new System.Drawing.Point(20, 35);
            this.lblPromedioHectareas.Name = "lblPromedioHectareas";
            this.lblPromedioHectareas.Size = new System.Drawing.Size(200, 20);
            this.lblPromedioHectareas.TabIndex = 0;
            this.lblPromedioHectareas.Text = "Promedio Hectáreas: 0.00";
            // 
            // lblPromedioProduccion
            // 
            this.lblPromedioProduccion.AutoSize = true;
            this.lblPromedioProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPromedioProduccion.Location = new System.Drawing.Point(20, 65);
            this.lblPromedioProduccion.Name = "lblPromedioProduccion";
            this.lblPromedioProduccion.Size = new System.Drawing.Size(200, 20);
            this.lblPromedioProduccion.TabIndex = 1;
            this.lblPromedioProduccion.Text = "Promedio Producción: 0";
            // 
            // lblPromedioPrecio
            // 
            this.lblPromedioPrecio.AutoSize = true;
            this.lblPromedioPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPromedioPrecio.Location = new System.Drawing.Point(20, 95);
            this.lblPromedioPrecio.Name = "lblPromedioPrecio";
            this.lblPromedioPrecio.Size = new System.Drawing.Size(200, 20);
            this.lblPromedioPrecio.TabIndex = 2;
            this.lblPromedioPrecio.Text = "Promedio Precio: $0.00";
            // 
            // lblPromedioRentabilidad
            // 
            this.lblPromedioRentabilidad.AutoSize = true;
            this.lblPromedioRentabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPromedioRentabilidad.Location = new System.Drawing.Point(20, 125);
            this.lblPromedioRentabilidad.Name = "lblPromedioRentabilidad";
            this.lblPromedioRentabilidad.Size = new System.Drawing.Size(250, 20);
            this.lblPromedioRentabilidad.TabIndex = 3;
            this.lblPromedioRentabilidad.Text = "Promedio Rentabilidad: $0.00/Ha";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(500, 470);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LightBlue;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportar.Location = new System.Drawing.Point(640, 470);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 40);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(780, 470);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.AutoSize = true;
            this.lblFechaActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblFechaActualizacion.ForeColor = System.Drawing.Color.Gray;
            this.lblFechaActualizacion.Location = new System.Drawing.Point(30, 480);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(200, 18);
            this.lblFechaActualizacion.TabIndex = 7;
            this.lblFechaActualizacion.Text = "Última actualización: --";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(920, 530);
            this.Controls.Add(this.lblFechaActualizacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxPromedios);
            this.Controls.Add(this.groupBoxPorTipo);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadísticas - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxPorTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipos)).EndInit();
            this.groupBoxPromedios.ResumeLayout(false);
            this.groupBoxPromedios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblTotalHectareas;
        private System.Windows.Forms.Label lblProduccionTotal;
        private System.Windows.Forms.Label lblIngresoTotal;
        private System.Windows.Forms.GroupBox groupBoxPorTipo;
        private System.Windows.Forms.DataGridView dataGridViewTipos;
        private System.Windows.Forms.GroupBox groupBoxPromedios;
        private System.Windows.Forms.Label lblPromedioHectareas;
        private System.Windows.Forms.Label lblPromedioProduccion;
        private System.Windows.Forms.Label lblPromedioPrecio;
        private System.Windows.Forms.Label lblPromedioRentabilidad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFechaActualizacion;
    }
}