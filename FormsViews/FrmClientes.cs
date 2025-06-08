using sistema_de_facturacion.Datasets;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }



        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDataSet);

        }


        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.clientesDataSet.clientes);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                MessageBox.Show("Ingrese los campos necesarios");
                return;
            }
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDataSet);
            btnAgregar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.CancelEdit();
            this.clientesDataSet.RejectChanges();
            btnAgregar.Enabled = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.AddNew();
            btnAgregar.Enabled = false;
            documentIdTextBox.Select();
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientesDataSet.Dispose();
        }

        private void AllTextBox_Validating(object sender, CancelEventArgs e)
        {

            TextBox t = sender as TextBox;

            if (t.Text == string.Empty) {
                MessageBox.Show("Ingrese los campos necesarios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t.Select();
                e.Cancel = true;
            }
        }
    }
}
