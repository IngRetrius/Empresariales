namespace AgropecuarioCliente.Forms
{
    partial class FormActualizarProducto
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
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtCodigoFinca = new System.Windows.Forms.TextBox();
            this.lblCodigoFinca = new System.Windows.Forms.Label();
            this.cmbTipoSuelo = new System.Windows.Forms.ComboBox();
            this.lblTipoSuelo = new System.Windows.Forms.Label();
            this.cmbTemporada = new System.Windows.Forms.ComboBox();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.lblCosto = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numHectareas = new System.Windows.Forms.NumericUpDown();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.cmbTipoCultivo = new System.Windows.Forms.ComboBox();
            this.lblTipoCultivo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(200, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Actualizar Producto Agrícola";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.lblInstrucciones);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(30, 70);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(640, 80);
            this.groupBoxBusqueda.TabIndex = 1;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Buscar Producto a Actualizar";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInstrucciones.Location = new System.Drawing.Point(20, 30);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(400, 35);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Haga clic en 'Buscar Producto' para seleccionar el producto que desea actualizar.";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(450, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Producto";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.lblIdValor);
            this.groupBoxDatos.Controls.Add(this.lblIdProducto);
            this.groupBoxDatos.Controls.Add(this.txtCodigoFinca);
            this.groupBoxDatos.Controls.Add(this.lblCodigoFinca);
            this.groupBoxDatos.Controls.Add(this.cmbTipoSuelo);
            this.groupBoxDatos.Controls.Add(this.lblTipoSuelo);
            this.groupBoxDatos.Controls.Add(this.cmbTemporada);
            this.groupBoxDatos.Controls.Add(this.lblTemporada);
            this.groupBoxDatos.Controls.Add(this.numCosto);
            this.groupBoxDatos.Controls.Add(this.lblCosto);
            this.groupBoxDatos.Controls.Add(this.numPrecio);
            this.groupBoxDatos.Controls.Add(this.lblPrecio);
            this.groupBoxDatos.Controls.Add(this.numCantidad);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.numHectareas);
            this.groupBoxDatos.Controls.Add(this.lblHectareas);
            this.groupBoxDatos.Controls.Add(this.cmbTipoCultivo);
            this.groupBoxDatos.Controls.Add(this.lblTipoCultivo);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 170);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(640, 380);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Producto";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProducto.Location = new System.Drawing.Point(30, 30);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(99, 18);
            this.lblIdProducto.TabIndex = 0;
            this.lblIdProducto.Text = "ID Producto:";
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdValor.Location = new System.Drawing.Point(140, 30);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(20, 18);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "--";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombre.Location = new System.Drawing.Point(30, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblTipoCultivo
            // 
            this.lblTipoCultivo.AutoSize = true;
            this.lblTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoCultivo.Location = new System.Drawing.Point(330, 70);
            this.lblTipoCultivo.Name = "lblTipoCultivo";
            this.lblTipoCultivo.Size = new System.Drawing.Size(104, 18);
            this.lblTipoCultivo.TabIndex = 4;
            this.lblTipoCultivo.Text = "Tipo de Cultivo:";
            // 
            // cmbTipoCultivo
            // 
            this.cmbTipoCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoCultivo.FormattingEnabled = true;
            this.cmbTipoCultivo.Location = new System.Drawing.Point(330, 90);
            this.cmbTipoCultivo.Name = "cmbTipoCultivo";
            this.cmbTipoCultivo.Size = new System.Drawing.Size(180, 26);
            this.cmbTipoCultivo.TabIndex = 5;
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareas.Location = new System.Drawing.Point(30, 140);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(151, 18);
            this.lblHectareas.TabIndex = 6;
            this.lblHectareas.Text = "Hectáreas Cultivadas:";
            // 
            // numHectareas
            // 
            this.numHectareas.DecimalPlaces = 2;
            this.numHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numHectareas.Location = new System.Drawing.Point(30, 160);
            this.numHectareas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHectareas.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numHectareas.Name = "numHectareas";
            this.numHectareas.Size = new System.Drawing.Size(120, 24);
            this.numHectareas.TabIndex = 7;
            this.numHectareas.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(200, 140);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(148, 18);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad Producida:";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCantidad.Location = new System.Drawing.Point(200, 160);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 24);
            this.numCantidad.TabIndex = 9;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrecio.Location = new System.Drawing.Point(390, 140);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(120, 18);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio de Venta:";
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numPrecio.Location = new System.Drawing.Point(390, 160);
            this.numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numPrecio.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 24);
            this.numPrecio.TabIndex = 11;
            this.numPrecio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCosto.Location = new System.Drawing.Point(30, 210);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(145, 18);
            this.lblCosto.TabIndex = 12;
            this.lblCosto.Text = "Costo de Producción:";
            // 
            // numCosto
            // 
            this.numCosto.DecimalPlaces = 2;
            this.numCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCosto.Location = new System.Drawing.Point(30, 230);
            this.numCosto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numCosto.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(150, 24);
            this.numCosto.TabIndex = 13;
            this.numCosto.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTemporada.Location = new System.Drawing.Point(230, 210);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(85, 18);
            this.lblTemporada.TabIndex = 14;
            this.lblTemporada.Text = "Temporada:";
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Location = new System.Drawing.Point(230, 230);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(180, 26);
            this.cmbTemporada.TabIndex = 15;
            // 
            // lblTipoSuelo
            // 
            this.lblTipoSuelo.AutoSize = true;
            this.lblTipoSuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoSuelo.Location = new System.Drawing.Point(450, 210);
            this.lblTipoSuelo.Name = "lblTipoSuelo";
            this.lblTipoSuelo.Size = new System.Drawing.Size(102, 18);
            this.lblTipoSuelo.TabIndex = 16;
            this.lblTipoSuelo.Text = "Tipo de Suelo:";
            // 
            // cmbTipoSuelo
            // 
            this.cmbTipoSuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoSuelo.FormattingEnabled = true;
            this.cmbTipoSuelo.Location = new System.Drawing.Point(450, 230);
            this.cmbTipoSuelo.Name = "cmbTipoSuelo";
            this.cmbTipoSuelo.Size = new System.Drawing.Size(150, 26);
            this.cmbTipoSuelo.TabIndex = 17;
            // 
            // lblCodigoFinca
            // 
            this.lblCodigoFinca.AutoSize = true;
            this.lblCodigoFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCodigoFinca.Location = new System.Drawing.Point(30, 280);
            this.lblCodigoFinca.Name = "lblCodigoFinca";
            this.lblCodigoFinca.Size = new System.Drawing.Size(130, 18);
            this.lblCodigoFinca.TabIndex = 18;
            this.lblCodigoFinca.Text = "Código de Finca:";
            // 
            // txtCodigoFinca
            // 
            this.txtCodigoFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCodigoFinca.Location = new System.Drawing.Point(30, 300);
            this.txtCodigoFinca.Name = "txtCodigoFinca";
            this.txtCodigoFinca.Size = new System.Drawing.Size(150, 24);
            this.txtCodigoFinca.TabIndex = 19;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(200, 570);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.BackColor = System.Drawing.Color.LightYellow;
            this.btnCancelarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCambios.Location = new System.Drawing.Point(340, 570);
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
            this.btnCerrar.Location = new System.Drawing.Point(510, 570);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 630);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelarCambios);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActualizarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Producto - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormActualizarProducto_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoCultivo;
        private System.Windows.Forms.ComboBox cmbTipoCultivo;
        private System.Windows.Forms.Label lblHectareas;
        private System.Windows.Forms.NumericUpDown numHectareas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox cmbTemporada;
        private System.Windows.Forms.Label lblTipoSuelo;
        private System.Windows.Forms.ComboBox cmbTipoSuelo;
        private System.Windows.Forms.Label lblCodigoFinca;
        private System.Windows.Forms.TextBox txtCodigoFinca;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnCerrar;
    }
}