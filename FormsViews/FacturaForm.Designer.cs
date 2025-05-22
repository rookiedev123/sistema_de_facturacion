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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaForm));
            this.articulos_dataGridView = new System.Windows.Forms.DataGridView();
            this.header_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_total_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_total_pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mktxtCodigoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescTotal = new System.Windows.Forms.TextBox();
            this.txtNetoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescTotal = new System.Windows.Forms.Label();
            this.lblNetoTotal = new System.Windows.Forms.Label();
            this.lblCodigoArticulos = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDevolver = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // articulos_dataGridView
            // 
            this.articulos_dataGridView.AllowUserToAddRows = false;
            this.articulos_dataGridView.AllowUserToDeleteRows = false;
            this.articulos_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articulos_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articulos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulos_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_codigo,
            this.header_cantidad,
            this.header_description,
            this.header_precio,
            this.header_total_descuento,
            this.header_total,
            this.header_total_pagar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articulos_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.articulos_dataGridView.Location = new System.Drawing.Point(34, 152);
            this.articulos_dataGridView.Name = "articulos_dataGridView";
            this.articulos_dataGridView.Size = new System.Drawing.Size(1097, 239);
            this.articulos_dataGridView.TabIndex = 4;
            this.articulos_dataGridView.TabStop = false;
            // 
            // header_codigo
            // 
            this.header_codigo.DataPropertyName = "Codigo";
            this.header_codigo.FillWeight = 23.26558F;
            this.header_codigo.HeaderText = "CODIGO";
            this.header_codigo.Name = "header_codigo";
            this.header_codigo.ReadOnly = true;
            // 
            // header_cantidad
            // 
            this.header_cantidad.DataPropertyName = "Cantidad";
            this.header_cantidad.FillWeight = 22.91661F;
            this.header_cantidad.HeaderText = "CANTIDAD";
            this.header_cantidad.Name = "header_cantidad";
            this.header_cantidad.ReadOnly = true;
            // 
            // header_description
            // 
            this.header_description.DataPropertyName = "Descripcion";
            this.header_description.FillWeight = 76.74895F;
            this.header_description.HeaderText = "DESCRIPCION";
            this.header_description.Name = "header_description";
            // 
            // header_precio
            // 
            this.header_precio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "C2";
            this.header_precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.header_precio.FillWeight = 23.26558F;
            this.header_precio.HeaderText = "PRECIO";
            this.header_precio.Name = "header_precio";
            this.header_precio.ReadOnly = true;
            // 
            // header_total_descuento
            // 
            this.header_total_descuento.DataPropertyName = "TotalDesc";
            dataGridViewCellStyle2.Format = "C2";
            this.header_total_descuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.header_total_descuento.FillWeight = 23.26558F;
            this.header_total_descuento.HeaderText = "DESCUENTO";
            this.header_total_descuento.Name = "header_total_descuento";
            this.header_total_descuento.ReadOnly = true;
            // 
            // header_total
            // 
            this.header_total.DataPropertyName = "Total";
            this.header_total.FillWeight = 23.26558F;
            this.header_total.HeaderText = "TOTAL";
            this.header_total.Name = "header_total";
            // 
            // header_total_pagar
            // 
            this.header_total_pagar.DataPropertyName = "TotalNeto";
            dataGridViewCellStyle3.Format = "C2";
            this.header_total_pagar.DefaultCellStyle = dataGridViewCellStyle3;
            this.header_total_pagar.FillWeight = 23.26558F;
            this.header_total_pagar.HeaderText = "TOTAL PAGAR";
            this.header_total_pagar.Name = "header_total_pagar";
            this.header_total_pagar.ReadOnly = true;
            // 
            // mktxtCodigoCliente
            // 
            this.mktxtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktxtCodigoCliente.Location = new System.Drawing.Point(210, 73);
            this.mktxtCodigoCliente.Name = "mktxtCodigoCliente";
            this.mktxtCodigoCliente.Size = new System.Drawing.Size(274, 26);
            this.mktxtCodigoCliente.TabIndex = 1;
            this.mktxtCodigoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.mktxtCodigoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.mktxtCodigoCliente_Validating);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(210, 105);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(274, 26);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.txtNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreCliente_Validating);
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA",
            "PLAZO"});
            this.cboTipoPago.Location = new System.Drawing.Point(930, 103);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(201, 28);
            this.cboTipoPago.TabIndex = 3;
            this.cboTipoPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.cboTipoPago.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipoPago_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre cliente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de pago";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "DUI",
            "NIT"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(210, 39);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(274, 28);
            this.cboTipoDocumento.TabIndex = 0;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            this.cboTipoDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controls_KeyDown);
            this.cboTipoDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.cboTipoDocumento_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de documento";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Location = new System.Drawing.Point(930, 479);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(201, 26);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            // 
            // txtDescTotal
            // 
            this.txtDescTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDescTotal.Location = new System.Drawing.Point(930, 447);
            this.txtDescTotal.Name = "txtDescTotal";
            this.txtDescTotal.ReadOnly = true;
            this.txtDescTotal.Size = new System.Drawing.Size(201, 26);
            this.txtDescTotal.TabIndex = 0;
            this.txtDescTotal.TabStop = false;
            // 
            // txtNetoTotal
            // 
            this.txtNetoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetoTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNetoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetoTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNetoTotal.Location = new System.Drawing.Point(930, 511);
            this.txtNetoTotal.Name = "txtNetoTotal";
            this.txtNetoTotal.ReadOnly = true;
            this.txtNetoTotal.Size = new System.Drawing.Size(201, 26);
            this.txtNetoTotal.TabIndex = 0;
            this.txtNetoTotal.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(873, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total";
            // 
            // lblDescTotal
            // 
            this.lblDescTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescTotal.AutoSize = true;
            this.lblDescTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTotal.Location = new System.Drawing.Point(784, 482);
            this.lblDescTotal.Name = "lblDescTotal";
            this.lblDescTotal.Size = new System.Drawing.Size(138, 20);
            this.lblDescTotal.TabIndex = 17;
            this.lblDescTotal.Text = "Total descuento";
            // 
            // lblNetoTotal
            // 
            this.lblNetoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetoTotal.AutoSize = true;
            this.lblNetoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoTotal.Location = new System.Drawing.Point(832, 514);
            this.lblNetoTotal.Name = "lblNetoTotal";
            this.lblNetoTotal.Size = new System.Drawing.Size(90, 20);
            this.lblNetoTotal.TabIndex = 18;
            this.lblNetoTotal.Text = "Total neto";
            // 
            // lblCodigoArticulos
            // 
            this.lblCodigoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoArticulos.AutoSize = true;
            this.lblCodigoArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulos.Location = new System.Drawing.Point(848, 400);
            this.lblCodigoArticulos.Name = "lblCodigoArticulos";
            this.lblCodigoArticulos.Size = new System.Drawing.Size(74, 20);
            this.lblCodigoArticulos.TabIndex = 20;
            this.lblCodigoArticulos.Text = "Códigos";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(930, 397);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(201, 26);
            this.txtCodigoProducto.TabIndex = 4;
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(189, 502);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 35);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Image = global::sistema_de_facturacion.Properties.Resources.coin;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(34, 502);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(141, 35);
            this.btnFacturar.TabIndex = 0;
            this.btnFacturar.TabStop = false;
            this.btnFacturar.Text = "COBRAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // txtPago
            // 
            this.txtPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(166, 433);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(197, 35);
            this.txtPago.TabIndex = 5;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pago con";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Devolver";
            // 
            // txtDevolver
            // 
            this.txtDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolver.Location = new System.Drawing.Point(512, 435);
            this.txtDevolver.Name = "txtDevolver";
            this.txtDevolver.ReadOnly = true;
            this.txtDevolver.Size = new System.Drawing.Size(197, 35);
            this.txtDevolver.TabIndex = 22;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 568);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDevolver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblCodigoArticulos);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.lblNetoTotal);
            this.Controls.Add(this.lblDescTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNetoTotal);
            this.Controls.Add(this.txtDescTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.mktxtCodigoCliente);
            this.Controls.Add(this.articulos_dataGridView);
            this.KeyPreview = true;
            this.Name = "FacturaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView articulos_dataGridView;
        private System.Windows.Forms.MaskedTextBox mktxtCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescTotal;
        private System.Windows.Forms.TextBox txtNetoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescTotal;
        private System.Windows.Forms.Label lblNetoTotal;
        private System.Windows.Forms.Label lblCodigoArticulos;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_total_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_total_pagar;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDevolver;
    }
}