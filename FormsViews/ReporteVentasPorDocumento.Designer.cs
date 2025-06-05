namespace sistema_de_facturacion.FormsViews
{
    partial class frmReporteDeVentas
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
            this.dtpDesdeR = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaR = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cbxBuscadorClientes = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ferreteria_facturacionDataSet2 = new sistema_de_facturacion.ferreteria_facturacionDataSet2();
            this.lblClientes = new System.Windows.Forms.Label();
            this.productosDataSet = new sistema_de_facturacion.Datasets.ProductosDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new sistema_de_facturacion.Datasets.ProductosDataSetTableAdapters.productosTableAdapter();
            this.dtgReporteVentas = new System.Windows.Forms.DataGridView();
            this.facturas_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasDataSet = new sistema_de_facturacion.FacturasDataSet();
            this.ferreteria_facturacionDataSet = new sistema_de_facturacion.ferreteria_facturacionDataSet();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new sistema_de_facturacion.ferreteria_facturacionDataSetTableAdapters.facturasTableAdapter();
            this.tableAdapterManager = new sistema_de_facturacion.ferreteria_facturacionDataSetTableAdapters.TableAdapterManager();
            this.facturas_productosTableAdapter = new sistema_de_facturacion.FacturasDataSetTableAdapters.facturas_productosTableAdapter();
            this.tableAdapterManager1 = new sistema_de_facturacion.FacturasDataSetTableAdapters.TableAdapterManager();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new sistema_de_facturacion.ferreteria_facturacionDataSet2TableAdapters.clientesTableAdapter();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporteVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesdeR
            // 
            this.dtpDesdeR.Location = new System.Drawing.Point(39, 43);
            this.dtpDesdeR.Name = "dtpDesdeR";
            this.dtpDesdeR.Size = new System.Drawing.Size(200, 22);
            this.dtpDesdeR.TabIndex = 0;
            // 
            // dtpHastaR
            // 
            this.dtpHastaR.Location = new System.Drawing.Point(300, 43);
            this.dtpHastaR.Name = "dtpHastaR";
            this.dtpHastaR.Size = new System.Drawing.Size(200, 22);
            this.dtpHastaR.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(39, 13);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(297, 13);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // cbxBuscadorClientes
            // 
            this.cbxBuscadorClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBuscadorClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBuscadorClientes.DataSource = this.clientesBindingSource3;
            this.cbxBuscadorClientes.DisplayMember = "nombres";
            this.cbxBuscadorClientes.FormattingEnabled = true;
            this.cbxBuscadorClientes.Location = new System.Drawing.Point(39, 105);
            this.cbxBuscadorClientes.Name = "cbxBuscadorClientes";
            this.cbxBuscadorClientes.Size = new System.Drawing.Size(121, 24);
            this.cbxBuscadorClientes.TabIndex = 4;
            this.cbxBuscadorClientes.ValueMember = "clienteId";
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "clientes";
            this.clientesBindingSource3.DataSource = this.ferreteria_facturacionDataSet2;
            // 
            // ferreteria_facturacionDataSet2
            // 
            this.ferreteria_facturacionDataSet2.DataSetName = "ferreteria_facturacionDataSet2";
            this.ferreteria_facturacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(39, 83);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(55, 16);
            this.lblClientes.TabIndex = 5;
            this.lblClientes.Text = "Clientes";
            // 
            // productosDataSet
            // 
            this.productosDataSet.DataSetName = "ProductosDataSet";
            this.productosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dtgReporteVentas
            // 
            this.dtgReporteVentas.AllowUserToOrderColumns = true;
            this.dtgReporteVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReporteVentas.Location = new System.Drawing.Point(39, 183);
            this.dtgReporteVentas.Name = "dtgReporteVentas";
            this.dtgReporteVentas.ReadOnly = true;
            this.dtgReporteVentas.RowHeadersWidth = 51;
            this.dtgReporteVentas.RowTemplate.Height = 24;
            this.dtgReporteVentas.Size = new System.Drawing.Size(1276, 409);
            this.dtgReporteVentas.TabIndex = 6;
            // 
            // facturas_productosBindingSource
            // 
            this.facturas_productosBindingSource.DataMember = "facturas_productos";
            this.facturas_productosBindingSource.DataSource = this.facturasDataSet;
            // 
            // facturasDataSet
            // 
            this.facturasDataSet.DataSetName = "FacturasDataSet";
            this.facturasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ferreteria_facturacionDataSet
            // 
            this.ferreteria_facturacionDataSet.DataSetName = "ferreteria_facturacionDataSet";
            this.ferreteria_facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "facturas";
            this.facturasBindingSource.DataSource = this.ferreteria_facturacionDataSet;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.facturasTableAdapter = this.facturasTableAdapter;
            this.tableAdapterManager.UpdateOrder = sistema_de_facturacion.ferreteria_facturacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facturas_productosTableAdapter
            // 
            this.facturas_productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.facturas_productosTableAdapter = this.facturas_productosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = sistema_de_facturacion.FacturasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.ferreteria_facturacionDataSet2;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.ferreteria_facturacionDataSet2;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "clientes";
            this.clientesBindingSource2.DataSource = this.ferreteria_facturacionDataSet2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(661, 43);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmReporteDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 635);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgReporteVentas);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHastaR);
            this.Controls.Add(this.dtpDesdeR);
            this.Controls.Add(this.cbxBuscadorClientes);
            this.Name = "frmReporteDeVentas";
            this.Text = "REPORTE DE VENTAS";
            this.Load += new System.EventHandler(this.frmReporteDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporteVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesdeR;
        private System.Windows.Forms.DateTimePicker dtpHastaR;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cbxBuscadorClientes;
        private System.Windows.Forms.Label lblClientes;
        private Datasets.ProductosDataSet productosDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Datasets.ProductosDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridView dtgReporteVentas;
        private ferreteria_facturacionDataSet ferreteria_facturacionDataSet;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private ferreteria_facturacionDataSetTableAdapters.facturasTableAdapter facturasTableAdapter;
        private ferreteria_facturacionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FacturasDataSet facturasDataSet;
        private System.Windows.Forms.BindingSource facturas_productosBindingSource;
        private FacturasDataSetTableAdapters.facturas_productosTableAdapter facturas_productosTableAdapter;
        private FacturasDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ferreteria_facturacionDataSet2 ferreteria_facturacionDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ferreteria_facturacionDataSet2TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
    }
}