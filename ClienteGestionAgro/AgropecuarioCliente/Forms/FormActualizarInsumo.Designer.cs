namespace AgropecuarioCliente.Forms
{
    partial class FormActualizarInsumo
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoInsumo = new System.Windows.Forms.Label();
            this.cmbTipoInsumo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.numCostoUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.chkTieneFechaVencimiento = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(280, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Actualizar Insumo";
            //
            // btnBuscar
            //
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(310, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Insumo por ID";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // groupBoxDatos
            //
            this.groupBoxDatos.Controls.Add(this.lblId);
            this.groupBoxDatos.Controls.Add(this.lblIdValor);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.lblProducto);
            this.groupBoxDatos.Controls.Add(this.cmbProducto);
            this.groupBoxDatos.Controls.Add(this.lblTipoInsumo);
            this.groupBoxDatos.Controls.Add(this.cmbTipoInsumo);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.numCantidad);
            this.groupBoxDatos.Controls.Add(this.lblUnidadMedida);
            this.groupBoxDatos.Controls.Add(this.cmbUnidadMedida);
            this.groupBoxDatos.Controls.Add(this.lblCostoUnitario);
            this.groupBoxDatos.Controls.Add(this.numCostoUnitario);
            this.groupBoxDatos.Controls.Add(this.lblProveedor);
            this.groupBoxDatos.Controls.Add(this.txtProveedor);
            this.groupBoxDatos.Controls.Add(this.lblFechaCompra);
            this.groupBoxDatos.Controls.Add(this.dtpFechaCompra);
            this.groupBoxDatos.Controls.Add(this.lblLote);
            this.groupBoxDatos.Controls.Add(this.txtLote);
            this.groupBoxDatos.Controls.Add(this.lblDescripcion);
            this.groupBoxDatos.Controls.Add(this.txtDescripcion);
            this.groupBoxDatos.Controls.Add(this.lblStockMinimo);
            this.groupBoxDatos.Controls.Add(this.numStockMinimo);
            this.groupBoxDatos.Controls.Add(this.lblUbicacion);
            this.groupBoxDatos.Controls.Add(this.txtUbicacion);
            this.groupBoxDatos.Controls.Add(this.chkTieneFechaVencimiento);
            this.groupBoxDatos.Controls.Add(this.dtpFechaVencimiento);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 130);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(740, 480);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Insumo";
            //
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblId.Location = new System.Drawing.Point(30, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            //
            // lblIdValor
            //
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdValor.Location = new System.Drawing.Point(100, 35);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(24, 18);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "--";
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombre.Location = new System.Drawing.Point(150, 67);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 24);
            this.txtNombre.TabIndex = 3;
            //
            // lblProducto
            //
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProducto.Location = new System.Drawing.Point(30, 110);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(71, 18);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto:";
            //
            // cmbProducto
            //
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(150, 107);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(250, 26);
            this.cmbProducto.TabIndex = 5;
            //
            // lblTipoInsumo
            //
            this.lblTipoInsumo.AutoSize = true;
            this.lblTipoInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoInsumo.Location = new System.Drawing.Point(30, 150);
            this.lblTipoInsumo.Name = "lblTipoInsumo";
            this.lblTipoInsumo.Size = new System.Drawing.Size(110, 18);
            this.lblTipoInsumo.TabIndex = 6;
            this.lblTipoInsumo.Text = "Tipo de Insumo:";
            //
            // cmbTipoInsumo
            //
            this.cmbTipoInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoInsumo.FormattingEnabled = true;
            this.cmbTipoInsumo.Location = new System.Drawing.Point(150, 147);
            this.cmbTipoInsumo.Name = "cmbTipoInsumo";
            this.cmbTipoInsumo.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoInsumo.TabIndex = 7;
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(30, 190);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 18);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            //
            // numCantidad
            //
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCantidad.Location = new System.Drawing.Point(150, 188);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 24);
            this.numCantidad.TabIndex = 9;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.ThousandsSeparator = true;
            //
            // lblUnidadMedida
            //
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUnidadMedida.Location = new System.Drawing.Point(290, 190);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(59, 18);
            this.lblUnidadMedida.TabIndex = 10;
            this.lblUnidadMedida.Text = "Unidad:";
            //
            // cmbUnidadMedida
            //
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(355, 187);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(120, 26);
            this.cmbUnidadMedida.TabIndex = 11;
            //
            // lblCostoUnitario
            //
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoUnitario.Location = new System.Drawing.Point(30, 230);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(110, 18);
            this.lblCostoUnitario.TabIndex = 12;
            this.lblCostoUnitario.Text = "Costo Unitario:";
            //
            // numCostoUnitario
            //
            this.numCostoUnitario.DecimalPlaces = 2;
            this.numCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCostoUnitario.Location = new System.Drawing.Point(150, 228);
            this.numCostoUnitario.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numCostoUnitario.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCostoUnitario.Name = "numCostoUnitario";
            this.numCostoUnitario.Size = new System.Drawing.Size(150, 24);
            this.numCostoUnitario.TabIndex = 13;
            this.numCostoUnitario.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numCostoUnitario.ThousandsSeparator = true;
            //
            // lblProveedor
            //
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProveedor.Location = new System.Drawing.Point(30, 270);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 18);
            this.lblProveedor.TabIndex = 14;
            this.lblProveedor.Text = "Proveedor:";
            //
            // txtProveedor
            //
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProveedor.Location = new System.Drawing.Point(150, 267);
            this.txtProveedor.MaxLength = 100;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(250, 24);
            this.txtProveedor.TabIndex = 15;
            //
            // lblFechaCompra
            //
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaCompra.Location = new System.Drawing.Point(30, 310);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(119, 18);
            this.lblFechaCompra.TabIndex = 16;
            this.lblFechaCompra.Text = "Fecha de Compra:";
            //
            // dtpFechaCompra
            //
            this.dtpFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(150, 307);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(150, 24);
            this.dtpFechaCompra.TabIndex = 17;
            //
            // lblLote
            //
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLote.Location = new System.Drawing.Point(420, 70);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(40, 18);
            this.lblLote.TabIndex = 18;
            this.lblLote.Text = "Lote:";
            //
            // txtLote
            //
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLote.Location = new System.Drawing.Point(480, 67);
            this.txtLote.MaxLength = 50;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(200, 24);
            this.txtLote.TabIndex = 19;
            //
            // lblDescripcion
            //
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescripcion.Location = new System.Drawing.Point(30, 350);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 18);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripción:";
            //
            // txtDescripcion
            //
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(150, 347);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(530, 60);
            this.txtDescripcion.TabIndex = 21;
            //
            // lblStockMinimo
            //
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStockMinimo.Location = new System.Drawing.Point(420, 110);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(103, 18);
            this.lblStockMinimo.TabIndex = 22;
            this.lblStockMinimo.Text = "Stock Mínimo:";
            //
            // numStockMinimo
            //
            this.numStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numStockMinimo.Location = new System.Drawing.Point(530, 108);
            this.numStockMinimo.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(150, 24);
            this.numStockMinimo.TabIndex = 23;
            this.numStockMinimo.ThousandsSeparator = true;
            //
            // lblUbicacion
            //
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUbicacion.Location = new System.Drawing.Point(420, 150);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(76, 18);
            this.lblUbicacion.TabIndex = 24;
            this.lblUbicacion.Text = "Ubicación:";
            //
            // txtUbicacion
            //
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUbicacion.Location = new System.Drawing.Point(530, 147);
            this.txtUbicacion.MaxLength = 100;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(150, 24);
            this.txtUbicacion.TabIndex = 25;
            //
            // chkTieneFechaVencimiento
            //
            this.chkTieneFechaVencimiento.AutoSize = true;
            this.chkTieneFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkTieneFechaVencimiento.Location = new System.Drawing.Point(30, 425);
            this.chkTieneFechaVencimiento.Name = "chkTieneFechaVencimiento";
            this.chkTieneFechaVencimiento.Size = new System.Drawing.Size(190, 22);
            this.chkTieneFechaVencimiento.TabIndex = 26;
            this.chkTieneFechaVencimiento.Text = "Tiene Fecha Vencimiento";
            this.chkTieneFechaVencimiento.UseVisualStyleBackColor = true;
            this.chkTieneFechaVencimiento.CheckedChanged += new System.EventHandler(this.chkTieneFechaVencimiento_CheckedChanged);
            //
            // dtpFechaVencimiento
            //
            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(230, 423);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(150, 24);
            this.dtpFechaVencimiento.TabIndex = 27;
            //
            // btnActualizar
            //
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(150, 630);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // btnCancelarCambios
            //
            this.btnCancelarCambios.BackColor = System.Drawing.Color.LightYellow;
            this.btnCancelarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCambios.Location = new System.Drawing.Point(325, 630);
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
            this.btnCerrar.Location = new System.Drawing.Point(500, 630);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // FormActualizarInsumo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelarCambios);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormActualizarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Insumo";
            this.Load += new System.EventHandler(this.FormActualizarInsumo_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblTipoInsumo;
        private System.Windows.Forms.ComboBox cmbTipoInsumo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.NumericUpDown numCostoUnitario;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.CheckBox chkTieneFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnCerrar;
    }
}
