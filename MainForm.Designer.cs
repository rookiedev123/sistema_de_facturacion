namespace sistema_de_facturacion
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.components = new System.ComponentModel.Container();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btnProductos_ = new System.Windows.Forms.Button();
            this.btnReportesDeVentas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnControlPagos = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblFacturación = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_facturar
            // 
            this.btn_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.Location = new System.Drawing.Point(54, 138);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(244, 45);
            this.btn_facturar.TabIndex = 1;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btnProductos_
            // 
            this.btnProductos_.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_.Location = new System.Drawing.Point(54, 216);
            this.btnProductos_.Name = "btnProductos_";
            this.btnProductos_.Size = new System.Drawing.Size(244, 45);
            this.btnProductos_.TabIndex = 2;
            this.btnProductos_.Text = "Productos";
            this.btnProductos_.UseVisualStyleBackColor = true;
            this.btnProductos_.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportesDeVentas
            // 
            this.btnReportesDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesDeVentas.Location = new System.Drawing.Point(459, 216);
            this.btnReportesDeVentas.Name = "btnReportesDeVentas";
            this.btnReportesDeVentas.Size = new System.Drawing.Size(493, 45);
            this.btnReportesDeVentas.TabIndex = 6;
            this.btnReportesDeVentas.Text = "Reportes de Venta Por Documento";
            this.btnReportesDeVentas.UseVisualStyleBackColor = true;
            this.btnReportesDeVentas.Click += new System.EventHandler(this.btnReportesDeVentas_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(459, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reportes de Venta Detalle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(54, 295);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(244, 45);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnControlPagos
            // 
            this.btnControlPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPagos.Location = new System.Drawing.Point(459, 138);
            this.btnControlPagos.Name = "btnControlPagos";
            this.btnControlPagos.Size = new System.Drawing.Size(493, 45);
            this.btnControlPagos.TabIndex = 5;
            this.btnControlPagos.Text = "Control de Pagos y Deudas";
            this.btnControlPagos.UseVisualStyleBackColor = true;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(459, 81);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(141, 26);
            this.lblReportes.TabIndex = 7;
            this.lblReportes.Text = "REPORTES";
            // 
            // lblFacturación
            // 
            this.lblFacturación.AutoSize = true;
            this.lblFacturación.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturación.Location = new System.Drawing.Point(48, 81);
            this.lblFacturación.Name = "lblFacturación";
            this.lblFacturación.Size = new System.Drawing.Size(181, 26);
            this.lblFacturación.TabIndex = 8;
            this.lblFacturación.Text = "FACTURACION";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(724, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(251, 47);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(sistema_de_facturacion.Services.Facturacion.Articulo);
            // 
            // HomeForm
            // 
            this.ClientSize = new System.Drawing.Size(987, 505);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFacturación);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.btnControlPagos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReportesDeVentas);
            this.Controls.Add(this.btnProductos_);
            this.Controls.Add(this.btn_facturar);
            this.Name = "HomeForm";
            this.Text = ".:MENU:.";
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Button btnProductos_;
        private System.Windows.Forms.Button btnReportesDeVentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnControlPagos;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblFacturación;
        private System.Windows.Forms.Button btnSalir;
    }
}

