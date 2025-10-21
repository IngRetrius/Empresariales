namespace AgropecuarioCliente.Forms
{
    partial class FormBuscarCosecha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(260, 10);
            this.lblTitulo.Text = "Buscar Cosechas";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.lblCriterio);
            this.groupBoxBusqueda.Controls.Add(this.txtBusqueda);
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.btnLimpiar);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(12, 40);
            this.groupBoxBusqueda.Size = new System.Drawing.Size(760, 80);
            this.groupBoxBusqueda.Text = "Criterios de Búsqueda";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Location = new System.Drawing.Point(16, 28);
            this.lblCriterio.Size = new System.Drawing.Size(100, 23);
            this.lblCriterio.Text = "Ingrese valor:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(120, 26);
            this.txtBusqueda.Size = new System.Drawing.Size(300, 22);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(440, 20);
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(580, 20);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxResultados
            //
            this.groupBoxResultados.Location = new System.Drawing.Point(12, 130);
            this.groupBoxResultados.Size = new System.Drawing.Size(760, 300);
            this.groupBoxResultados.Text = "Resultado de la Búsqueda";
            this.groupBoxResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            //
            // Campos de resultado para Cosecha
            var lblId = new System.Windows.Forms.Label();
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblId.Location = new System.Drawing.Point(20, 30);
            lblId.Text = "ID Cosecha:";
            this.groupBoxResultados.Controls.Add(lblId);

            this.txtResultadoId = new System.Windows.Forms.TextBox();
            this.txtResultadoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoId.Location = new System.Drawing.Point(180, 28);
            this.txtResultadoId.ReadOnly = true;
            this.txtResultadoId.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoId);

            var lblProductoId = new System.Windows.Forms.Label();
            lblProductoId.AutoSize = true;
            lblProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblProductoId.Location = new System.Drawing.Point(20, 65);
            lblProductoId.Text = "ID Producto:";
            this.groupBoxResultados.Controls.Add(lblProductoId);

            this.txtResultadoProductoId = new System.Windows.Forms.TextBox();
            this.txtResultadoProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoProductoId.Location = new System.Drawing.Point(180, 63);
            this.txtResultadoProductoId.ReadOnly = true;
            this.txtResultadoProductoId.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoProductoId);

            var lblFecha = new System.Windows.Forms.Label();
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblFecha.Location = new System.Drawing.Point(20, 100);
            lblFecha.Text = "Fecha Cosecha:";
            this.groupBoxResultados.Controls.Add(lblFecha);

            this.txtResultadoFecha = new System.Windows.Forms.TextBox();
            this.txtResultadoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoFecha.Location = new System.Drawing.Point(180, 98);
            this.txtResultadoFecha.ReadOnly = true;
            this.txtResultadoFecha.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoFecha);

            var lblCantidad = new System.Windows.Forms.Label();
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblCantidad.Location = new System.Drawing.Point(20, 135);
            lblCantidad.Text = "Cantidad Recolectada:";
            this.groupBoxResultados.Controls.Add(lblCantidad);

            this.txtResultadoCantidad = new System.Windows.Forms.TextBox();
            this.txtResultadoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCantidad.Location = new System.Drawing.Point(180, 133);
            this.txtResultadoCantidad.ReadOnly = true;
            this.txtResultadoCantidad.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCantidad);

            var lblCalidad = new System.Windows.Forms.Label();
            lblCalidad.AutoSize = true;
            lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblCalidad.Location = new System.Drawing.Point(400, 30);
            lblCalidad.Text = "Calidad:";
            this.groupBoxResultados.Controls.Add(lblCalidad);

            this.txtResultadoCalidad = new System.Windows.Forms.TextBox();
            this.txtResultadoCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCalidad.Location = new System.Drawing.Point(540, 28);
            this.txtResultadoCalidad.ReadOnly = true;
            this.txtResultadoCalidad.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCalidad);

            var lblTrabajadores = new System.Windows.Forms.Label();
            lblTrabajadores.AutoSize = true;
            lblTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblTrabajadores.Location = new System.Drawing.Point(400, 65);
            lblTrabajadores.Text = "Nº Trabajadores:";
            this.groupBoxResultados.Controls.Add(lblTrabajadores);

            this.txtResultadoTrabajadores = new System.Windows.Forms.TextBox();
            this.txtResultadoTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoTrabajadores.Location = new System.Drawing.Point(540, 63);
            this.txtResultadoTrabajadores.ReadOnly = true;
            this.txtResultadoTrabajadores.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoTrabajadores);

            var lblCosto = new System.Windows.Forms.Label();
            lblCosto.AutoSize = true;
            lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblCosto.Location = new System.Drawing.Point(400, 100);
            lblCosto.Text = "Costo Mano de Obra:";
            this.groupBoxResultados.Controls.Add(lblCosto);

            this.txtResultadoCosto = new System.Windows.Forms.TextBox();
            this.txtResultadoCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCosto.Location = new System.Drawing.Point(540, 98);
            this.txtResultadoCosto.ReadOnly = true;
            this.txtResultadoCosto.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCosto);

            var lblCondiciones = new System.Windows.Forms.Label();
            lblCondiciones.AutoSize = true;
            lblCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblCondiciones.Location = new System.Drawing.Point(20, 170);
            lblCondiciones.Text = "Condiciones Climáticas:";
            this.groupBoxResultados.Controls.Add(lblCondiciones);

            this.txtResultadoCondiciones = new System.Windows.Forms.TextBox();
            this.txtResultadoCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoCondiciones.Location = new System.Drawing.Point(180, 168);
            this.txtResultadoCondiciones.ReadOnly = true;
            this.txtResultadoCondiciones.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoCondiciones);

            var lblEstado = new System.Windows.Forms.Label();
            lblEstado.AutoSize = true;
            lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblEstado.Location = new System.Drawing.Point(400, 135);
            lblEstado.Text = "Estado:";
            this.groupBoxResultados.Controls.Add(lblEstado);

            this.txtResultadoEstado = new System.Windows.Forms.TextBox();
            this.txtResultadoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoEstado.Location = new System.Drawing.Point(540, 133);
            this.txtResultadoEstado.ReadOnly = true;
            this.txtResultadoEstado.Size = new System.Drawing.Size(200, 24);
            this.groupBoxResultados.Controls.Add(this.txtResultadoEstado);

            var lblObservaciones = new System.Windows.Forms.Label();
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            lblObservaciones.Location = new System.Drawing.Point(20, 205);
            lblObservaciones.Text = "Observaciones:";
            this.groupBoxResultados.Controls.Add(lblObservaciones);

            this.txtResultadoObservaciones = new System.Windows.Forms.TextBox();
            this.txtResultadoObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResultadoObservaciones.Location = new System.Drawing.Point(180, 203);
            this.txtResultadoObservaciones.Multiline = true;
            this.txtResultadoObservaciones.ReadOnly = true;
            this.txtResultadoObservaciones.Size = new System.Drawing.Size(560, 60);
            this.txtResultadoObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.groupBoxResultados.Controls.Add(this.txtResultadoObservaciones);

            // lblResultados
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultados.Location = new System.Drawing.Point(20, 275);
            this.lblResultados.Text = "";
            this.groupBoxResultados.Controls.Add(this.lblResultados);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(652, 420);
            this.btnCerrar.Size = new System.Drawing.Size(120, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBuscarCosecha
            //
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormBuscarCosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Cosechas - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormBuscarCosecha_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Designer fields
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblResultados;

        // Campos de resultado
        private System.Windows.Forms.TextBox txtResultadoId;
        private System.Windows.Forms.TextBox txtResultadoProductoId;
        private System.Windows.Forms.TextBox txtResultadoFecha;
        private System.Windows.Forms.TextBox txtResultadoCantidad;
        private System.Windows.Forms.TextBox txtResultadoCalidad;
        private System.Windows.Forms.TextBox txtResultadoTrabajadores;
        private System.Windows.Forms.TextBox txtResultadoCosto;
        private System.Windows.Forms.TextBox txtResultadoCondiciones;
        private System.Windows.Forms.TextBox txtResultadoEstado;
        private System.Windows.Forms.TextBox txtResultadoObservaciones;
    }
}