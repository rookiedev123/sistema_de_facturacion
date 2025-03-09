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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bill_tab_container = new System.Windows.Forms.TabControl();
            this.adm_bill_tab = new System.Windows.Forms.TabPage();
            this.adm_service_tab = new System.Windows.Forms.TabPage();
            this.reprint_tab = new System.Windows.Forms.TabPage();
            this.create_bill_tab = new System.Windows.Forms.TabPage();
            this.Services_dataGridView = new System.Windows.Forms.DataGridView();
            this.bill_tab_container.SuspendLayout();
            this.adm_service_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_tab_container
            // 
            this.bill_tab_container.Controls.Add(this.create_bill_tab);
            this.bill_tab_container.Controls.Add(this.adm_bill_tab);
            this.bill_tab_container.Controls.Add(this.reprint_tab);
            this.bill_tab_container.Controls.Add(this.adm_service_tab);
            this.bill_tab_container.Location = new System.Drawing.Point(12, 30);
            this.bill_tab_container.Name = "bill_tab_container";
            this.bill_tab_container.SelectedIndex = 0;
            this.bill_tab_container.Size = new System.Drawing.Size(846, 484);
            this.bill_tab_container.TabIndex = 0;
            // 
            // adm_bill_tab
            // 
            this.adm_bill_tab.Location = new System.Drawing.Point(4, 22);
            this.adm_bill_tab.Name = "adm_bill_tab";
            this.adm_bill_tab.Padding = new System.Windows.Forms.Padding(3);
            this.adm_bill_tab.Size = new System.Drawing.Size(838, 458);
            this.adm_bill_tab.TabIndex = 0;
            this.adm_bill_tab.Text = "Administrar facturas";
            this.adm_bill_tab.UseVisualStyleBackColor = true;
            // 
            // adm_service_tab
            // 
            this.adm_service_tab.Controls.Add(this.Services_dataGridView);
            this.adm_service_tab.Location = new System.Drawing.Point(4, 22);
            this.adm_service_tab.Name = "adm_service_tab";
            this.adm_service_tab.Padding = new System.Windows.Forms.Padding(3);
            this.adm_service_tab.Size = new System.Drawing.Size(838, 458);
            this.adm_service_tab.TabIndex = 1;
            this.adm_service_tab.Text = "Administrar servicio";
            this.adm_service_tab.UseVisualStyleBackColor = true;
            // 
            // reprint_tab
            // 
            this.reprint_tab.Location = new System.Drawing.Point(4, 22);
            this.reprint_tab.Name = "reprint_tab";
            this.reprint_tab.Size = new System.Drawing.Size(838, 458);
            this.reprint_tab.TabIndex = 2;
            this.reprint_tab.Text = "Reimprimir facturas";
            this.reprint_tab.UseVisualStyleBackColor = true;
            // 
            // create_bill_tab
            // 
            this.create_bill_tab.Location = new System.Drawing.Point(4, 22);
            this.create_bill_tab.Name = "create_bill_tab";
            this.create_bill_tab.Size = new System.Drawing.Size(838, 458);
            this.create_bill_tab.TabIndex = 3;
            this.create_bill_tab.Text = "Crear factura";
            this.create_bill_tab.UseVisualStyleBackColor = true;
            // 
            // Services_dataGridView
            // 
            this.Services_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services_dataGridView.Location = new System.Drawing.Point(6, 56);
            this.Services_dataGridView.Name = "Services_dataGridView";
            this.Services_dataGridView.Size = new System.Drawing.Size(826, 348);
            this.Services_dataGridView.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 526);
            this.Controls.Add(this.bill_tab_container);
            this.Name = "HomeForm";
            this.Text = "Mi sistema de facturación";
            this.bill_tab_container.ResumeLayout(false);
            this.adm_service_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Services_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bill_tab_container;
        private System.Windows.Forms.TabPage adm_bill_tab;
        private System.Windows.Forms.TabPage adm_service_tab;
        private System.Windows.Forms.TabPage reprint_tab;
        private System.Windows.Forms.TabPage create_bill_tab;
        private System.Windows.Forms.DataGridView Services_dataGridView;
    }
}

