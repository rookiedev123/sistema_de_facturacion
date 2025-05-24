using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using sistema_de_facturacion.Models;
using sistema_de_facturacion.Models.Connections;
using sistema_de_facturacion.Models.Provider;
using sistema_de_facturacion.Services.Facturacion;
using sistema_de_facturacion.Services.PdfGenerador;


namespace sistema_de_facturacion.Forms
{
    public partial class FacturaForm : Form
    {
        private Factura factura;
        private string[] productoCache;
        List<Impuesto> impuestos;
        private FacturacionModel model;
        public FacturaForm()
        {
            InitializeComponent();
            impuestos = new List<Impuesto>() {
                new Impuesto("IVA",0.13m)
            };
            this.factura = new Factura(impuestos);
            articulos_dataGridView.DataSource = factura.articulos;
            cboTipoDocumento.Select();

        }

        //Evento formulario
        private void FacturaForm_Load(object sender, EventArgs e)
        {
            model = new FacturacionModel();
            model.SetConnectionString(new SqlDataConn());

            ResultPattern<List<Productos>> productos = model.GetProducts();

            if (!productos.IsSuccess)
            {
                MessageBox.Show(productos.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productoCache = productos.Value.Select(p => p.codigo).ToArray();

            txtCodigoProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCodigoProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(productoCache);

            txtCodigoProducto.AutoCompleteCustomSource = autoComplete;

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


        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtPrdc = sender as TextBox;


            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!productoCache.Contains(txtPrdc.Text)) return;

                Dictionary<string, object> parameters = new Dictionary<string, object>() {
                    {"codigo", txtPrdc.Text}
                };

                ResultPattern<List<Productos>> productos = model.GetProduct(parameters);

                if (!productos.IsSuccess)
                {

                    MessageBox.Show(productos.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Articulo articulo = new Articulo() { 
                
                    Codigo = productos.Value[0].codigo,
                    Descripcion = productos.Value[0].descripcion,
                    Cantidad = 1,
                    Descuento = productos.Value[0].descuento,
                    Precio = productos.Value[0].precio,
                };

                factura.AgregarArticulo(articulo);

                factura.CalcularFacturaTotales();

                txtTotal.Text = factura.Total.ToString();
                txtDescTotal.Text = factura.TotalDesc.ToString();
                txtNetoTotal.Text = factura.TotalNeto.ToString();

                txtPrdc.Text = "";

            }
            else if (e.KeyCode == Keys.Tab) {
                e.SuppressKeyPress = true;
                e.Handled = true; 
            }

           

        }
        private void btn_facturar_Click(object sender, EventArgs e)
        {
            TicketForm ticket = new TicketForm(this.factura);

            ticket.ShowDialog();

            ticket.Close();
            ticket.Dispose();
        }


        //Eventos de cboTipoDocumento
        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboTipoDocumento = sender as ComboBox;

            if (cboTipoDocumento.Text == "DUI")
            {
                mktxtCodigoCliente.Mask = "99999999-9";
            }
            else if (cboTipoDocumento.Text == "NIT")
            {
                mktxtCodigoCliente.Mask = "999-999999-999-9";
            }
            else
            {
                mktxtCodigoCliente.Mask = "";
            }
        }
        private void cboTipoDocumento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ComboBox cboTipoDocumento = sender as ComboBox;


            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un el tipo de documento","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
                mktxtCodigoCliente.Mask = "";
            }
        }

        //Eventos de mktxtCodigoCliente
        private void mktxtCodigoCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox mskd = sender as MaskedTextBox;

            if (this.ActiveControl.Name.ToString() == "cboTipoDocumento")
            {
                e.Cancel = false;
                return;
            }

            if (mskd.MaskFull == false) {
                MessageBox.Show("Debe completar el formato del campo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

        }

        //Eventos de txtNombreCliente
        private void txtNombreCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            TextBox nombreCliente = sender as TextBox;

            if (String.IsNullOrWhiteSpace(nombreCliente.Text)){
                e.Cancel = true;
                return;
            }



        }

        //Eventos de cboTipoPago
        private void cboTipoPago_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ComboBox cboTipoDocumento = sender as ComboBox;

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un el tipo de documento", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        //Eventos de txtPago
        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsControl(ch))
                return;

            // Solo permitir un punto decimal y no como primer carácter
            if (ch == '.')
            {
                if (txtPago.Text.Contains('.') || txtPago.SelectionStart == 0)
                {
                    e.Handled = true;
                    return;
                }
                return;
            }

            if (!char.IsDigit(ch))
            {
                e.Handled = true;
                return;
            }

            // Si ya hay un punto, limitar a 2 decimales
            string text = txtPago.Text;
            int cursorPos = txtPago.SelectionStart;

            if (text.Contains("."))
            {
                int decimalIndex = text.IndexOf(".");
                int decimals = text.Length - decimalIndex - (cursorPos <= decimalIndex ? 1 : 0);
                if (cursorPos > decimalIndex && decimals >= 3)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            string txt = tb.Text;
            decimal valor = 0;
            decimal devolver = 0;

            if (txt.Length > 1 && txt.StartsWith("0") && !txt.StartsWith("0."))
            {
                if (decimal.TryParse(txt, out valor))
                {
                    tb.Text = valor.ToString();
                    tb.SelectionStart = tb.Text.Length;
                }
            }
            else {
                if(txt.Length > 1){
                    valor = decimal.Parse(txt);
                }
            }

            devolver = Math.Round(valor - factura.TotalNeto,2);

            if (devolver > 0)
            {
                txtDevolver.Text = devolver.ToString();
            }
            else {

                txtDevolver.Text = "0";
            }


        }
        private void txtPago_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(decimal.TryParse(txtPago.Text,out decimal pago)){
                MessageBox.Show("Debe ingresar un número valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            if (pago < factura.TotalNeto) {
                MessageBox.Show("No se ha cubierto el pago", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }


        //Eventos generales
        private void controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Previene el 'ding' o comportamiento predeterminado
                SendKeys.Send("{TAB}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            cboTipoDocumento.SelectedIndex = -1;
            mktxtCodigoCliente.Text = String.Empty;
            mktxtCodigoCliente.Mask = String.Empty;
            txtNombreCliente.Text = String.Empty;
            cboTipoPago.SelectedIndex = -1;
            txtCodigoProducto.Text = String.Empty;
            txtPago.Text = String.Empty;
            txtTotal.Text = String.Empty;
            txtDescTotal.Text = String.Empty;
            txtNetoTotal.Text = String.Empty;
            txtDevolver.Text = String.Empty;


            factura = null;
            factura = new Factura(impuestos);
            articulos_dataGridView.DataSource = factura.articulos;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FacturaPDF  fctPdf = new FacturaPDF();

            fctPdf.CrearFactura();
            fctPdf.OpenFile();

        }
    }
}
