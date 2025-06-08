using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.FormsViews
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x0010)
            {
                var autoValidate = this.AutoValidate;
                this.AutoValidate = AutoValidate.Disable;
                base.WndProc(ref m);
                this.AutoValidate = autoValidate;
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productosDataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.productosDataSet.productos);
            this.productosTableAdapter.ClearBeforeFill = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.productosBindingSource.AddNew();
            btnAgregar.Enabled = false;
            codigoMaskedTextBox.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) {
                MessageBox.Show("Ingrese los campos necesarios");
                return;
            }
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productosDataSet);
            btnAgregar.Enabled = true;

        }

        private void productosDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView dt = sender as DataGridView;

        }

        private void codigoMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            if(!maskedTextBox.MaskFull){
                MessageBox.Show("Debe completar el código");
                e.Cancel = true;
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            var autoValidate = this.AutoValidate;
            this.AutoValidate = AutoValidate.Disable;

            this.productosBindingSource.CancelEdit();
            this.productosDataSet.RejectChanges();
            btnAgregar.Enabled = true;

            this.AutoValidate = autoValidate;
            

        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            productosDataSet.Dispose();
        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productosDataSet);

        }
    }
}
