namespace sistema_de_facturacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btnProductos_ = new System.Windows.Forms.Button();
            this.btnReportesDeVentas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnControlPagos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_facturar
            // 
            this.btn_facturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.Location = new System.Drawing.Point(3, 3);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(369, 54);
            this.btn_facturar.TabIndex = 1;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btnProductos_
            // 
            this.btnProductos_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductos_.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_.Location = new System.Drawing.Point(3, 63);
            this.btnProductos_.Name = "btnProductos_";
            this.btnProductos_.Size = new System.Drawing.Size(369, 54);
            this.btnProductos_.TabIndex = 2;
            this.btnProductos_.Text = "Productos";
            this.btnProductos_.UseVisualStyleBackColor = true;
            this.btnProductos_.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportesDeVentas
            // 
            this.btnReportesDeVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportesDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesDeVentas.Location = new System.Drawing.Point(3, 183);
            this.btnReportesDeVentas.Name = "btnReportesDeVentas";
            this.btnReportesDeVentas.Size = new System.Drawing.Size(369, 54);
            this.btnReportesDeVentas.TabIndex = 6;
            this.btnReportesDeVentas.Text = "Reportes de Venta Por Documento";
            this.btnReportesDeVentas.UseVisualStyleBackColor = true;
            this.btnReportesDeVentas.Click += new System.EventHandler(this.btnReportesDeVentas_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reportes de Venta Detalle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(3, 123);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(369, 54);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnControlPagos
            // 
            this.btnControlPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPagos.Location = new System.Drawing.Point(3, 303);
            this.btnControlPagos.Name = "btnControlPagos";
            this.btnControlPagos.Size = new System.Drawing.Size(369, 57);
            this.btnControlPagos.TabIndex = 5;
            this.btnControlPagos.Text = "Control de Pagos y Deudas";
            this.btnControlPagos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::sistema_de_facturacion.Properties.Resources.error;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(836, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 44);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.08348F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.91652F));
            this.tableLayoutPanel1.Controls.Add(this.btn_facturar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProductos_, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClientes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnControlPagos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnReportesDeVentas, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 363);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // picFondo
            // 
            this.picFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFondo.ErrorImage = null;
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFondo.InitialImage")));
            this.picFondo.Location = new System.Drawing.Point(390, 104);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(585, 470);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 11;
            this.picFondo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(480, 73);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Ferreteria MAX";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(sistema_de_facturacion.Services.Facturacion.Articulo);
            // 
            // FrmMenu
            // 
            this.ClientSize = new System.Drawing.Size(987, 586);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMenu";
            this.Text = ".:MENU:.";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button btnProductos_;
        private System.Windows.Forms.Button btnReportesDeVentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnControlPagos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label lblTitulo;
    }
}

