using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using sistema_de_facturacion.Services.Facturacion;


namespace sistema_de_facturacion.Forms
{
    public partial class FacturaForm : Form
    {
        private Factura factura;
        public FacturaForm()
        {
            InitializeComponent();
            List<Impuesto> impuesto = new List<Impuesto>() {
                new Impuesto("IVA",0.13)
            };
            this.factura = new Factura(impuesto);
            articulos_dataGridView.DataSource = factura.articulos;
            articulo_comboBox.Select();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (articulo_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un articulo", "Hay un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btn_agregar.Enabled = false;

            Articulo articulo = new Articulo()
            {
                Codigo = articulo_comboBox.SelectedItem.ToString(),
                Cantidad = 1,
                Precio = 123,
                Descuento = 0.255

            };

            
            this.factura.AgregarArticulo(articulo);
            articulo_comboBox.SelectedIndex = -1;
            btn_agregar.Enabled = true;

            total_textBox.Text = String.Format("$ {0}",factura.CalcularFacturaTotal().ToString());

        }

        private void articulo_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
            
                btn_agregar.PerformClick();
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
