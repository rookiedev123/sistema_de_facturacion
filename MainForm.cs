using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sistema_de_facturacion.FormsViews;
using sistema_de_facturacion.Services.Facturacion;

namespace sistema_de_facturacion
{
    public partial class HomeForm : Form
    {
        FrmFactura facturaForm;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            facturaForm = new FrmFactura();
            facturaForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();

        }

        private void btnReportesDeVentas_Click(object sender, EventArgs e)
        {
            FrmReporteVentasDocumento frmRepVta = new FrmReporteVentasDocumento();
            frmRepVta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReporteVentasDetalle frmRepVtaDet = new FrmReporteVentasDetalle();
            frmRepVtaDet.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }
    }
}
