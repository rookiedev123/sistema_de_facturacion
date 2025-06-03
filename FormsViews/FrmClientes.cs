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

        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.clientes' Puede moverla o quitarla según sea necesario.
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

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientesDataSet.Dispose();
        }
    }
}
