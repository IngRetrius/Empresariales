namespace AgropecuarioCliente.Forms
{
    partial class FormCrearCosecha
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.lblProductoSeleccionado = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.cmbCalidad = new System.Windows.Forms.ComboBox();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.numTrabajadores = new System.Windows.Forms.NumericUpDown();
            this.lblCostoManoObra = new System.Windows.Forms.Label();
            this.numCostoManoObra = new System.Windows.Forms.NumericUpDown();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.cmbCondiciones = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoManoObra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Nueva Cosecha";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtObservaciones);
            this.groupBoxDatos.Controls.Add(this.lblObservaciones);
            this.groupBoxDatos.Controls.Add(this.cmbEstado);
            this.groupBoxDatos.Controls.Add(this.lblEstado);
            this.groupBoxDatos.Controls.Add(this.cmbCondiciones);
            this.groupBoxDatos.Controls.Add(this.lblCondiciones);
            this.groupBoxDatos.Controls.Add(this.numCostoManoObra);
            this.groupBoxDatos.Controls.Add(this.lblCostoManoObra);
            this.groupBoxDatos.Controls.Add(this.numTrabajadores);
            this.groupBoxDatos.Controls.Add(this.lblTrabajadores);
            this.groupBoxDatos.Controls.Add(this.cmbCalidad);
            this.groupBoxDatos.Controls.Add(this.lblCalidad);
            this.groupBoxDatos.Controls.Add(this.numCantidad);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.dtpFecha);
            this.groupBoxDatos.Controls.Add(this.lblFecha);
            this.groupBoxDatos.Controls.Add(this.lblProductoSeleccionado);
            this.groupBoxDatos.Controls.Add(this.lblProducto);
            this.groupBoxDatos.Controls.Add(this.btnSeleccionarProducto);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 60);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(640, 480);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos de la Cosecha";
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(460, 30);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(150, 35);
            this.btnSeleccionarProducto.TabIndex = 0;
            this.btnSeleccionarProducto.Text = "Seleccionar Producto";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(20, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 15);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // lblProductoSeleccionado
            // 
            this.lblProductoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoSeleccionado.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProductoSeleccionado.Location = new System.Drawing.Point(20, 50);
            this.lblProductoSeleccionado.Name = "lblProductoSeleccionado";
            this.lblProductoSeleccionado.Size = new System.Drawing.Size(400, 20);
            this.lblProductoSeleccionado.TabIndex = 2;
            this.lblProductoSeleccionado.Text = "-- Sin seleccionar --";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFecha.Location = new System.Drawing.Point(20, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Cosecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(20, 105);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 21);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(200, 85);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(135, 15);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad Recolectada (kg):";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCantidad.Location = new System.Drawing.Point(200, 105);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 21);
            this.numCantidad.TabIndex = 6;
            this.numCantidad.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCalidad.Location = new System.Drawing.Point(350, 85);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(118, 15);
            this.lblCalidad.TabIndex = 7;
            this.lblCalidad.Text = "Calidad del Producto:";
            // 
            // cmbCalidad
            // 
            this.cmbCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCalidad.FormattingEnabled = true;
            this.cmbCalidad.Items.AddRange(new object[] {
            "Excelente",
            "Buena",
            "Regular",
            "Mala"});
            this.cmbCalidad.Location = new System.Drawing.Point(350, 105);
            this.cmbCalidad.Name = "cmbCalidad";
            this.cmbCalidad.Size = new System.Drawing.Size(150, 23);
            this.cmbCalidad.TabIndex = 8;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTrabajadores.Location = new System.Drawing.Point(20, 145);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(135, 15);
            this.lblTrabajadores.TabIndex = 9;
            this.lblTrabajadores.Text = "Número de Trabajadores:";
            // 
            // numTrabajadores
            // 
            this.numTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numTrabajadores.Location = new System.Drawing.Point(20, 165);
            this.numTrabajadores.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numTrabajadores.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTrabajadores.Name = "numTrabajadores";
            this.numTrabajadores.Size = new System.Drawing.Size(120, 21);
            this.numTrabajadores.TabIndex = 10;
            this.numTrabajadores.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblCostoManoObra
            // 
            this.lblCostoManoObra.AutoSize = true;
            this.lblCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoManoObra.Location = new System.Drawing.Point(200, 145);
            this.lblCostoManoObra.Name = "lblCostoManoObra";
            this.lblCostoManoObra.Size = new System.Drawing.Size(141, 15);
            this.lblCostoManoObra.TabIndex = 11;
            this.lblCostoManoObra.Text = "Costo de Mano de Obra ($):";
            // 
            // numCostoManoObra
            // 
            this.numCostoManoObra.DecimalPlaces = 2;
            this.numCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCostoManoObra.Location = new System.Drawing.Point(200, 165);
            this.numCostoManoObra.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numCostoManoObra.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numCostoManoObra.Name = "numCostoManoObra";
            this.numCostoManoObra.Size = new System.Drawing.Size(150, 21);
            this.numCostoManoObra.TabIndex = 12;
            this.numCostoManoObra.Value = new decimal(new int[] { 50000, 0, 0, 0 });
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCondiciones.Location = new System.Drawing.Point(20, 205);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(138, 15);
            this.lblCondiciones.TabIndex = 13;
            this.lblCondiciones.Text = "Condiciones Climáticas:";
            // 
            // cmbCondiciones
            // 
            this.cmbCondiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCondiciones.FormattingEnabled = true;
            this.cmbCondiciones.Items.AddRange(new object[] {
            "Soleado",
            "Nublado",
            "Lluvioso",
            "Húmedo",
            "Seco",
            "Ventoso"});
            this.cmbCondiciones.Location = new System.Drawing.Point(20, 225);
            this.cmbCondiciones.Name = "cmbCondiciones";
            this.cmbCondiciones.Size = new System.Drawing.Size(200, 23);
            this.cmbCondiciones.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEstado.Location = new System.Drawing.Point(250, 205);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(119, 15);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado de la Cosecha:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Proceso",
            "Completada",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(250, 225);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 23);
            this.cmbEstado.TabIndex = 16;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblObservaciones.Location = new System.Drawing.Point(20, 265);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(88, 15);
            this.lblObservaciones.TabIndex = 17;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtObservaciones.Location = new System.Drawing.Point(20, 285);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(590, 170);
            this.txtObservaciones.TabIndex = 18;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightGreen;
            this.btnCrear.Enabled = false;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(250, 560);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 40);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Cosecha";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(390, 560);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(530, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCrearCosecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 620);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearCosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Cosecha - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormCrearCosecha_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoManoObra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProductoSeleccionado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.ComboBox cmbCalidad;
        private System.Windows.Forms.Label lblTrabajadores;
        private System.Windows.Forms.NumericUpDown numTrabajadores;
        private System.Windows.Forms.Label lblCostoManoObra;
        private System.Windows.Forms.NumericUpDown numCostoManoObra;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.ComboBox cmbCondiciones;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}