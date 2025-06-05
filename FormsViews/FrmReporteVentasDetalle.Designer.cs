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
            this.ferreteria_facturacionDataSet3 = new sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3();
            this.facturas_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturas_productosTableAdapter = new sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3TableAdapters.facturas_productosTableAdapter();
            this.tableAdapterManager = new sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3TableAdapters.TableAdapterManager();
            this.dtgfacturas_producto = new System.Windows.Forms.DataGridView();
            this.clientesTableAdapter1 = new sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet2TableAdapters.clientesTableAdapter();
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
            this.productosDataSet = new sistema_de_facturacion.Datasets.ProductosDataSet();
            this.ferreteriafacturacionDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new sistema_de_facturacion.Datasets.ProductosDataSetTableAdapters.productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfacturas_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriafacturacionDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ferreteria_facturacionDataSet3
            // 
            this.ferreteria_facturacionDataSet3.DataSetName = "ferreteria_facturacionDataSet3";
            this.ferreteria_facturacionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturas_productosBindingSource
            // 
            this.facturas_productosBindingSource.DataMember = "facturas_productos";
            this.facturas_productosBindingSource.DataSource = this.ferreteria_facturacionDataSet3;
            // 
            // facturas_productosTableAdapter
            // 
            this.facturas_productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.facturas_productosTableAdapter = this.facturas_productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtgfacturas_producto
            // 
            this.dtgfacturas_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfacturas_producto.Location = new System.Drawing.Point(20, 174);
            this.dtgfacturas_producto.Name = "dtgfacturas_producto";
            this.dtgfacturas_producto.ReadOnly = true;
            this.dtgfacturas_producto.RowHeadersWidth = 51;
            this.dtgfacturas_producto.RowTemplate.Height = 24;
            this.dtgfacturas_producto.Size = new System.Drawing.Size(1012, 346);
            this.dtgfacturas_producto.TabIndex = 1;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(40, 54);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(281, 22);
            this.dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(363, 54);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(281, 22);
            this.dtpHasta.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(35, 9);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(89, 29);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(358, 9);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(79, 29);
            this.lblHasta.TabIndex = 5;
            this.lblHasta.Text = "Hasta";
            // 
            // cbxProductos
            // 
            this.cbxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProductos.BackColor = System.Drawing.Color.Silver;
            this.cbxProductos.DataSource = this.productosBindingSource2;
            this.cbxProductos.DisplayMember = "descripcion";
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(40, 127);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(604, 24);
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
            this.lblProductos.Location = new System.Drawing.Point(35, 87);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(131, 29);
            this.lblProductos.TabIndex = 7;
            this.lblProductos.Text = "Productos";
            // 
            // btnActualizarRepVtaDet
            // 
            this.btnActualizarRepVtaDet.BackColor = System.Drawing.Color.Lavender;
            this.btnActualizarRepVtaDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRepVtaDet.Location = new System.Drawing.Point(706, 56);
            this.btnActualizarRepVtaDet.Name = "btnActualizarRepVtaDet";
            this.btnActualizarRepVtaDet.Size = new System.Drawing.Size(185, 81);
            this.btnActualizarRepVtaDet.TabIndex = 8;
            this.btnActualizarRepVtaDet.Text = "Actualizar";
            this.btnActualizarRepVtaDet.UseVisualStyleBackColor = false;
            this.btnActualizarRepVtaDet.Click += new System.EventHandler(this.btnActualizarRepVtaDet_Click);
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "productos";
            this.productosBindingSource1.DataSource = this.productosDataSetBindingSource;
            // 
            // productosDataSetBindingSource
            // 
            this.productosDataSetBindingSource.DataSource = this.productosDataSet;
            this.productosDataSetBindingSource.Position = 0;
            // 
            // productosDataSet
            // 
            this.productosDataSet.DataSetName = "ProductosDataSet";
            this.productosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ferreteriafacturacionDataSet3BindingSource
            // 
            this.ferreteriafacturacionDataSet3BindingSource.DataSource = this.ferreteria_facturacionDataSet3;
            this.ferreteriafacturacionDataSet3BindingSource.Position = 0;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.productosDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteVentasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 553);
            this.Controls.Add(this.btnActualizarRepVtaDet);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cbxProductos);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dtgfacturas_producto);
            this.Name = "FrmReporteVentasDetalle";
            this.Text = "REPORTE DE VENTAS DETALLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfacturas_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriafacturacionDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3 ferreteria_facturacionDataSet3;
        private System.Windows.Forms.BindingSource facturas_productosBindingSource;
        private sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3TableAdapters.facturas_productosTableAdapter facturas_productosTableAdapter;
        private sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgfacturas_producto;
        private sistema_de_facturacion.Datasets.ferreteria_facturacionDataSet2TableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cbxProductos;
        private Datasets.ProductosDataSet productosDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Datasets.ProductosDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnActualizarRepVtaDet;
        private System.Windows.Forms.BindingSource ferreteriafacturacionDataSet3BindingSource;
        private System.Windows.Forms.BindingSource productosDataSetBindingSource;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private Datasets.ProductosDataSet productosDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource2;
    }
}