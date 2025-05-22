using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using sistema_de_facturacion.Services.Facturacion;


namespace sistema_de_facturacion.Forms
{
    public partial class FacturaForm : Form
    {
        private Factura factura;
        private string[] listadoArticulos;
        public FacturaForm()
        {
            InitializeComponent();
            List<Impuesto> impuestos = new List<Impuesto>() {
                new Impuesto("IVA",0.13)
            };
            this.factura = new Factura(impuestos);
            //articulos_dataGridView.DataSource = factura.articulos;
            articulos_dataGridView.Rows.Add();

            listadoArticulos = new string[] { "arar", "sas", "asas", "asqsdfgf" };
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {





        }

        private void articulo_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                //btn_agregar.PerformClick();
            }
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            TicketForm ticket = new TicketForm(this.factura);

            ticket.ShowDialog();

            ticket.Close();
            ticket.Dispose();
        }

    }
}
