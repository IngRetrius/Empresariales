namespace AgropecuarioCliente.Forms
{
    partial class FormEliminarInsumo
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
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.lblProductoIdValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoValor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCantidadValor = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblUnidadMedidaValor = new System.Windows.Forms.Label();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.lblCostoUnitarioValor = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblCostoTotalValor = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblProveedorValor = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblFechaCompraValor = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblLoteValor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcionValor = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblStockMinimoValor = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblUbicacionValor = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblFechaVencimientoValor = new System.Windows.Forms.Label();
            this.lblStockBajo = new System.Windows.Forms.Label();
            this.lblVencido = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(280, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminar Insumo";
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
            this.groupBoxDatos.Controls.Add(this.lblVencido);
            this.groupBoxDatos.Controls.Add(this.lblStockBajo);
            this.groupBoxDatos.Controls.Add(this.lblId);
            this.groupBoxDatos.Controls.Add(this.lblIdValor);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.lblNombreValor);
            this.groupBoxDatos.Controls.Add(this.lblProductoId);
            this.groupBoxDatos.Controls.Add(this.lblProductoIdValor);
            this.groupBoxDatos.Controls.Add(this.lblTipo);
            this.groupBoxDatos.Controls.Add(this.lblTipoValor);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.lblCantidadValor);
            this.groupBoxDatos.Controls.Add(this.lblUnidadMedida);
            this.groupBoxDatos.Controls.Add(this.lblUnidadMedidaValor);
            this.groupBoxDatos.Controls.Add(this.lblCostoUnitario);
            this.groupBoxDatos.Controls.Add(this.lblCostoUnitarioValor);
            this.groupBoxDatos.Controls.Add(this.lblCostoTotal);
            this.groupBoxDatos.Controls.Add(this.lblCostoTotalValor);
            this.groupBoxDatos.Controls.Add(this.lblProveedor);
            this.groupBoxDatos.Controls.Add(this.lblProveedorValor);
            this.groupBoxDatos.Controls.Add(this.lblFechaCompra);
            this.groupBoxDatos.Controls.Add(this.lblFechaCompraValor);
            this.groupBoxDatos.Controls.Add(this.lblLote);
            this.groupBoxDatos.Controls.Add(this.lblLoteValor);
            this.groupBoxDatos.Controls.Add(this.lblDescripcion);
            this.groupBoxDatos.Controls.Add(this.lblDescripcionValor);
            this.groupBoxDatos.Controls.Add(this.lblStockMinimo);
            this.groupBoxDatos.Controls.Add(this.lblStockMinimoValor);
            this.groupBoxDatos.Controls.Add(this.lblUbicacion);
            this.groupBoxDatos.Controls.Add(this.lblUbicacionValor);
            this.groupBoxDatos.Controls.Add(this.lblFechaVencimiento);
            this.groupBoxDatos.Controls.Add(this.lblFechaVencimientoValor);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 130);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(740, 480);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Insumo a Eliminar";
            //
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblId.Location = new System.Drawing.Point(30, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            //
            // lblIdValor
            //
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdValor.Location = new System.Drawing.Point(200, 40);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(24, 18);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "--";
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombre.Location = new System.Drawing.Point(30, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            //
            // lblNombreValor
            //
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreValor.Location = new System.Drawing.Point(200, 75);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(24, 18);
            this.lblNombreValor.TabIndex = 3;
            this.lblNombreValor.Text = "--";
            //
            // lblProductoId
            //
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoId.Location = new System.Drawing.Point(30, 110);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(90, 18);
            this.lblProductoId.TabIndex = 4;
            this.lblProductoId.Text = "Producto ID:";
            //
            // lblProductoIdValor
            //
            this.lblProductoIdValor.AutoSize = true;
            this.lblProductoIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProductoIdValor.Location = new System.Drawing.Point(200, 110);
            this.lblProductoIdValor.Name = "lblProductoIdValor";
            this.lblProductoIdValor.Size = new System.Drawing.Size(24, 18);
            this.lblProductoIdValor.TabIndex = 5;
            this.lblProductoIdValor.Text = "--";
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipo.Location = new System.Drawing.Point(30, 145);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(42, 18);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            //
            // lblTipoValor
            //
            this.lblTipoValor.AutoSize = true;
            this.lblTipoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoValor.Location = new System.Drawing.Point(200, 145);
            this.lblTipoValor.Name = "lblTipoValor";
            this.lblTipoValor.Size = new System.Drawing.Size(24, 18);
            this.lblTipoValor.TabIndex = 7;
            this.lblTipoValor.Text = "--";
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(30, 180);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 18);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            //
            // lblCantidadValor
            //
            this.lblCantidadValor.AutoSize = true;
            this.lblCantidadValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidadValor.Location = new System.Drawing.Point(200, 180);
            this.lblCantidadValor.Name = "lblCantidadValor";
            this.lblCantidadValor.Size = new System.Drawing.Size(24, 18);
            this.lblCantidadValor.TabIndex = 9;
            this.lblCantidadValor.Text = "--";
            //
            // lblUnidadMedida
            //
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUnidadMedida.Location = new System.Drawing.Point(30, 215);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(131, 18);
            this.lblUnidadMedida.TabIndex = 10;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            //
            // lblUnidadMedidaValor
            //
            this.lblUnidadMedidaValor.AutoSize = true;
            this.lblUnidadMedidaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnidadMedidaValor.Location = new System.Drawing.Point(200, 215);
            this.lblUnidadMedidaValor.Name = "lblUnidadMedidaValor";
            this.lblUnidadMedidaValor.Size = new System.Drawing.Size(24, 18);
            this.lblUnidadMedidaValor.TabIndex = 11;
            this.lblUnidadMedidaValor.Text = "--";
            //
            // lblCostoUnitario
            //
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoUnitario.Location = new System.Drawing.Point(30, 250);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(110, 18);
            this.lblCostoUnitario.TabIndex = 12;
            this.lblCostoUnitario.Text = "Costo Unitario:";
            //
            // lblCostoUnitarioValor
            //
            this.lblCostoUnitarioValor.AutoSize = true;
            this.lblCostoUnitarioValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostoUnitarioValor.Location = new System.Drawing.Point(200, 250);
            this.lblCostoUnitarioValor.Name = "lblCostoUnitarioValor";
            this.lblCostoUnitarioValor.Size = new System.Drawing.Size(24, 18);
            this.lblCostoUnitarioValor.TabIndex = 13;
            this.lblCostoUnitarioValor.Text = "--";
            //
            // lblCostoTotal
            //
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoTotal.Location = new System.Drawing.Point(30, 285);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(88, 18);
            this.lblCostoTotal.TabIndex = 14;
            this.lblCostoTotal.Text = "Costo Total:";
            //
            // lblCostoTotalValor
            //
            this.lblCostoTotalValor.AutoSize = true;
            this.lblCostoTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostoTotalValor.Location = new System.Drawing.Point(200, 285);
            this.lblCostoTotalValor.Name = "lblCostoTotalValor";
            this.lblCostoTotalValor.Size = new System.Drawing.Size(24, 18);
            this.lblCostoTotalValor.TabIndex = 15;
            this.lblCostoTotalValor.Text = "--";
            //
            // lblProveedor
            //
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProveedor.Location = new System.Drawing.Point(30, 320);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 18);
            this.lblProveedor.TabIndex = 16;
            this.lblProveedor.Text = "Proveedor:";
            //
            // lblProveedorValor
            //
            this.lblProveedorValor.AutoSize = true;
            this.lblProveedorValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProveedorValor.Location = new System.Drawing.Point(200, 320);
            this.lblProveedorValor.Name = "lblProveedorValor";
            this.lblProveedorValor.Size = new System.Drawing.Size(24, 18);
            this.lblProveedorValor.TabIndex = 17;
            this.lblProveedorValor.Text = "--";
            //
            // lblFechaCompra
            //
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaCompra.Location = new System.Drawing.Point(30, 355);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(119, 18);
            this.lblFechaCompra.TabIndex = 18;
            this.lblFechaCompra.Text = "Fecha de Compra:";
            //
            // lblFechaCompraValor
            //
            this.lblFechaCompraValor.AutoSize = true;
            this.lblFechaCompraValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaCompraValor.Location = new System.Drawing.Point(200, 355);
            this.lblFechaCompraValor.Name = "lblFechaCompraValor";
            this.lblFechaCompraValor.Size = new System.Drawing.Size(24, 18);
            this.lblFechaCompraValor.TabIndex = 19;
            this.lblFechaCompraValor.Text = "--";
            //
            // lblLote
            //
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLote.Location = new System.Drawing.Point(400, 40);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(40, 18);
            this.lblLote.TabIndex = 20;
            this.lblLote.Text = "Lote:";
            //
            // lblLoteValor
            //
            this.lblLoteValor.AutoSize = true;
            this.lblLoteValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoteValor.Location = new System.Drawing.Point(550, 40);
            this.lblLoteValor.Name = "lblLoteValor";
            this.lblLoteValor.Size = new System.Drawing.Size(24, 18);
            this.lblLoteValor.TabIndex = 21;
            this.lblLoteValor.Text = "--";
            //
            // lblDescripcion
            //
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescripcion.Location = new System.Drawing.Point(30, 390);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 18);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción:";
            //
            // lblDescripcionValor
            //
            this.lblDescripcionValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionValor.Location = new System.Drawing.Point(200, 390);
            this.lblDescripcionValor.Name = "lblDescripcionValor";
            this.lblDescripcionValor.Size = new System.Drawing.Size(500, 40);
            this.lblDescripcionValor.TabIndex = 23;
            this.lblDescripcionValor.Text = "--";
            //
            // lblStockMinimo
            //
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStockMinimo.Location = new System.Drawing.Point(400, 75);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(103, 18);
            this.lblStockMinimo.TabIndex = 24;
            this.lblStockMinimo.Text = "Stock Mínimo:";
            //
            // lblStockMinimoValor
            //
            this.lblStockMinimoValor.AutoSize = true;
            this.lblStockMinimoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStockMinimoValor.Location = new System.Drawing.Point(550, 75);
            this.lblStockMinimoValor.Name = "lblStockMinimoValor";
            this.lblStockMinimoValor.Size = new System.Drawing.Size(24, 18);
            this.lblStockMinimoValor.TabIndex = 25;
            this.lblStockMinimoValor.Text = "--";
            //
            // lblUbicacion
            //
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUbicacion.Location = new System.Drawing.Point(400, 110);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(76, 18);
            this.lblUbicacion.TabIndex = 26;
            this.lblUbicacion.Text = "Ubicación:";
            //
            // lblUbicacionValor
            //
            this.lblUbicacionValor.AutoSize = true;
            this.lblUbicacionValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUbicacionValor.Location = new System.Drawing.Point(550, 110);
            this.lblUbicacionValor.Name = "lblUbicacionValor";
            this.lblUbicacionValor.Size = new System.Drawing.Size(24, 18);
            this.lblUbicacionValor.TabIndex = 27;
            this.lblUbicacionValor.Text = "--";
            //
            // lblFechaVencimiento
            //
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaVencimiento.Location = new System.Drawing.Point(400, 145);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(142, 18);
            this.lblFechaVencimiento.TabIndex = 28;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento:";
            //
            // lblFechaVencimientoValor
            //
            this.lblFechaVencimientoValor.AutoSize = true;
            this.lblFechaVencimientoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaVencimientoValor.Location = new System.Drawing.Point(550, 145);
            this.lblFechaVencimientoValor.Name = "lblFechaVencimientoValor";
            this.lblFechaVencimientoValor.Size = new System.Drawing.Size(24, 18);
            this.lblFechaVencimientoValor.TabIndex = 29;
            this.lblFechaVencimientoValor.Text = "--";
            //
            // lblStockBajo
            //
            this.lblStockBajo.AutoSize = true;
            this.lblStockBajo.BackColor = System.Drawing.Color.Orange;
            this.lblStockBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockBajo.ForeColor = System.Drawing.Color.White;
            this.lblStockBajo.Location = new System.Drawing.Point(400, 200);
            this.lblStockBajo.Name = "lblStockBajo";
            this.lblStockBajo.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblStockBajo.Size = new System.Drawing.Size(152, 30);
            this.lblStockBajo.TabIndex = 30;
            this.lblStockBajo.Text = "STOCK BAJO";
            this.lblStockBajo.Visible = false;
            //
            // lblVencido
            //
            this.lblVencido.AutoSize = true;
            this.lblVencido.BackColor = System.Drawing.Color.Red;
            this.lblVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblVencido.ForeColor = System.Drawing.Color.White;
            this.lblVencido.Location = new System.Drawing.Point(400, 245);
            this.lblVencido.Name = "lblVencido";
            this.lblVencido.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblVencido.Size = new System.Drawing.Size(118, 30);
            this.lblVencido.TabIndex = 31;
            this.lblVencido.Text = "VENCIDO";
            this.lblVencido.Visible = false;
            //
            // btnEliminar
            //
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(250, 630);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnCerrar
            //
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(420, 630);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // FormEliminarInsumo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEliminarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Insumo";
            this.Load += new System.EventHandler(this.FormEliminarInsumo_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblProductoId;
        private System.Windows.Forms.Label lblProductoIdValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoValor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadValor;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedidaValor;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.Label lblCostoUnitarioValor;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblCostoTotalValor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblProveedorValor;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.Label lblFechaCompraValor;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblLoteValor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDescripcionValor;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblStockMinimoValor;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblUbicacionValor;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblFechaVencimientoValor;
        private System.Windows.Forms.Label lblStockBajo;
        private System.Windows.Forms.Label lblVencido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
