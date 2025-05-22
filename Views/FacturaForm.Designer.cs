namespace sistema_de_facturacion.Forms
{
    partial class FacturaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.articulos_dataGridView = new System.Windows.Forms.DataGridView();
            this.header_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_porc_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_total_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_total_pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.mktxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // articulos_dataGridView
            // 
            this.articulos_dataGridView.AllowUserToAddRows = false;
            this.articulos_dataGridView.AllowUserToResizeRows = false;
            this.articulos_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articulos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articulos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulos_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_codigo,
            this.header_cantidad,
            this.header_precio,
            this.header_porc_descuento,
            this.header_total_descuento,
            this.header_total_pagar});
            this.articulos_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articulos_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.articulos_dataGridView.Location = new System.Drawing.Point(17, 111);
            this.articulos_dataGridView.MultiSelect = false;
            this.articulos_dataGridView.Name = "articulos_dataGridView";
            this.articulos_dataGridView.Size = new System.Drawing.Size(959, 283);
            this.articulos_dataGridView.TabIndex = 0;
            // 
            // header_codigo
            // 
            this.header_codigo.DataPropertyName = "Codigo";
            this.header_codigo.HeaderText = "CODIGO";
            this.header_codigo.Name = "header_codigo";
            this.header_codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // header_cantidad
            // 
            this.header_cantidad.DataPropertyName = "Cantidad";
            this.header_cantidad.HeaderText = "CANTIDAD";
            this.header_cantidad.Name = "header_cantidad";
            // 
            // header_precio
            // 
            this.header_precio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "C2";
            this.header_precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.header_precio.HeaderText = "PRECIO";
            this.header_precio.Name = "header_precio";
            this.header_precio.ReadOnly = true;
            // 
            // header_porc_descuento
            // 
            this.header_porc_descuento.DataPropertyName = "Descuento";
            this.header_porc_descuento.HeaderText = "% DESCUENTO";
            this.header_porc_descuento.Name = "header_porc_descuento";
            // 
            // header_total_descuento
            // 
            this.header_total_descuento.DataPropertyName = "TotalDescuento";
            dataGridViewCellStyle2.Format = "C2";
            this.header_total_descuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.header_total_descuento.HeaderText = "TOTAL DESCUENTO";
            this.header_total_descuento.Name = "header_total_descuento";
            // 
            // header_total_pagar
            // 
            this.header_total_pagar.DataPropertyName = "TotalPagar";
            dataGridViewCellStyle3.Format = "C2";
            this.header_total_pagar.DefaultCellStyle = dataGridViewCellStyle3;
            this.header_total_pagar.HeaderText = "TOTAL PAGAR";
            this.header_total_pagar.Name = "header_total_pagar";
            // 
            // total_textBox
            // 
            this.total_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.total_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_textBox.Location = new System.Drawing.Point(707, 400);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.Size = new System.Drawing.Size(264, 55);
            this.total_textBox.TabIndex = 3;
            this.total_textBox.Text = "0";
            this.total_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_facturar
            // 
            this.btn_facturar.Location = new System.Drawing.Point(12, 463);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(157, 33);
            this.btn_facturar.TabIndex = 4;
            this.btn_facturar.Text = "IMPRIMIR";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // mktxtDUI
            // 
            this.mktxtDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxtDUI.Location = new System.Drawing.Point(148, 34);
            this.mktxtDUI.Mask = "99999999-9";
            this.mktxtDUI.Name = "mktxtDUI";
            this.mktxtDUI.Size = new System.Drawing.Size(122, 26);
            this.mktxtDUI.TabIndex = 0;
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(13, 34);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(41, 20);
            this.lblDUI.TabIndex = 1;
            this.lblDUI.Text = "DUI";
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(180, 69);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(224, 26);
            this.txt.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(13, 69);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(129, 20);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre cliente";
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 510);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.mktxtDUI);
            this.Controls.Add(this.total_textBox);
            this.Controls.Add(this.articulos_dataGridView);
            this.KeyPreview = true;
            this.Name = "FacturaForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.articulos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView articulos_dataGridView;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.MaskedTextBox mktxtDUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_porc_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_total_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_total_pagar;
    }
}