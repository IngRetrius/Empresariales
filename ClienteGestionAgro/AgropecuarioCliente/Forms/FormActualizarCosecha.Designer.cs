namespace AgropecuarioCliente.Forms
{
    partial class FormActualizarCosecha
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
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblProductoValor = new System.Windows.Forms.Label();
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
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
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(200, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Actualizar Cosecha Seleccionada";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.lblInstrucciones);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(30, 60);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(640, 80);
            this.groupBoxBusqueda.TabIndex = 1;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Buscar Cosecha a Actualizar";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInstrucciones.Location = new System.Drawing.Point(20, 25);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(400, 40);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Haga clic en \'Buscar Cosecha\' para seleccionar la cosecha que desea actualizar.";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(450, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Cosecha";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.groupBoxDatos.Controls.Add(this.lblProductoValor);
            this.groupBoxDatos.Controls.Add(this.lblProducto);
            this.groupBoxDatos.Controls.Add(this.lblIdValor);
            this.groupBoxDatos.Controls.Add(this.lblId);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 160);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(640, 460);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos de la Cosecha";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(20, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Cosecha:";
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdValor.Location = new System.Drawing.Point(110, 25);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(20, 15);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "--";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(20, 50);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(67, 15);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // lblProductoValor
            // 
            this.lblProductoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductoValor.Location = new System.Drawing.Point(110, 50);
            this.lblProductoValor.Name = "lblProductoValor";
            this.lblProductoValor.Size = new System.Drawing.Size(500, 20);
            this.lblProductoValor.TabIndex = 3;
            this.lblProductoValor.Text = "--";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFecha.Location = new System.Drawing.Point(20, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de Cosecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(20, 105);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 21);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(200, 85);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(135, 15);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad Recolectada (kg):";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCantidad.Location = new System.Drawing.Point(200, 105);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 21);
            this.numCantidad.TabIndex = 7;
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCalidad.Location = new System.Drawing.Point(350, 85);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(118, 15);
            this.lblCalidad.TabIndex = 8;
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
            this.cmbCalidad.TabIndex = 9;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTrabajadores.Location = new System.Drawing.Point(20, 145);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(135, 15);
            this.lblTrabajadores.TabIndex = 10;
            this.lblTrabajadores.Text = "Número de Trabajadores:";
            // 
            // numTrabajadores
            // 
            this.numTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numTrabajadores.Location = new System.Drawing.Point(20, 165);
            this.numTrabajadores.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numTrabajadores.Name = "numTrabajadores";
            this.numTrabajadores.Size = new System.Drawing.Size(120, 21);
            this.numTrabajadores.TabIndex = 11;
            // 
            // lblCostoManoObra
            // 
            this.lblCostoManoObra.AutoSize = true;
            this.lblCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoManoObra.Location = new System.Drawing.Point(200, 145);
            this.lblCostoManoObra.Name = "lblCostoManoObra";
            this.lblCostoManoObra.Size = new System.Drawing.Size(141, 15);
            this.lblCostoManoObra.TabIndex = 12;
            this.lblCostoManoObra.Text = "Costo de Mano de Obra ($):";
            // 
            // numCostoManoObra
            // 
            this.numCostoManoObra.DecimalPlaces = 2;
            this.numCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCostoManoObra.Location = new System.Drawing.Point(200, 165);
            this.numCostoManoObra.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numCostoManoObra.Name = "numCostoManoObra";
            this.numCostoManoObra.Size = new System.Drawing.Size(150, 21);
            this.numCostoManoObra.TabIndex = 13;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCondiciones.Location = new System.Drawing.Point(20, 205);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(138, 15);
            this.lblCondiciones.TabIndex = 14;
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
            this.cmbCondiciones.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEstado.Location = new System.Drawing.Point(250, 205);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(119, 15);
            this.lblEstado.TabIndex = 16;
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
            this.cmbEstado.TabIndex = 17;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblObservaciones.Location = new System.Drawing.Point(20, 265);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(88, 15);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtObservaciones.Location = new System.Drawing.Point(20, 285);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(590, 155);
            this.txtObservaciones.TabIndex = 19;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(200, 640);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.BackColor = System.Drawing.Color.LightYellow;
            this.btnCancelarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCambios.Location = new System.Drawing.Point(340, 640);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarCambios.TabIndex = 4;
            this.btnCancelarCambios.Text = "Cancelar Cambios";
            this.btnCancelarCambios.UseVisualStyleBackColor = false;
            this.btnCancelarCambios.Click += new System.EventHandler(this.btnCancelarCambios_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(510, 640);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormActualizarCosecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelarCambios);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActualizarCosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Cosecha - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormActualizarCosecha_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoManoObra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProductoValor;
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
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnCerrar;
    }
}