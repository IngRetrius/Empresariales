namespace AgropecuarioCliente.Forms
{
    partial class FormCrearInsumo
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.SuspendLayout();
            //
            // grpDatos
            //
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblProducto);
            this.grpDatos.Controls.Add(this.cmbProducto);
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.cmbTipoInsumo);
            this.grpDatos.Controls.Add(this.lblCantidad);
            this.grpDatos.Controls.Add(this.numCantidad);
            this.grpDatos.Controls.Add(this.lblUnidadMedida);
            this.grpDatos.Controls.Add(this.cmbUnidadMedida);
            this.grpDatos.Controls.Add(this.lblCostoUnitario);
            this.grpDatos.Controls.Add(this.numCostoUnitario);
            this.grpDatos.Controls.Add(this.lblProveedor);
            this.grpDatos.Controls.Add(this.txtProveedor);
            this.grpDatos.Controls.Add(this.lblFechaCompra);
            this.grpDatos.Controls.Add(this.dtpFechaCompra);
            this.grpDatos.Controls.Add(this.lblLote);
            this.grpDatos.Controls.Add(this.txtLote);
            this.grpDatos.Controls.Add(this.lblDescripcion);
            this.grpDatos.Controls.Add(this.txtDescripcion);
            this.grpDatos.Controls.Add(this.lblStockMinimo);
            this.grpDatos.Controls.Add(this.numStockMinimo);
            this.grpDatos.Controls.Add(this.lblUbicacion);
            this.grpDatos.Controls.Add(this.txtUbicacion);
            this.grpDatos.Controls.Add(this.chkTieneFechaVencimiento);
            this.grpDatos.Controls.Add(this.dtpFechaVencimiento);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(560, 480);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Insumo";
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            this.txtNombre.Location = new System.Drawing.Point(150, 27);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 20);
            this.txtNombre.TabIndex = 1;
            //
            // lblProducto
            //
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(20, 60);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            //
            // cmbProducto
            //
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(150, 57);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(380, 21);
            this.cmbProducto.TabIndex = 3;
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 90);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            //
            // cmbTipoInsumo
            //
            this.cmbTipoInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInsumo.FormattingEnabled = true;
            this.cmbTipoInsumo.Location = new System.Drawing.Point(150, 87);
            this.cmbTipoInsumo.Name = "cmbTipoInsumo";
            this.cmbTipoInsumo.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoInsumo.TabIndex = 5;
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 120);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            //
            // numCantidad
            //
            this.numCantidad.Location = new System.Drawing.Point(150, 118);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 7;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblUnidadMedida
            //
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(290, 120);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(44, 13);
            this.lblUnidadMedida.TabIndex = 8;
            this.lblUnidadMedida.Text = "Unidad:";
            //
            // cmbUnidadMedida
            //
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(350, 117);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(180, 21);
            this.cmbUnidadMedida.TabIndex = 9;
            //
            // lblCostoUnitario
            //
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Location = new System.Drawing.Point(20, 150);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblCostoUnitario.TabIndex = 10;
            this.lblCostoUnitario.Text = "Costo Unitario:";
            //
            // numCostoUnitario
            //
            this.numCostoUnitario.DecimalPlaces = 2;
            this.numCostoUnitario.Location = new System.Drawing.Point(150, 148);
            this.numCostoUnitario.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numCostoUnitario.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCostoUnitario.Name = "numCostoUnitario";
            this.numCostoUnitario.Size = new System.Drawing.Size(120, 20);
            this.numCostoUnitario.TabIndex = 11;
            this.numCostoUnitario.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            //
            // lblProveedor
            //
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(20, 180);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 12;
            this.lblProveedor.Text = "Proveedor:";
            //
            // txtProveedor
            //
            this.txtProveedor.Location = new System.Drawing.Point(150, 177);
            this.txtProveedor.MaxLength = 100;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(380, 20);
            this.txtProveedor.TabIndex = 13;
            //
            // lblFechaCompra
            //
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Location = new System.Drawing.Point(20, 210);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(79, 13);
            this.lblFechaCompra.TabIndex = 14;
            this.lblFechaCompra.Text = "Fecha Compra:";
            //
            // dtpFechaCompra
            //
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(150, 207);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCompra.TabIndex = 15;
            //
            // lblLote
            //
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(20, 240);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(68, 13);
            this.lblLote.TabIndex = 16;
            this.lblLote.Text = "Lote (opc.):";
            //
            // txtLote
            //
            this.txtLote.Location = new System.Drawing.Point(150, 237);
            this.txtLote.MaxLength = 50;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(200, 20);
            this.txtLote.TabIndex = 17;
            //
            // lblDescripcion
            //
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 270);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción (opc.):";
            //
            // txtDescripcion
            //
            this.txtDescripcion.Location = new System.Drawing.Point(150, 267);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(380, 60);
            this.txtDescripcion.TabIndex = 19;
            //
            // lblStockMinimo
            //
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(20, 340);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(105, 13);
            this.lblStockMinimo.TabIndex = 20;
            this.lblStockMinimo.Text = "Stock Mínimo (opc.):";
            //
            // numStockMinimo
            //
            this.numStockMinimo.Location = new System.Drawing.Point(150, 338);
            this.numStockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(120, 20);
            this.numStockMinimo.TabIndex = 21;
            //
            // lblUbicacion
            //
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(20, 370);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(123, 13);
            this.lblUbicacion.TabIndex = 22;
            this.lblUbicacion.Text = "Ubicación Almacén (opc.):";
            //
            // txtUbicacion
            //
            this.txtUbicacion.Location = new System.Drawing.Point(150, 367);
            this.txtUbicacion.MaxLength = 100;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(380, 20);
            this.txtUbicacion.TabIndex = 23;
            //
            // chkTieneFechaVencimiento
            //
            this.chkTieneFechaVencimiento.AutoSize = true;
            this.chkTieneFechaVencimiento.Location = new System.Drawing.Point(23, 405);
            this.chkTieneFechaVencimiento.Name = "chkTieneFechaVencimiento";
            this.chkTieneFechaVencimiento.Size = new System.Drawing.Size(149, 17);
            this.chkTieneFechaVencimiento.TabIndex = 24;
            this.chkTieneFechaVencimiento.Text = "Tiene Fecha Vencimiento";
            this.chkTieneFechaVencimiento.UseVisualStyleBackColor = true;
            this.chkTieneFechaVencimiento.CheckedChanged += new System.EventHandler(this.chkTieneFechaVencimiento_CheckedChanged);
            //
            // dtpFechaVencimiento
            //
            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(150, 430);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 25;
            //
            // btnCrear
            //
            this.btnCrear.BackColor = System.Drawing.Color.LightGreen;
            this.btnCrear.Location = new System.Drawing.Point(12, 505);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(180, 35);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Insumo";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Location = new System.Drawing.Point(202, 505);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 35);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(392, 505);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FormCrearInsumo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 552);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Insumo";
            this.Load += new System.EventHandler(this.FormCrearInsumo_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblTipo;
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
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
