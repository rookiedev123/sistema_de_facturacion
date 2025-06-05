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
            facturaForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();

        }

        private void btnReportesDeVentas_Click(object sender, EventArgs e)
        {
            FrmReporteVentasDocumento frmRepVta = new FrmReporteVentasDocumento();
            frmRepVta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReporteVentasDetalle frmRepVtaDet = new FrmReporteVentasDetalle();
            frmRepVtaDet.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
