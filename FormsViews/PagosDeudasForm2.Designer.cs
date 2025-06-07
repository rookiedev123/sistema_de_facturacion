namespace sistema_de_facturacion.FormsViews
{
    partial class PagosDeudasForm2
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
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosDeudasForm2));
            this.ferreteria_facturacionDataSet = new sistema_de_facturacion.ferreteria_facturacionDataSet();
            this.reporte_pagos_deudasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_pagos_deudasTableAdapter = new sistema_de_facturacion.ferreteria_facturacionDataSetTableAdapters.reporte_pagos_deudasTableAdapter();
            this.tableAdapterManager = new sistema_de_facturacion.ferreteria_facturacionDataSetTableAdapters.TableAdapterManager();
            this.reporte_pagos_deudasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reporte_pagos_deudasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reporte_pagos_deudasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.nombresLabel1 = new System.Windows.Forms.Label();
            this.apellidosLabel1 = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_pagos_deudasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_pagos_deudasBindingNavigator)).BeginInit();
            this.reporte_pagos_deudasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_pagos_deudasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(27, 78);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(53, 13);
            clienteIdLabel.TabIndex = 2;
            clienteIdLabel.Text = "cliente Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(207, 75);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(50, 13);
            nombresLabel.TabIndex = 4;
            nombresLabel.Text = "nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(398, 74);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "apellidos:";
            // 
            // ferreteria_facturacionDataSet
            // 
            this.ferreteria_facturacionDataSet.DataSetName = "ferreteria_facturacionDataSet";
            this.ferreteria_facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_pagos_deudasBindingSource
            // 
            this.reporte_pagos_deudasBindingSource.DataMember = "reporte_pagos_deudas";
            this.reporte_pagos_deudasBindingSource.DataSource = this.ferreteria_facturacionDataSet;
            // 
            // reporte_pagos_deudasTableAdapter
            // 
            this.reporte_pagos_deudasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.facturas_productosTableAdapter = null;
            this.tableAdapterManager.facturasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.reporte_pagos_deudasTableAdapter = this.reporte_pagos_deudasTableAdapter;
            this.tableAdapterManager.UpdateOrder = sistema_de_facturacion.ferreteria_facturacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // reporte_pagos_deudasBindingNavigator
            // 
            this.reporte_pagos_deudasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reporte_pagos_deudasBindingNavigator.BindingSource = this.reporte_pagos_deudasBindingSource;
            this.reporte_pagos_deudasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reporte_pagos_deudasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reporte_pagos_deudasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.reporte_pagos_deudasBindingNavigatorSaveItem});
            this.reporte_pagos_deudasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reporte_pagos_deudasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reporte_pagos_deudasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reporte_pagos_deudasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reporte_pagos_deudasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reporte_pagos_deudasBindingNavigator.Name = "reporte_pagos_deudasBindingNavigator";
            this.reporte_pagos_deudasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reporte_pagos_deudasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.reporte_pagos_deudasBindingNavigator.TabIndex = 0;
            this.reporte_pagos_deudasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reporte_pagos_deudasBindingNavigatorSaveItem
            // 
            this.reporte_pagos_deudasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reporte_pagos_deudasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reporte_pagos_deudasBindingNavigatorSaveItem.Image")));
            this.reporte_pagos_deudasBindingNavigatorSaveItem.Name = "reporte_pagos_deudasBindingNavigatorSaveItem";
            this.reporte_pagos_deudasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reporte_pagos_deudasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.reporte_pagos_deudasBindingNavigatorSaveItem.Click += new System.EventHandler(this.reporte_pagos_deudasBindingNavigatorSaveItem_Click);
            // 
            // reporte_pagos_deudasDataGridView
            // 
            this.reporte_pagos_deudasDataGridView.AutoGenerateColumns = false;
            this.reporte_pagos_deudasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporte_pagos_deudasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.reporte_pagos_deudasDataGridView.DataSource = this.reporte_pagos_deudasBindingSource;
            this.reporte_pagos_deudasDataGridView.Location = new System.Drawing.Point(12, 166);
            this.reporte_pagos_deudasDataGridView.Name = "reporte_pagos_deudasDataGridView";
            this.reporte_pagos_deudasDataGridView.Size = new System.Drawing.Size(741, 272);
            this.reporte_pagos_deudasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clienteId";
            this.dataGridViewTextBoxColumn1.HeaderText = "clienteId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombres";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_pago";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_pago";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pago";
            this.dataGridViewTextBoxColumn5.HeaderText = "pago";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "deuda";
            this.dataGridViewTextBoxColumn6.HeaderText = "deuda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_ultimo_pago";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_ultimo_pago";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha_proximo_pago";
            this.dataGridViewTextBoxColumn8.HeaderText = "fecha_proximo_pago";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "monto_pago";
            this.dataGridViewTextBoxColumn9.HeaderText = "monto_pago";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reporte_pagos_deudasBindingSource, "clienteId", true));
            this.clienteIdTextBox.Location = new System.Drawing.Point(86, 75);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteIdTextBox.TabIndex = 3;
            // 
            // nombresLabel1
            // 
            this.nombresLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reporte_pagos_deudasBindingSource, "nombres", true));
            this.nombresLabel1.Location = new System.Drawing.Point(263, 75);
            this.nombresLabel1.Name = "nombresLabel1";
            this.nombresLabel1.Size = new System.Drawing.Size(116, 23);
            this.nombresLabel1.TabIndex = 5;
            this.nombresLabel1.Text = "label1";
            // 
            // apellidosLabel1
            // 
            this.apellidosLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reporte_pagos_deudasBindingSource, "apellidos", true));
            this.apellidosLabel1.Location = new System.Drawing.Point(455, 74);
            this.apellidosLabel1.Name = "apellidosLabel1";
            this.apellidosLabel1.Size = new System.Drawing.Size(100, 23);
            this.apellidosLabel1.TabIndex = 7;
            this.apellidosLabel1.Text = "label1";
            // 
            // PagosDeudasForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosLabel1);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresLabel1);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(this.reporte_pagos_deudasDataGridView);
            this.Controls.Add(this.reporte_pagos_deudasBindingNavigator);
            this.Name = "PagosDeudasForm2";
            this.Text = "Pagos y Deudas";
            this.Load += new System.EventHandler(this.PagosDeudasForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteria_facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_pagos_deudasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_pagos_deudasBindingNavigator)).EndInit();
            this.reporte_pagos_deudasBindingNavigator.ResumeLayout(false);
            this.reporte_pagos_deudasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_pagos_deudasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ferreteria_facturacionDataSet ferreteria_facturacionDataSet;
        private System.Windows.Forms.BindingSource reporte_pagos_deudasBindingSource;
        private ferreteria_facturacionDataSetTableAdapters.reporte_pagos_deudasTableAdapter reporte_pagos_deudasTableAdapter;
        private ferreteria_facturacionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reporte_pagos_deudasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton reporte_pagos_deudasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView reporte_pagos_deudasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.Label nombresLabel1;
        private System.Windows.Forms.Label apellidosLabel1;
    }
}