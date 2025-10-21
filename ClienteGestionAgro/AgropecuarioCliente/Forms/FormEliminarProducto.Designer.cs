namespace AgropecuarioCliente.Forms
{
    partial class FormEliminarProducto
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
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoCultivoValor = new System.Windows.Forms.Label();
            this.lblTipoCultivo = new System.Windows.Forms.Label();
            this.lblHectareasValor = new System.Windows.Forms.Label();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.lblCantidadValor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioValor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCostoValor = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblTemporadaValor = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblTipoSueloValor = new System.Windows.Forms.Label();
            this.lblTipoSuelo = new System.Windows.Forms.Label();
            this.lblCodigoFincaValor = new System.Windows.Forms.Label();
            this.lblCodigoFinca = new System.Windows.Forms.Label();
            this.lblFechaProduccionValor = new System.Windows.Forms.Label();
            this.lblFechaProduccion = new System.Windows.Forms.Label();
            this.lblIngresoTotalValor = new System.Windows.Forms.Label();
            this.lblIngresoTotal = new System.Windows.Forms.Label();
            this.lblRendimientoValor = new System.Windows.Forms.Label();
            this.lblRendimiento = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(200, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminar Producto Agrícola";
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
            this.groupBoxBusqueda.Text = "Buscar Producto a Eliminar";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInstrucciones.Location = new System.Drawing.Point(20, 30);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(400, 35);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Haga clic en 'Buscar Producto' para seleccionar el producto que desea eliminar.";
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
            this.groupBoxDatos.Controls.Add(this.lblRendimiento);
            this.groupBoxDatos.Controls.Add(this.lblRendimientoValor);
            this.groupBoxDatos.Controls.Add(this.lblIngresoTotal);
            this.groupBoxDatos.Controls.Add(this.lblIngresoTotalValor);
            this.groupBoxDatos.Controls.Add(this.lblFechaProduccion);
            this.groupBoxDatos.Controls.Add(this.lblFechaProduccionValor);
            this.groupBoxDatos.Controls.Add(this.lblCodigoFinca);
            this.groupBoxDatos.Controls.Add(this.lblCodigoFincaValor);
            this.groupBoxDatos.Controls.Add(this.lblTipoSuelo);
            this.groupBoxDatos.Controls.Add(this.lblTipoSueloValor);
            this.groupBoxDatos.Controls.Add(this.lblTemporada);
            this.groupBoxDatos.Controls.Add(this.lblTemporadaValor);
            this.groupBoxDatos.Controls.Add(this.lblCosto);
            this.groupBoxDatos.Controls.Add(this.lblCostoValor);
            this.groupBoxDatos.Controls.Add(this.lblPrecio);
            this.groupBoxDatos.Controls.Add(this.lblPrecioValor);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.lblCantidadValor);
            this.groupBoxDatos.Controls.Add(this.lblHectareas);
            this.groupBoxDatos.Controls.Add(this.lblHectareasValor);
            this.groupBoxDatos.Controls.Add(this.lblTipoCultivo);
            this.groupBoxDatos.Controls.Add(this.lblTipoCultivoValor);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.lblNombreValor);
            this.groupBoxDatos.Controls.Add(this.lblIdProducto);
            this.groupBoxDatos.Controls.Add(this.lblIdValor);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 170);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(640, 380);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Producto a Eliminar";
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
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblIdValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdValor.Location = new System.Drawing.Point(150, 30);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(20, 18);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "--";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombreValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNombreValor.Location = new System.Drawing.Point(150, 60);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(20, 18);
            this.lblNombreValor.TabIndex = 3;
            this.lblNombreValor.Text = "--";
            // 
            // lblTipoCultivo
            // 
            this.lblTipoCultivo.AutoSize = true;
            this.lblTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoCultivo.Location = new System.Drawing.Point(30, 90);
            this.lblTipoCultivo.Name = "lblTipoCultivo";
            this.lblTipoCultivo.Size = new System.Drawing.Size(104, 18);
            this.lblTipoCultivo.TabIndex = 4;
            this.lblTipoCultivo.Text = "Tipo Cultivo:";
            // 
            // lblTipoCultivoValor
            // 
            this.lblTipoCultivoValor.AutoSize = true;
            this.lblTipoCultivoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoCultivoValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTipoCultivoValor.Location = new System.Drawing.Point(150, 90);
            this.lblTipoCultivoValor.Name = "lblTipoCultivoValor";
            this.lblTipoCultivoValor.Size = new System.Drawing.Size(20, 18);
            this.lblTipoCultivoValor.TabIndex = 5;
            this.lblTipoCultivoValor.Text = "--";
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHectareas.Location = new System.Drawing.Point(30, 120);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(79, 18);
            this.lblHectareas.TabIndex = 6;
            this.lblHectareas.Text = "Hectáreas:";
            // 
            // lblHectareasValor
            // 
            this.lblHectareasValor.AutoSize = true;
            this.lblHectareasValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareasValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHectareasValor.Location = new System.Drawing.Point(150, 120);
            this.lblHectareasValor.Name = "lblHectareasValor";
            this.lblHectareasValor.Size = new System.Drawing.Size(20, 18);
            this.lblHectareasValor.TabIndex = 7;
            this.lblHectareasValor.Text = "--";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(30, 150);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCantidadValor
            // 
            this.lblCantidadValor.AutoSize = true;
            this.lblCantidadValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidadValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCantidadValor.Location = new System.Drawing.Point(150, 150);
            this.lblCantidadValor.Name = "lblCantidadValor";
            this.lblCantidadValor.Size = new System.Drawing.Size(20, 18);
            this.lblCantidadValor.TabIndex = 9;
            this.lblCantidadValor.Text = "--";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(350, 30);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 18);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblPrecioValor
            // 
            this.lblPrecioValor.AutoSize = true;
            this.lblPrecioValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrecioValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioValor.Location = new System.Drawing.Point(470, 30);
            this.lblPrecioValor.Name = "lblPrecioValor";
            this.lblPrecioValor.Size = new System.Drawing.Size(20, 18);
            this.lblPrecioValor.TabIndex = 11;
            this.lblPrecioValor.Text = "--";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCosto.Location = new System.Drawing.Point(350, 60);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(53, 18);
            this.lblCosto.TabIndex = 12;
            this.lblCosto.Text = "Costo:";
            // 
            // lblCostoValor
            // 
            this.lblCostoValor.AutoSize = true;
            this.lblCostoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCostoValor.Location = new System.Drawing.Point(470, 60);
            this.lblCostoValor.Name = "lblCostoValor";
            this.lblCostoValor.Size = new System.Drawing.Size(20, 18);
            this.lblCostoValor.TabIndex = 13;
            this.lblCostoValor.Text = "--";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTemporada.Location = new System.Drawing.Point(350, 90);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(85, 18);
            this.lblTemporada.TabIndex = 14;
            this.lblTemporada.Text = "Temporada:";
            // 
            // lblTemporadaValor
            // 
            this.lblTemporadaValor.AutoSize = true;
            this.lblTemporadaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTemporadaValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTemporadaValor.Location = new System.Drawing.Point(470, 90);
            this.lblTemporadaValor.Name = "lblTemporadaValor";
            this.lblTemporadaValor.Size = new System.Drawing.Size(20, 18);
            this.lblTemporadaValor.TabIndex = 15;
            this.lblTemporadaValor.Text = "--";
            // 
            // lblTipoSuelo
            // 
            this.lblTipoSuelo.AutoSize = true;
            this.lblTipoSuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoSuelo.Location = new System.Drawing.Point(350, 120);
            this.lblTipoSuelo.Name = "lblTipoSuelo";
            this.lblTipoSuelo.Size = new System.Drawing.Size(89, 18);
            this.lblTipoSuelo.TabIndex = 16;
            this.lblTipoSuelo.Text = "Tipo Suelo:";
            // 
            // lblTipoSueloValor
            // 
            this.lblTipoSueloValor.AutoSize = true;
            this.lblTipoSueloValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoSueloValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTipoSueloValor.Location = new System.Drawing.Point(470, 120);
            this.lblTipoSueloValor.Name = "lblTipoSueloValor";
            this.lblTipoSueloValor.Size = new System.Drawing.Size(20, 18);
            this.lblTipoSueloValor.TabIndex = 17;
            this.lblTipoSueloValor.Text = "--";
            // 
            // lblCodigoFinca
            // 
            this.lblCodigoFinca.AutoSize = true;
            this.lblCodigoFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigoFinca.Location = new System.Drawing.Point(350, 150);
            this.lblCodigoFinca.Name = "lblCodigoFinca";
            this.lblCodigoFinca.Size = new System.Drawing.Size(103, 18);
            this.lblCodigoFinca.TabIndex = 18;
            this.lblCodigoFinca.Text = "Código Finca:";
            // 
            // lblCodigoFincaValor
            // 
            this.lblCodigoFincaValor.AutoSize = true;
            this.lblCodigoFincaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCodigoFincaValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCodigoFincaValor.Location = new System.Drawing.Point(470, 150);
            this.lblCodigoFincaValor.Name = "lblCodigoFincaValor";
            this.lblCodigoFincaValor.Size = new System.Drawing.Size(20, 18);
            this.lblCodigoFincaValor.TabIndex = 19;
            this.lblCodigoFincaValor.Text = "--";
            // 
            // lblFechaProduccion
            // 
            this.lblFechaProduccion.AutoSize = true;
            this.lblFechaProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaProduccion.Location = new System.Drawing.Point(30, 190);
            this.lblFechaProduccion.Name = "lblFechaProduccion";
            this.lblFechaProduccion.Size = new System.Drawing.Size(138, 18);
            this.lblFechaProduccion.TabIndex = 20;
            this.lblFechaProduccion.Text = "Fecha Producción:";
            // 
            // lblFechaProduccionValor
            // 
            this.lblFechaProduccionValor.AutoSize = true;
            this.lblFechaProduccionValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaProduccionValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFechaProduccionValor.Location = new System.Drawing.Point(190, 190);
            this.lblFechaProduccionValor.Name = "lblFechaProduccionValor";
            this.lblFechaProduccionValor.Size = new System.Drawing.Size(20, 18);
            this.lblFechaProduccionValor.TabIndex = 21;
            this.lblFechaProduccionValor.Text = "--";
            // 
            // lblIngresoTotal
            // 
            this.lblIngresoTotal.AutoSize = true;
            this.lblIngresoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIngresoTotal.Location = new System.Drawing.Point(30, 230);
            this.lblIngresoTotal.Name = "lblIngresoTotal";
            this.lblIngresoTotal.Size = new System.Drawing.Size(105, 18);
            this.lblIngresoTotal.TabIndex = 22;
            this.lblIngresoTotal.Text = "Ingreso Total:";
            // 
            // lblIngresoTotalValor
            // 
            this.lblIngresoTotalValor.AutoSize = true;
            this.lblIngresoTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIngresoTotalValor.ForeColor = System.Drawing.Color.Green;
            this.lblIngresoTotalValor.Location = new System.Drawing.Point(150, 230);
            this.lblIngresoTotalValor.Name = "lblIngresoTotalValor";
            this.lblIngresoTotalValor.Size = new System.Drawing.Size(20, 18);
            this.lblIngresoTotalValor.TabIndex = 23;
            this.lblIngresoTotalValor.Text = "--";
            // 
            // lblRendimiento
            // 
            this.lblRendimiento.AutoSize = true;
            this.lblRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRendimiento.Location = new System.Drawing.Point(350, 230);
            this.lblRendimiento.Name = "lblRendimiento";
            this.lblRendimiento.Size = new System.Drawing.Size(100, 18);
            this.lblRendimiento.TabIndex = 24;
            this.lblRendimiento.Text = "Rendimiento:";
            // 
            // lblRendimientoValor
            // 
            this.lblRendimientoValor.AutoSize = true;
            this.lblRendimientoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRendimientoValor.ForeColor = System.Drawing.Color.Green;
            this.lblRendimientoValor.Location = new System.Drawing.Point(470, 230);
            this.lblRendimientoValor.Name = "lblRendimientoValor";
            this.lblRendimientoValor.Size = new System.Drawing.Size(20, 18);
            this.lblRendimientoValor.TabIndex = 25;
            this.lblRendimientoValor.Text = "--";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(200, 570);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(380, 570);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 630);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEliminarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Producto - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormEliminarProducto_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
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
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblTipoCultivo;
        private System.Windows.Forms.Label lblTipoCultivoValor;
        private System.Windows.Forms.Label lblHectareas;
        private System.Windows.Forms.Label lblHectareasValor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadValor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioValor;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCostoValor;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lblTemporadaValor;
        private System.Windows.Forms.Label lblTipoSuelo;
        private System.Windows.Forms.Label lblTipoSueloValor;
        private System.Windows.Forms.Label lblCodigoFinca;
        private System.Windows.Forms.Label lblCodigoFincaValor;
        private System.Windows.Forms.Label lblFechaProduccion;
        private System.Windows.Forms.Label lblFechaProduccionValor;
        private System.Windows.Forms.Label lblIngresoTotal;
        private System.Windows.Forms.Label lblIngresoTotalValor;
        private System.Windows.Forms.Label lblRendimiento;
        private System.Windows.Forms.Label lblRendimientoValor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}