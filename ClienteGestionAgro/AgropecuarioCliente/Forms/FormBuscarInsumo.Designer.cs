namespace AgropecuarioCliente.Forms
{
    partial class FormBuscarInsumo
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
            this.rbPorId = new System.Windows.Forms.RadioButton();
            this.rbPorNombre = new System.Windows.Forms.RadioButton();
            this.rbPorTipo = new System.Windows.Forms.RadioButton();
            this.rbPorProveedor = new System.Windows.Forms.RadioButton();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbTipoInsumo = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblStockBajo = new System.Windows.Forms.Label();
            this.lblVencido = new System.Windows.Forms.Label();
            this.lblResId = new System.Windows.Forms.Label();
            this.txtResultadoId = new System.Windows.Forms.TextBox();
            this.lblResNombre = new System.Windows.Forms.Label();
            this.txtResultadoNombre = new System.Windows.Forms.TextBox();
            this.lblResProductoId = new System.Windows.Forms.Label();
            this.txtResultadoProductoId = new System.Windows.Forms.TextBox();
            this.lblResTipo = new System.Windows.Forms.Label();
            this.txtResultadoTipo = new System.Windows.Forms.TextBox();
            this.lblResCantidad = new System.Windows.Forms.Label();
            this.txtResultadoCantidad = new System.Windows.Forms.TextBox();
            this.lblResUnidadMedida = new System.Windows.Forms.Label();
            this.txtResultadoUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblResCostoUnitario = new System.Windows.Forms.Label();
            this.txtResultadoCostoUnitario = new System.Windows.Forms.TextBox();
            this.lblResCostoTotal = new System.Windows.Forms.Label();
            this.txtResultadoCostoTotal = new System.Windows.Forms.TextBox();
            this.lblResProveedor = new System.Windows.Forms.Label();
            this.txtResultadoProveedor = new System.Windows.Forms.TextBox();
            this.lblResFechaCompra = new System.Windows.Forms.Label();
            this.txtResultadoFechaCompra = new System.Windows.Forms.TextBox();
            this.lblResLote = new System.Windows.Forms.Label();
            this.txtResultadoLote = new System.Windows.Forms.TextBox();
            this.lblResDescripcion = new System.Windows.Forms.Label();
            this.txtResultadoDescripcion = new System.Windows.Forms.TextBox();
            this.lblResStockMinimo = new System.Windows.Forms.Label();
            this.txtResultadoStockMinimo = new System.Windows.Forms.TextBox();
            this.lblResUbicacion = new System.Windows.Forms.Label();
            this.txtResultadoUbicacion = new System.Windows.Forms.TextBox();
            this.lblResFechaVencimiento = new System.Windows.Forms.Label();
            this.txtResultadoFechaVencimiento = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(320, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Buscar Insumos";
            //
            // groupBoxBusqueda
            //
            this.groupBoxBusqueda.Controls.Add(this.btnLimpiar);
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.txtProveedor);
            this.groupBoxBusqueda.Controls.Add(this.cmbTipoInsumo);
            this.groupBoxBusqueda.Controls.Add(this.txtBusqueda);
            this.groupBoxBusqueda.Controls.Add(this.lblCriterio);
            this.groupBoxBusqueda.Controls.Add(this.rbPorProveedor);
            this.groupBoxBusqueda.Controls.Add(this.rbPorTipo);
            this.groupBoxBusqueda.Controls.Add(this.rbPorNombre);
            this.groupBoxBusqueda.Controls.Add(this.rbPorId);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(30, 70);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(740, 150);
            this.groupBoxBusqueda.TabIndex = 1;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Criterios de Búsqueda";
            //
            // rbPorId
            //
            this.rbPorId.AutoSize = true;
            this.rbPorId.Checked = true;
            this.rbPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorId.Location = new System.Drawing.Point(30, 30);
            this.rbPorId.Name = "rbPorId";
            this.rbPorId.Size = new System.Drawing.Size(71, 22);
            this.rbPorId.TabIndex = 0;
            this.rbPorId.TabStop = true;
            this.rbPorId.Text = "Por ID";
            this.rbPorId.UseVisualStyleBackColor = true;
            this.rbPorId.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            //
            // rbPorNombre
            //
            this.rbPorNombre.AutoSize = true;
            this.rbPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorNombre.Location = new System.Drawing.Point(150, 30);
            this.rbPorNombre.Name = "rbPorNombre";
            this.rbPorNombre.Size = new System.Drawing.Size(107, 22);
            this.rbPorNombre.TabIndex = 1;
            this.rbPorNombre.Text = "Por Nombre";
            this.rbPorNombre.UseVisualStyleBackColor = true;
            this.rbPorNombre.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            //
            // rbPorTipo
            //
            this.rbPorTipo.AutoSize = true;
            this.rbPorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorTipo.Location = new System.Drawing.Point(300, 30);
            this.rbPorTipo.Name = "rbPorTipo";
            this.rbPorTipo.Size = new System.Drawing.Size(85, 22);
            this.rbPorTipo.TabIndex = 2;
            this.rbPorTipo.Text = "Por Tipo";
            this.rbPorTipo.UseVisualStyleBackColor = true;
            this.rbPorTipo.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            //
            // rbPorProveedor
            //
            this.rbPorProveedor.AutoSize = true;
            this.rbPorProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorProveedor.Location = new System.Drawing.Point(440, 30);
            this.rbPorProveedor.Name = "rbPorProveedor";
            this.rbPorProveedor.Size = new System.Drawing.Size(128, 22);
            this.rbPorProveedor.TabIndex = 3;
            this.rbPorProveedor.Text = "Por Proveedor";
            this.rbPorProveedor.UseVisualStyleBackColor = true;
            this.rbPorProveedor.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            //
            // lblCriterio
            //
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCriterio.Location = new System.Drawing.Point(30, 65);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(127, 18);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Ingrese el valor:";
            //
            // txtBusqueda
            //
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBusqueda.Location = new System.Drawing.Point(30, 85);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(250, 24);
            this.txtBusqueda.TabIndex = 5;
            //
            // cmbTipoInsumo
            //
            this.cmbTipoInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoInsumo.FormattingEnabled = true;
            this.cmbTipoInsumo.Location = new System.Drawing.Point(30, 85);
            this.cmbTipoInsumo.Name = "cmbTipoInsumo";
            this.cmbTipoInsumo.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoInsumo.TabIndex = 6;
            this.cmbTipoInsumo.Visible = false;
            //
            // txtProveedor
            //
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtProveedor.Location = new System.Drawing.Point(30, 85);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(250, 24);
            this.txtProveedor.TabIndex = 7;
            this.txtProveedor.Visible = false;
            //
            // btnBuscar
            //
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBuscar.Location = new System.Drawing.Point(350, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLimpiar.Location = new System.Drawing.Point(490, 80);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 32);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // groupBoxResultados
            //
            this.groupBoxResultados.Controls.Add(this.txtResultadoFechaVencimiento);
            this.groupBoxResultados.Controls.Add(this.lblResFechaVencimiento);
            this.groupBoxResultados.Controls.Add(this.txtResultadoUbicacion);
            this.groupBoxResultados.Controls.Add(this.lblResUbicacion);
            this.groupBoxResultados.Controls.Add(this.txtResultadoStockMinimo);
            this.groupBoxResultados.Controls.Add(this.lblResStockMinimo);
            this.groupBoxResultados.Controls.Add(this.txtResultadoDescripcion);
            this.groupBoxResultados.Controls.Add(this.lblResDescripcion);
            this.groupBoxResultados.Controls.Add(this.txtResultadoLote);
            this.groupBoxResultados.Controls.Add(this.lblResLote);
            this.groupBoxResultados.Controls.Add(this.txtResultadoFechaCompra);
            this.groupBoxResultados.Controls.Add(this.lblResFechaCompra);
            this.groupBoxResultados.Controls.Add(this.txtResultadoProveedor);
            this.groupBoxResultados.Controls.Add(this.lblResProveedor);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCostoTotal);
            this.groupBoxResultados.Controls.Add(this.lblResCostoTotal);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCostoUnitario);
            this.groupBoxResultados.Controls.Add(this.lblResCostoUnitario);
            this.groupBoxResultados.Controls.Add(this.txtResultadoUnidadMedida);
            this.groupBoxResultados.Controls.Add(this.lblResUnidadMedida);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCantidad);
            this.groupBoxResultados.Controls.Add(this.lblResCantidad);
            this.groupBoxResultados.Controls.Add(this.txtResultadoTipo);
            this.groupBoxResultados.Controls.Add(this.lblResTipo);
            this.groupBoxResultados.Controls.Add(this.txtResultadoProductoId);
            this.groupBoxResultados.Controls.Add(this.lblResProductoId);
            this.groupBoxResultados.Controls.Add(this.txtResultadoNombre);
            this.groupBoxResultados.Controls.Add(this.lblResNombre);
            this.groupBoxResultados.Controls.Add(this.txtResultadoId);
            this.groupBoxResultados.Controls.Add(this.lblResId);
            this.groupBoxResultados.Controls.Add(this.lblVencido);
            this.groupBoxResultados.Controls.Add(this.lblStockBajo);
            this.groupBoxResultados.Controls.Add(this.lblResultados);
            this.groupBoxResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxResultados.Location = new System.Drawing.Point(30, 235);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(740, 420);
            this.groupBoxResultados.TabIndex = 2;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            //
            // lblResultados
            //
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultados.ForeColor = System.Drawing.Color.Blue;
            this.lblResultados.Location = new System.Drawing.Point(20, 25);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 18);
            this.lblResultados.TabIndex = 0;
            //
            // lblStockBajo
            //
            this.lblStockBajo.AutoSize = true;
            this.lblStockBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStockBajo.ForeColor = System.Drawing.Color.Orange;
            this.lblStockBajo.Location = new System.Drawing.Point(400, 25);
            this.lblStockBajo.Name = "lblStockBajo";
            this.lblStockBajo.Size = new System.Drawing.Size(120, 18);
            this.lblStockBajo.TabIndex = 1;
            this.lblStockBajo.Text = "STOCK BAJO";
            this.lblStockBajo.Visible = false;
            //
            // lblVencido
            //
            this.lblVencido.AutoSize = true;
            this.lblVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVencido.ForeColor = System.Drawing.Color.Red;
            this.lblVencido.Location = new System.Drawing.Point(550, 25);
            this.lblVencido.Name = "lblVencido";
            this.lblVencido.Size = new System.Drawing.Size(85, 18);
            this.lblVencido.TabIndex = 2;
            this.lblVencido.Text = "VENCIDO";
            this.lblVencido.Visible = false;
            //
            // lblResId
            //
            this.lblResId.AutoSize = true;
            this.lblResId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResId.Location = new System.Drawing.Point(20, 55);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(26, 18);
            this.lblResId.TabIndex = 3;
            this.lblResId.Text = "ID:";
            //
            // txtResultadoId
            //
            this.txtResultadoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoId.Location = new System.Drawing.Point(180, 52);
            this.txtResultadoId.Name = "txtResultadoId";
            this.txtResultadoId.ReadOnly = true;
            this.txtResultadoId.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoId.TabIndex = 4;
            //
            // lblResNombre
            //
            this.lblResNombre.AutoSize = true;
            this.lblResNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResNombre.Location = new System.Drawing.Point(20, 85);
            this.lblResNombre.Name = "lblResNombre";
            this.lblResNombre.Size = new System.Drawing.Size(67, 18);
            this.lblResNombre.TabIndex = 5;
            this.lblResNombre.Text = "Nombre:";
            //
            // txtResultadoNombre
            //
            this.txtResultadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoNombre.Location = new System.Drawing.Point(180, 82);
            this.txtResultadoNombre.Name = "txtResultadoNombre";
            this.txtResultadoNombre.ReadOnly = true;
            this.txtResultadoNombre.Size = new System.Drawing.Size(520, 24);
            this.txtResultadoNombre.TabIndex = 6;
            //
            // lblResProductoId
            //
            this.lblResProductoId.AutoSize = true;
            this.lblResProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResProductoId.Location = new System.Drawing.Point(20, 115);
            this.lblResProductoId.Name = "lblResProductoId";
            this.lblResProductoId.Size = new System.Drawing.Size(90, 18);
            this.lblResProductoId.TabIndex = 7;
            this.lblResProductoId.Text = "Producto ID:";
            //
            // txtResultadoProductoId
            //
            this.txtResultadoProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoProductoId.Location = new System.Drawing.Point(180, 112);
            this.txtResultadoProductoId.Name = "txtResultadoProductoId";
            this.txtResultadoProductoId.ReadOnly = true;
            this.txtResultadoProductoId.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoProductoId.TabIndex = 8;
            //
            // lblResTipo
            //
            this.lblResTipo.AutoSize = true;
            this.lblResTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResTipo.Location = new System.Drawing.Point(20, 145);
            this.lblResTipo.Name = "lblResTipo";
            this.lblResTipo.Size = new System.Drawing.Size(42, 18);
            this.lblResTipo.TabIndex = 9;
            this.lblResTipo.Text = "Tipo:";
            //
            // txtResultadoTipo
            //
            this.txtResultadoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoTipo.Location = new System.Drawing.Point(180, 142);
            this.txtResultadoTipo.Name = "txtResultadoTipo";
            this.txtResultadoTipo.ReadOnly = true;
            this.txtResultadoTipo.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoTipo.TabIndex = 10;
            //
            // lblResCantidad
            //
            this.lblResCantidad.AutoSize = true;
            this.lblResCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResCantidad.Location = new System.Drawing.Point(20, 175);
            this.lblResCantidad.Name = "lblResCantidad";
            this.lblResCantidad.Size = new System.Drawing.Size(72, 18);
            this.lblResCantidad.TabIndex = 11;
            this.lblResCantidad.Text = "Cantidad:";
            //
            // txtResultadoCantidad
            //
            this.txtResultadoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCantidad.Location = new System.Drawing.Point(180, 172);
            this.txtResultadoCantidad.Name = "txtResultadoCantidad";
            this.txtResultadoCantidad.ReadOnly = true;
            this.txtResultadoCantidad.Size = new System.Drawing.Size(150, 24);
            this.txtResultadoCantidad.TabIndex = 12;
            //
            // lblResUnidadMedida
            //
            this.lblResUnidadMedida.AutoSize = true;
            this.lblResUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResUnidadMedida.Location = new System.Drawing.Point(410, 175);
            this.lblResUnidadMedida.Name = "lblResUnidadMedida";
            this.lblResUnidadMedida.Size = new System.Drawing.Size(59, 18);
            this.lblResUnidadMedida.TabIndex = 13;
            this.lblResUnidadMedida.Text = "Unidad:";
            //
            // txtResultadoUnidadMedida
            //
            this.txtResultadoUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoUnidadMedida.Location = new System.Drawing.Point(500, 172);
            this.txtResultadoUnidadMedida.Name = "txtResultadoUnidadMedida";
            this.txtResultadoUnidadMedida.ReadOnly = true;
            this.txtResultadoUnidadMedida.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoUnidadMedida.TabIndex = 14;
            //
            // lblResCostoUnitario
            //
            this.lblResCostoUnitario.AutoSize = true;
            this.lblResCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResCostoUnitario.Location = new System.Drawing.Point(20, 205);
            this.lblResCostoUnitario.Name = "lblResCostoUnitario";
            this.lblResCostoUnitario.Size = new System.Drawing.Size(110, 18);
            this.lblResCostoUnitario.TabIndex = 15;
            this.lblResCostoUnitario.Text = "Costo Unitario:";
            //
            // txtResultadoCostoUnitario
            //
            this.txtResultadoCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCostoUnitario.Location = new System.Drawing.Point(180, 202);
            this.txtResultadoCostoUnitario.Name = "txtResultadoCostoUnitario";
            this.txtResultadoCostoUnitario.ReadOnly = true;
            this.txtResultadoCostoUnitario.Size = new System.Drawing.Size(150, 24);
            this.txtResultadoCostoUnitario.TabIndex = 16;
            //
            // lblResCostoTotal
            //
            this.lblResCostoTotal.AutoSize = true;
            this.lblResCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResCostoTotal.Location = new System.Drawing.Point(410, 205);
            this.lblResCostoTotal.Name = "lblResCostoTotal";
            this.lblResCostoTotal.Size = new System.Drawing.Size(89, 18);
            this.lblResCostoTotal.TabIndex = 17;
            this.lblResCostoTotal.Text = "Costo Total:";
            //
            // txtResultadoCostoTotal
            //
            this.txtResultadoCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCostoTotal.Location = new System.Drawing.Point(500, 202);
            this.txtResultadoCostoTotal.Name = "txtResultadoCostoTotal";
            this.txtResultadoCostoTotal.ReadOnly = true;
            this.txtResultadoCostoTotal.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoCostoTotal.TabIndex = 18;
            //
            // lblResProveedor
            //
            this.lblResProveedor.AutoSize = true;
            this.lblResProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResProveedor.Location = new System.Drawing.Point(20, 235);
            this.lblResProveedor.Name = "lblResProveedor";
            this.lblResProveedor.Size = new System.Drawing.Size(82, 18);
            this.lblResProveedor.TabIndex = 19;
            this.lblResProveedor.Text = "Proveedor:";
            //
            // txtResultadoProveedor
            //
            this.txtResultadoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoProveedor.Location = new System.Drawing.Point(180, 232);
            this.txtResultadoProveedor.Name = "txtResultadoProveedor";
            this.txtResultadoProveedor.ReadOnly = true;
            this.txtResultadoProveedor.Size = new System.Drawing.Size(520, 24);
            this.txtResultadoProveedor.TabIndex = 20;
            //
            // lblResFechaCompra
            //
            this.lblResFechaCompra.AutoSize = true;
            this.lblResFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResFechaCompra.Location = new System.Drawing.Point(20, 265);
            this.lblResFechaCompra.Name = "lblResFechaCompra";
            this.lblResFechaCompra.Size = new System.Drawing.Size(108, 18);
            this.lblResFechaCompra.TabIndex = 21;
            this.lblResFechaCompra.Text = "Fecha Compra:";
            //
            // txtResultadoFechaCompra
            //
            this.txtResultadoFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoFechaCompra.Location = new System.Drawing.Point(180, 262);
            this.txtResultadoFechaCompra.Name = "txtResultadoFechaCompra";
            this.txtResultadoFechaCompra.ReadOnly = true;
            this.txtResultadoFechaCompra.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoFechaCompra.TabIndex = 22;
            //
            // lblResLote
            //
            this.lblResLote.AutoSize = true;
            this.lblResLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResLote.Location = new System.Drawing.Point(410, 265);
            this.lblResLote.Name = "lblResLote";
            this.lblResLote.Size = new System.Drawing.Size(42, 18);
            this.lblResLote.TabIndex = 23;
            this.lblResLote.Text = "Lote:";
            //
            // txtResultadoLote
            //
            this.txtResultadoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoLote.Location = new System.Drawing.Point(500, 262);
            this.txtResultadoLote.Name = "txtResultadoLote";
            this.txtResultadoLote.ReadOnly = true;
            this.txtResultadoLote.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoLote.TabIndex = 24;
            //
            // lblResDescripcion
            //
            this.lblResDescripcion.AutoSize = true;
            this.lblResDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResDescripcion.Location = new System.Drawing.Point(20, 295);
            this.lblResDescripcion.Name = "lblResDescripcion";
            this.lblResDescripcion.Size = new System.Drawing.Size(94, 18);
            this.lblResDescripcion.TabIndex = 25;
            this.lblResDescripcion.Text = "Descripción:";
            //
            // txtResultadoDescripcion
            //
            this.txtResultadoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoDescripcion.Location = new System.Drawing.Point(180, 292);
            this.txtResultadoDescripcion.Multiline = true;
            this.txtResultadoDescripcion.Name = "txtResultadoDescripcion";
            this.txtResultadoDescripcion.ReadOnly = true;
            this.txtResultadoDescripcion.Size = new System.Drawing.Size(520, 40);
            this.txtResultadoDescripcion.TabIndex = 26;
            //
            // lblResStockMinimo
            //
            this.lblResStockMinimo.AutoSize = true;
            this.lblResStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResStockMinimo.Location = new System.Drawing.Point(20, 345);
            this.lblResStockMinimo.Name = "lblResStockMinimo";
            this.lblResStockMinimo.Size = new System.Drawing.Size(105, 18);
            this.lblResStockMinimo.TabIndex = 27;
            this.lblResStockMinimo.Text = "Stock Mínimo:";
            //
            // txtResultadoStockMinimo
            //
            this.txtResultadoStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoStockMinimo.Location = new System.Drawing.Point(180, 342);
            this.txtResultadoStockMinimo.Name = "txtResultadoStockMinimo";
            this.txtResultadoStockMinimo.ReadOnly = true;
            this.txtResultadoStockMinimo.Size = new System.Drawing.Size(150, 24);
            this.txtResultadoStockMinimo.TabIndex = 28;
            //
            // lblResUbicacion
            //
            this.lblResUbicacion.AutoSize = true;
            this.lblResUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResUbicacion.Location = new System.Drawing.Point(20, 375);
            this.lblResUbicacion.Name = "lblResUbicacion";
            this.lblResUbicacion.Size = new System.Drawing.Size(79, 18);
            this.lblResUbicacion.TabIndex = 29;
            this.lblResUbicacion.Text = "Ubicación:";
            //
            // txtResultadoUbicacion
            //
            this.txtResultadoUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoUbicacion.Location = new System.Drawing.Point(180, 372);
            this.txtResultadoUbicacion.Name = "txtResultadoUbicacion";
            this.txtResultadoUbicacion.ReadOnly = true;
            this.txtResultadoUbicacion.Size = new System.Drawing.Size(520, 24);
            this.txtResultadoUbicacion.TabIndex = 30;
            //
            // lblResFechaVencimiento
            //
            this.lblResFechaVencimiento.AutoSize = true;
            this.lblResFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResFechaVencimiento.Location = new System.Drawing.Point(410, 345);
            this.lblResFechaVencimiento.Name = "lblResFechaVencimiento";
            this.lblResFechaVencimiento.Size = new System.Drawing.Size(79, 18);
            this.lblResFechaVencimiento.TabIndex = 31;
            this.lblResFechaVencimiento.Text = "Vence:";
            //
            // txtResultadoFechaVencimiento
            //
            this.txtResultadoFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoFechaVencimiento.Location = new System.Drawing.Point(500, 342);
            this.txtResultadoFechaVencimiento.Name = "txtResultadoFechaVencimiento";
            this.txtResultadoFechaVencimiento.ReadOnly = true;
            this.txtResultadoFechaVencimiento.Size = new System.Drawing.Size(200, 24);
            this.txtResultadoFechaVencimiento.TabIndex = 32;
            //
            // btnCerrar
            //
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(330, 670);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // FormBuscarInsumo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Insumo";
            this.Load += new System.EventHandler(this.FormBuscarInsumo_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.RadioButton rbPorId;
        private System.Windows.Forms.RadioButton rbPorNombre;
        private System.Windows.Forms.RadioButton rbPorTipo;
        private System.Windows.Forms.RadioButton rbPorProveedor;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbTipoInsumo;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblStockBajo;
        private System.Windows.Forms.Label lblVencido;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.TextBox txtResultadoId;
        private System.Windows.Forms.Label lblResNombre;
        private System.Windows.Forms.TextBox txtResultadoNombre;
        private System.Windows.Forms.Label lblResProductoId;
        private System.Windows.Forms.TextBox txtResultadoProductoId;
        private System.Windows.Forms.Label lblResTipo;
        private System.Windows.Forms.TextBox txtResultadoTipo;
        private System.Windows.Forms.Label lblResCantidad;
        private System.Windows.Forms.TextBox txtResultadoCantidad;
        private System.Windows.Forms.Label lblResUnidadMedida;
        private System.Windows.Forms.TextBox txtResultadoUnidadMedida;
        private System.Windows.Forms.Label lblResCostoUnitario;
        private System.Windows.Forms.TextBox txtResultadoCostoUnitario;
        private System.Windows.Forms.Label lblResCostoTotal;
        private System.Windows.Forms.TextBox txtResultadoCostoTotal;
        private System.Windows.Forms.Label lblResProveedor;
        private System.Windows.Forms.TextBox txtResultadoProveedor;
        private System.Windows.Forms.Label lblResFechaCompra;
        private System.Windows.Forms.TextBox txtResultadoFechaCompra;
        private System.Windows.Forms.Label lblResLote;
        private System.Windows.Forms.TextBox txtResultadoLote;
        private System.Windows.Forms.Label lblResDescripcion;
        private System.Windows.Forms.TextBox txtResultadoDescripcion;
        private System.Windows.Forms.Label lblResStockMinimo;
        private System.Windows.Forms.TextBox txtResultadoStockMinimo;
        private System.Windows.Forms.Label lblResUbicacion;
        private System.Windows.Forms.TextBox txtResultadoUbicacion;
        private System.Windows.Forms.Label lblResFechaVencimiento;
        private System.Windows.Forms.TextBox txtResultadoFechaVencimiento;
        private System.Windows.Forms.Button btnCerrar;
    }
}
