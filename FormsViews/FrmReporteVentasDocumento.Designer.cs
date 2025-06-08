namespace sistema_de_facturacion.FormsViews
{
    partial class FrmReporteVentasDocumento
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
            this.dtpDesdeR = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaR = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cbxBuscadorClientes = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dtgReporteVentas = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesdeR
            // 
            this.dtpDesdeR.Location = new System.Drawing.Point(29, 45);
            this.dtpDesdeR.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesdeR.Name = "dtpDesdeR";
            this.dtpDesdeR.Size = new System.Drawing.Size(224, 20);
            this.dtpDesdeR.TabIndex = 0;
            // 
            // dtpHastaR
            // 
            this.dtpHastaR.Location = new System.Drawing.Point(303, 45);
            this.dtpHastaR.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHastaR.Name = "dtpHastaR";
            this.dtpHastaR.Size = new System.Drawing.Size(222, 20);
            this.dtpHastaR.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(26, 11);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(70, 24);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(301, 7);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(62, 24);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // cbxBuscadorClientes
            // 
            this.cbxBuscadorClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBuscadorClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBuscadorClientes.BackColor = System.Drawing.Color.Silver;
            this.cbxBuscadorClientes.DisplayMember = "nombres";
            this.cbxBuscadorClientes.FormattingEnabled = true;
            this.cbxBuscadorClientes.Location = new System.Drawing.Point(29, 107);
            this.cbxBuscadorClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBuscadorClientes.Name = "cbxBuscadorClientes";
            this.cbxBuscadorClientes.Size = new System.Drawing.Size(495, 21);
            this.cbxBuscadorClientes.TabIndex = 4;
            this.cbxBuscadorClientes.ValueMember = "clienteId";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(26, 72);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(85, 24);
            this.lblClientes.TabIndex = 5;
            this.lblClientes.Text = "Clientes";
            // 
            // dtgReporteVentas
            // 
            this.dtgReporteVentas.AllowUserToAddRows = false;
            this.dtgReporteVentas.AllowUserToDeleteRows = false;
            this.dtgReporteVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReporteVentas.Location = new System.Drawing.Point(29, 149);
            this.dtgReporteVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgReporteVentas.Name = "dtgReporteVentas";
            this.dtgReporteVentas.ReadOnly = true;
            this.dtgReporteVentas.RowHeadersWidth = 51;
            this.dtgReporteVentas.RowTemplate.Height = 24;
            this.dtgReporteVentas.Size = new System.Drawing.Size(957, 332);
            this.dtgReporteVentas.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Lavender;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(587, 37);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(143, 76);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmReporteVentasDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 516);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgReporteVentas);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHastaR);
            this.Controls.Add(this.dtpDesdeR);
            this.Controls.Add(this.cbxBuscadorClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporteVentasDocumento";
            this.Text = "REPORTE DE VENTAS";
            this.Load += new System.EventHandler(this.frmReporteDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReporteVentas)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgReporteVentas;
        private System.Windows.Forms.Button btnActualizar;
    }
}