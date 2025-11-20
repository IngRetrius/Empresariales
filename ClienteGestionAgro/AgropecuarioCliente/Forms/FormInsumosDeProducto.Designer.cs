namespace AgropecuarioCliente.Forms
{
    partial class FormInsumosDeProducto
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
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.lblProductoIdValor = new System.Windows.Forms.Label();
            this.lblProductoNombre = new System.Windows.Forms.Label();
            this.lblProductoNombreValor = new System.Windows.Forms.Label();
            this.lblProductoTipo = new System.Windows.Forms.Label();
            this.lblProductoTipoValor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBoxResumen = new System.Windows.Forms.GroupBox();
            this.lblTotalInsumos = new System.Windows.Forms.Label();
            this.lblTotalInsumosValor = new System.Windows.Forms.Label();
            this.lblCostoTotalInsumos = new System.Windows.Forms.Label();
            this.lblCostoTotalInsumosValor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxProducto.SuspendLayout();
            this.groupBoxResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(300, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insumos del Producto";
            //
            // groupBoxProducto
            //
            this.groupBoxProducto.Controls.Add(this.lblProductoId);
            this.groupBoxProducto.Controls.Add(this.lblProductoIdValor);
            this.groupBoxProducto.Controls.Add(this.lblProductoNombre);
            this.groupBoxProducto.Controls.Add(this.lblProductoNombreValor);
            this.groupBoxProducto.Controls.Add(this.lblProductoTipo);
            this.groupBoxProducto.Controls.Add(this.lblProductoTipoValor);
            this.groupBoxProducto.Controls.Add(this.btnBuscar);
            this.groupBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxProducto.Location = new System.Drawing.Point(30, 70);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(850, 120);
            this.groupBoxProducto.TabIndex = 1;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto Seleccionado";
            //
            // lblProductoId
            //
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoId.Location = new System.Drawing.Point(30, 40);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(25, 18);
            this.lblProductoId.TabIndex = 0;
            this.lblProductoId.Text = "ID:";
            //
            // lblProductoIdValor
            //
            this.lblProductoIdValor.AutoSize = true;
            this.lblProductoIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductoIdValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProductoIdValor.Location = new System.Drawing.Point(150, 40);
            this.lblProductoIdValor.Name = "lblProductoIdValor";
            this.lblProductoIdValor.Size = new System.Drawing.Size(24, 18);
            this.lblProductoIdValor.TabIndex = 1;
            this.lblProductoIdValor.Text = "--";
            //
            // lblProductoNombre
            //
            this.lblProductoNombre.AutoSize = true;
            this.lblProductoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoNombre.Location = new System.Drawing.Point(30, 70);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(67, 18);
            this.lblProductoNombre.TabIndex = 2;
            this.lblProductoNombre.Text = "Nombre:";
            //
            // lblProductoNombreValor
            //
            this.lblProductoNombreValor.AutoSize = true;
            this.lblProductoNombreValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductoNombreValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProductoNombreValor.Location = new System.Drawing.Point(150, 70);
            this.lblProductoNombreValor.Name = "lblProductoNombreValor";
            this.lblProductoNombreValor.Size = new System.Drawing.Size(24, 18);
            this.lblProductoNombreValor.TabIndex = 3;
            this.lblProductoNombreValor.Text = "--";
            //
            // lblProductoTipo
            //
            this.lblProductoTipo.AutoSize = true;
            this.lblProductoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoTipo.Location = new System.Drawing.Point(450, 40);
            this.lblProductoTipo.Name = "lblProductoTipo";
            this.lblProductoTipo.Size = new System.Drawing.Size(42, 18);
            this.lblProductoTipo.TabIndex = 4;
            this.lblProductoTipo.Text = "Tipo:";
            //
            // lblProductoTipoValor
            //
            this.lblProductoTipoValor.AutoSize = true;
            this.lblProductoTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductoTipoValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProductoTipoValor.Location = new System.Drawing.Point(550, 40);
            this.lblProductoTipoValor.Name = "lblProductoTipoValor";
            this.lblProductoTipoValor.Size = new System.Drawing.Size(24, 18);
            this.lblProductoTipoValor.TabIndex = 5;
            this.lblProductoTipoValor.Text = "--";
            //
            // btnBuscar
            //
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(640, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 40);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Seleccionar Producto";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // groupBoxResumen
            //
            this.groupBoxResumen.Controls.Add(this.lblTotalInsumos);
            this.groupBoxResumen.Controls.Add(this.lblTotalInsumosValor);
            this.groupBoxResumen.Controls.Add(this.lblCostoTotalInsumos);
            this.groupBoxResumen.Controls.Add(this.lblCostoTotalInsumosValor);
            this.groupBoxResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxResumen.Location = new System.Drawing.Point(30, 200);
            this.groupBoxResumen.Name = "groupBoxResumen";
            this.groupBoxResumen.Size = new System.Drawing.Size(850, 80);
            this.groupBoxResumen.TabIndex = 2;
            this.groupBoxResumen.TabStop = false;
            this.groupBoxResumen.Text = "Resumen";
            //
            // lblTotalInsumos
            //
            this.lblTotalInsumos.AutoSize = true;
            this.lblTotalInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalInsumos.Location = new System.Drawing.Point(30, 35);
            this.lblTotalInsumos.Name = "lblTotalInsumos";
            this.lblTotalInsumos.Size = new System.Drawing.Size(132, 18);
            this.lblTotalInsumos.TabIndex = 0;
            this.lblTotalInsumos.Text = "Total de Insumos:";
            //
            // lblTotalInsumosValor
            //
            this.lblTotalInsumosValor.AutoSize = true;
            this.lblTotalInsumosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalInsumosValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalInsumosValor.Location = new System.Drawing.Point(180, 35);
            this.lblTotalInsumosValor.Name = "lblTotalInsumosValor";
            this.lblTotalInsumosValor.Size = new System.Drawing.Size(17, 18);
            this.lblTotalInsumosValor.TabIndex = 1;
            this.lblTotalInsumosValor.Text = "0";
            //
            // lblCostoTotalInsumos
            //
            this.lblCostoTotalInsumos.AutoSize = true;
            this.lblCostoTotalInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoTotalInsumos.Location = new System.Drawing.Point(400, 35);
            this.lblCostoTotalInsumos.Name = "lblCostoTotalInsumos";
            this.lblCostoTotalInsumos.Size = new System.Drawing.Size(153, 18);
            this.lblCostoTotalInsumos.TabIndex = 2;
            this.lblCostoTotalInsumos.Text = "Costo Total Insumos:";
            //
            // lblCostoTotalInsumosValor
            //
            this.lblCostoTotalInsumosValor.AutoSize = true;
            this.lblCostoTotalInsumosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostoTotalInsumosValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCostoTotalInsumosValor.Location = new System.Drawing.Point(570, 35);
            this.lblCostoTotalInsumosValor.Name = "lblCostoTotalInsumosValor";
            this.lblCostoTotalInsumosValor.Size = new System.Drawing.Size(29, 18);
            this.lblCostoTotalInsumosValor.TabIndex = 3;
            this.lblCostoTotalInsumosValor.Text = "$0";
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 300);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 280);
            this.dataGridView1.TabIndex = 3;
            //
            // btnActualizar
            //
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(550, 600);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // btnCerrar
            //
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(730, 600);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // FormInsumosDeProducto
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 660);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxResumen);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInsumosDeProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insumos del Producto";
            this.Load += new System.EventHandler(this.FormInsumosDeProducto_Load);
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.groupBoxResumen.ResumeLayout(false);
            this.groupBoxResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.Label lblProductoIdValor;
        private System.Windows.Forms.Label lblProductoNombre;
        private System.Windows.Forms.Label lblProductoNombreValor;
        private System.Windows.Forms.Label lblProductoTipo;
        private System.Windows.Forms.Label lblProductoTipoValor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxResumen;
        private System.Windows.Forms.Label lblTotalInsumos;
        private System.Windows.Forms.Label lblTotalInsumosValor;
        private System.Windows.Forms.Label lblCostoTotalInsumos;
        private System.Windows.Forms.Label lblCostoTotalInsumosValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
