namespace sistema_de_facturacion.FormsViews
{
    partial class FrmReporteVentasDetalle
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
            this.components = new System.ComponentModel.Container();
            this.dtgfacturas_producto = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productosDataSet1 = new sistema_de_facturacion.Datasets.ProductosDataSet();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnActualizarRepVtaDet = new System.Windows.Forms.Button();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteriafacturacionDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgfacturas_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriafacturacionDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgfacturas_producto
            // 
            this.dtgfacturas_producto.AllowUserToAddRows = false;
            this.dtgfacturas_producto.AllowUserToDeleteRows = false;
            this.dtgfacturas_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfacturas_producto.Location = new System.Drawing.Point(15, 141);
            this.dtgfacturas_producto.Margin = new System.Windows.Forms.Padding(2);
            this.dtgfacturas_producto.Name = "dtgfacturas_producto";
            this.dtgfacturas_producto.ReadOnly = true;
            this.dtgfacturas_producto.RowHeadersWidth = 51;
            this.dtgfacturas_producto.RowTemplate.Height = 24;
            this.dtgfacturas_producto.Size = new System.Drawing.Size(1042, 363);
            this.dtgfacturas_producto.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(30, 44);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(212, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(272, 44);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(212, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(26, 7);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(70, 24);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(268, 7);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(62, 24);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta";
            // 
            // cbxProductos
            // 
            this.cbxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProductos.BackColor = System.Drawing.Color.Silver;
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(30, 103);
            this.cbxProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(454, 21);
            this.cbxProductos.TabIndex = 6;
            this.cbxProductos.ValueMember = "producto_id";
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "productos";
            this.productosBindingSource2.DataSource = this.productosDataSet1;
            // 
            // productosDataSet1
            // 
            this.productosDataSet1.DataSetName = "ProductosDataSet";
            this.productosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(26, 71);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(104, 24);
            this.lblProductos.TabIndex = 7;
            this.lblProductos.Text = "Productos";
            // 
            // btnActualizarRepVtaDet
            // 
            this.btnActualizarRepVtaDet.BackColor = System.Drawing.Color.Lavender;
            this.btnActualizarRepVtaDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRepVtaDet.Location = new System.Drawing.Point(918, 58);
            this.btnActualizarRepVtaDet.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarRepVtaDet.Name = "btnActualizarRepVtaDet";
            this.btnActualizarRepVtaDet.Size = new System.Drawing.Size(139, 66);
            this.btnActualizarRepVtaDet.TabIndex = 8;
            this.btnActualizarRepVtaDet.Text = "Actualizar";
            this.btnActualizarRepVtaDet.UseVisualStyleBackColor = false;
            this.btnActualizarRepVtaDet.Click += new System.EventHandler(this.btnActualizarRepVtaDet_Click);
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataSource = this.productosDataSetBindingSource;
            // 
            // FrmReporteVentasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 515);
            this.Controls.Add(this.btnActualizarRepVtaDet);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cbxProductos);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dtgfacturas_producto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporteVentasDetalle";
            this.Text = "REPORTE DE VENTAS DETALLE";
            this.Load += new System.EventHandler(this.FrmReporteVentasDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgfacturas_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriafacturacionDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgfacturas_producto;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cbxProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnActualizarRepVtaDet;
        private System.Windows.Forms.BindingSource ferreteriafacturacionDataSet3BindingSource;
        private System.Windows.Forms.BindingSource productosDataSetBindingSource;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private Datasets.ProductosDataSet productosDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource2;
    }
}