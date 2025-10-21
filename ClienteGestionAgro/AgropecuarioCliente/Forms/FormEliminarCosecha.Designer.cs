namespace AgropecuarioCliente.Forms
{
    partial class FormEliminarCosecha
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
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidadValor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCalidadValor = new System.Windows.Forms.Label();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.lblTrabajadoresValor = new System.Windows.Forms.Label();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.lblCostoValor = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCondicionesValor = new System.Windows.Forms.Label();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblObservacionesValor = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.groupBoxCalculos = new System.Windows.Forms.GroupBox();
            this.lblCostoPorKgValor = new System.Windows.Forms.Label();
            this.lblCostoPorKg = new System.Windows.Forms.Label();
            this.lblRendimientoValor = new System.Windows.Forms.Label();
            this.lblRendimiento = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminar Cosecha";
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
            this.groupBoxBusqueda.Text = "Buscar Cosecha a Eliminar";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInstrucciones.Location = new System.Drawing.Point(20, 25);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(400, 40);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Haga clic en \'Buscar Cosecha\' para seleccionar la cosecha que desea eliminar.";
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
            this.groupBoxDatos.Controls.Add(this.lblObservacionesValor);
            this.groupBoxDatos.Controls.Add(this.lblObservaciones);
            this.groupBoxDatos.Controls.Add(this.lblEstadoValor);
            this.groupBoxDatos.Controls.Add(this.lblEstado);
            this.groupBoxDatos.Controls.Add(this.lblCondicionesValor);
            this.groupBoxDatos.Controls.Add(this.lblCondiciones);
            this.groupBoxDatos.Controls.Add(this.lblCostoValor);
            this.groupBoxDatos.Controls.Add(this.lblCosto);
            this.groupBoxDatos.Controls.Add(this.lblTrabajadoresValor);
            this.groupBoxDatos.Controls.Add(this.lblTrabajadores);
            this.groupBoxDatos.Controls.Add(this.lblCalidadValor);
            this.groupBoxDatos.Controls.Add(this.lblCalidad);
            this.groupBoxDatos.Controls.Add(this.lblCantidadValor);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.lblFechaValor);
            this.groupBoxDatos.Controls.Add(this.lblFecha);
            this.groupBoxDatos.Controls.Add(this.lblProductoValor);
            this.groupBoxDatos.Controls.Add(this.lblProducto);
            this.groupBoxDatos.Controls.Add(this.lblIdValor);
            this.groupBoxDatos.Controls.Add(this.lblId);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 160);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(640, 340);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos de la Cosecha a Eliminar";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(20, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(74, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Cosecha:";
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblIdValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIdValor.Location = new System.Drawing.Point(150, 30);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(20, 15);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "--";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(20, 60);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(85, 15);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto ID:";
            // 
            // lblProductoValor
            // 
            this.lblProductoValor.AutoSize = true;
            this.lblProductoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProductoValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductoValor.Location = new System.Drawing.Point(150, 60);
            this.lblProductoValor.Name = "lblProductoValor";
            this.lblProductoValor.Size = new System.Drawing.Size(20, 15);
            this.lblProductoValor.TabIndex = 3;
            this.lblProductoValor.Text = "--";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(20, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Cosecha:";
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFechaValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFechaValor.Location = new System.Drawing.Point(150, 90);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(20, 15);
            this.lblFechaValor.TabIndex = 5;
            this.lblFechaValor.Text = "--";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(20, 120);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(135, 15);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad Recolectada:";
            // 
            // lblCantidadValor
            // 
            this.lblCantidadValor.AutoSize = true;
            this.lblCantidadValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidadValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCantidadValor.Location = new System.Drawing.Point(170, 120);
            this.lblCantidadValor.Name = "lblCantidadValor";
            this.lblCantidadValor.Size = new System.Drawing.Size(20, 15);
            this.lblCantidadValor.TabIndex = 7;
            this.lblCantidadValor.Text = "--";
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalidad.Location = new System.Drawing.Point(350, 30);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(56, 15);
            this.lblCalidad.TabIndex = 8;
            this.lblCalidad.Text = "Calidad:";
            // 
            // lblCalidadValor
            // 
            this.lblCalidadValor.AutoSize = true;
            this.lblCalidadValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCalidadValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCalidadValor.Location = new System.Drawing.Point(480, 30);
            this.lblCalidadValor.Name = "lblCalidadValor";
            this.lblCalidadValor.Size = new System.Drawing.Size(20, 15);
            this.lblCalidadValor.TabIndex = 9;
            this.lblCalidadValor.Text = "--";
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrabajadores.Location = new System.Drawing.Point(350, 60);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(94, 15);
            this.lblTrabajadores.TabIndex = 10;
            this.lblTrabajadores.Text = "Trabajadores:";
            // 
            // lblTrabajadoresValor
            // 
            this.lblTrabajadoresValor.AutoSize = true;
            this.lblTrabajadoresValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTrabajadoresValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTrabajadoresValor.Location = new System.Drawing.Point(480, 60);
            this.lblTrabajadoresValor.Name = "lblTrabajadoresValor";
            this.lblTrabajadoresValor.Size = new System.Drawing.Size(20, 15);
            this.lblTrabajadoresValor.TabIndex = 11;
            this.lblTrabajadoresValor.Text = "--";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCosto.Location = new System.Drawing.Point(350, 90);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(120, 15);
            this.lblCosto.TabIndex = 12;
            this.lblCosto.Text = "Costo Mano Obra:";
            // 
            // lblCostoValor
            // 
            this.lblCostoValor.AutoSize = true;
            this.lblCostoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCostoValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCostoValor.Location = new System.Drawing.Point(480, 90);
            this.lblCostoValor.Name = "lblCostoValor";
            this.lblCostoValor.Size = new System.Drawing.Size(20, 15);
            this.lblCostoValor.TabIndex = 13;
            this.lblCostoValor.Text = "--";
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCondiciones.Location = new System.Drawing.Point(20, 150);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(162, 15);
            this.lblCondiciones.TabIndex = 14;
            this.lblCondiciones.Text = "Condiciones Climáticas:";
            // 
            // lblCondicionesValor
            // 
            this.lblCondicionesValor.AutoSize = true;
            this.lblCondicionesValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCondicionesValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCondicionesValor.Location = new System.Drawing.Point(200, 150);
            this.lblCondicionesValor.Name = "lblCondicionesValor";
            this.lblCondicionesValor.Size = new System.Drawing.Size(20, 15);
            this.lblCondicionesValor.TabIndex = 15;
            this.lblCondicionesValor.Text = "--";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(350, 150);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 15);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEstadoValor
            // 
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEstadoValor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEstadoValor.Location = new System.Drawing.Point(480, 150);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Size = new System.Drawing.Size(20, 15);
            this.lblEstadoValor.TabIndex = 17;
            this.lblEstadoValor.Text = "--";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservaciones.Location = new System.Drawing.Point(20, 180);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(106, 15);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblObservacionesValor
            // 
            this.lblObservacionesValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblObservacionesValor.ForeColor = System.Drawing.Color.Gray;
            this.lblObservacionesValor.Location = new System.Drawing.Point(20, 200);
            this.lblObservacionesValor.Name = "lblObservacionesValor";
            this.lblObservacionesValor.Size = new System.Drawing.Size(590, 120);
            this.lblObservacionesValor.TabIndex = 19;
            this.lblObservacionesValor.Text = "--";
            // 
            // groupBoxCalculos
            // 
            this.groupBoxCalculos.Controls.Add(this.lblRendimientoValor);
            this.groupBoxCalculos.Controls.Add(this.lblRendimiento);
            this.groupBoxCalculos.Controls.Add(this.lblCostoPorKgValor);
            this.groupBoxCalculos.Controls.Add(this.lblCostoPorKg);
            this.groupBoxCalculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxCalculos.Location = new System.Drawing.Point(30, 520);
            this.groupBoxCalculos.Name = "groupBoxCalculos";
            this.groupBoxCalculos.Size = new System.Drawing.Size(640, 80);
            this.groupBoxCalculos.TabIndex = 3;
            this.groupBoxCalculos.TabStop = false;
            this.groupBoxCalculos.Text = "Cálculos";
            // 
            // lblCostoPorKg
            // 
            this.lblCostoPorKg.AutoSize = true;
            this.lblCostoPorKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostoPorKg.Location = new System.Drawing.Point(20, 35);
            this.lblCostoPorKg.Name = "lblCostoPorKg";
            this.lblCostoPorKg.Size = new System.Drawing.Size(89, 15);
            this.lblCostoPorKg.TabIndex = 0;
            this.lblCostoPorKg.Text = "Costo por kg:";
            // 
            // lblCostoPorKgValor
            // 
            this.lblCostoPorKgValor.AutoSize = true;
            this.lblCostoPorKgValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostoPorKgValor.ForeColor = System.Drawing.Color.Green;
            this.lblCostoPorKgValor.Location = new System.Drawing.Point(150, 35);
            this.lblCostoPorKgValor.Name = "lblCostoPorKgValor";
            this.lblCostoPorKgValor.Size = new System.Drawing.Size(20, 15);
            this.lblCostoPorKgValor.TabIndex = 1;
            this.lblCostoPorKgValor.Text = "--";
            // 
            // lblRendimiento
            // 
            this.lblRendimiento.AutoSize = true;
            this.lblRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRendimiento.Location = new System.Drawing.Point(350, 35);
            this.lblRendimiento.Name = "lblRendimiento";
            this.lblRendimiento.Size = new System.Drawing.Size(136, 15);
            this.lblRendimiento.TabIndex = 2;
            this.lblRendimiento.Text = "Rendimiento (kg/trab):";
            // 
            // lblRendimientoValor
            // 
            this.lblRendimientoValor.AutoSize = true;
            this.lblRendimientoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRendimientoValor.ForeColor = System.Drawing.Color.Green;
            this.lblRendimientoValor.Location = new System.Drawing.Point(500, 35);
            this.lblRendimientoValor.Name = "lblRendimientoValor";
            this.lblRendimientoValor.Size = new System.Drawing.Size(20, 15);
            this.lblRendimientoValor.TabIndex = 3;
            this.lblRendimientoValor.Text = "--";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(400, 620);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(540, 620);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormEliminarCosecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 680);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBoxCalculos);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEliminarCosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Cosecha - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormEliminarCosecha_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxCalculos.ResumeLayout(false);
            this.groupBoxCalculos.PerformLayout();
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
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadValor;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.Label lblCalidadValor;
        private System.Windows.Forms.Label lblTrabajadores;
        private System.Windows.Forms.Label lblTrabajadoresValor;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCostoValor;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.Label lblCondicionesValor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblObservacionesValor;
        private System.Windows.Forms.GroupBox groupBoxCalculos;
        private System.Windows.Forms.Label lblCostoPorKg;
        private System.Windows.Forms.Label lblCostoPorKgValor;
        private System.Windows.Forms.Label lblRendimiento;
        private System.Windows.Forms.Label lblRendimientoValor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}