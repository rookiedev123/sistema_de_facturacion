using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sistema_de_facturacion.Forms;
using sistema_de_facturacion.FormsViews;
using sistema_de_facturacion.Services.Facturacion;

namespace sistema_de_facturacion
{
    public partial class HomeForm : Form
    {
        FacturaForm facturaForm;
        public HomeForm()
        {
            InitializeComponent();


        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            facturaForm = new FacturaForm();
            facturaForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();

        }
    }
}
