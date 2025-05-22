using sistema_de_facturacion.Services.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Forms
{
    public partial class TicketForm : Form
    {
        private Factura factura;

        public TicketForm(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;
            this.GenerarFactura();
        }

        private void GenerarFactura() {

            /*
            double total = 0;

            ticket_richTextBox.AppendText("============= FACTURA ============\n");
            ticket_richTextBox.AppendText("========== FERRETERIA MAX ========\n\n\n");


            foreach (Articulo articulo in this.factura.articulos){

                total += articulo.TotalPagar;

                ticket_richTextBox.AppendText(String.Format("{0} ${1}\n", articulo.Codigo.PadRight(45, '.'), articulo.TotalPagar));

                if (articulo.Cantidad == 1) { continue; }

                ticket_richTextBox.AppendText(String.Format("\t\t1x@{0}\t{1}\n", articulo.Cantidad, articulo.TotalPagar));

            }


            ticket_richTextBox.AppendText(String.Format("\n\n\n\n\t\tTOTAL\t${0}\n", total));

            */


        }
    }
}
