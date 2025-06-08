using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using sistema_de_facturacion.Models;
using sistema_de_facturacion.Models.Connections;
using sistema_de_facturacion.Models.Provider;
using sistema_de_facturacion.Services.Documento;
using sistema_de_facturacion.Services.Facturacion;


namespace sistema_de_facturacion.FormsViews
{
    public partial class FrmFactura : Form
    {
        private Factura factura;
        private bool existeCliente = false;
        private string[] productoCache;
        List<Impuesto> impuestos;
        private FacturacionModel model;
        public FrmFactura()
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

        private void articulos_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;

            if (e.RowIndex >= 0 && dt.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string codigo = dt.Rows[e.RowIndex].Cells["header_codigo"].Value?.ToString();
                var confirmar = MessageBox.Show("Confirmar","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    factura.RemoverArticulo(codigo);
                }
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
                return;
            }

            Dictionary<string,object> parametros = new Dictionary<string, object>() {
                { "cliente_id", mskd.Text.Replace("-", "")}
            };

            ResultPattern<List<Clientes>> clientes =  model.GetClientes(parametros);

            if (!clientes.IsSuccess) {
                MessageBox.Show($"Error de verificacion de clientes {mskd.Text.Replace("-", "")} no se puede continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }


            if (clientes.Value.Count > 0) {

                txtNombreCliente.Text = clientes.Value[0].nombreCompleto;
                txtNombreCliente.ReadOnly = true;
                existeCliente = true;
                cboTipoPago.Select();
                return;


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
                MessageBox.Show("Debe seleccionar un el tipo de pago", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (this.ActiveControl.Name.ToString() == "txtCodigoProducto")
            {
                e.Cancel = false;
                return;
            }

            if (!decimal.TryParse(txtPago.Text,out decimal pago)){
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

            FrmClear();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            IFacturaGenerator facturaArchivo;


            if (factura.articulos.Count == 0)
            {
                MessageBox.Show("Nada que facturar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Insertar cliente si no existe
            if (!existeCliente) {


                Dictionary<string, object> paramsCliente = new Dictionary<string, object>()
                {
                    { "cliente_id", mktxtCodigoCliente.Text.Replace("-", "") },
                    { "nombreCompleto", txtNombreCliente.Text },
                };

                ResultPattern<int> insertCliente = model.InsertarCliente(paramsCliente);

                if (!insertCliente.IsSuccess)
                {
                    MessageBox.Show(insertCliente.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }

            factura.Cliente = txtNombreCliente.Text;

            //Insertar entrada de factura
            Dictionary<string, object> paramsFactura = new Dictionary<string, object>()
            {
                { "cliente_id", mktxtCodigoCliente.Text.Replace("-", "") },
                { "tipo_pago", cboTipoPago.Text },
                { "total", factura.TotalNeto.ToString() },
            };

            ResultPattern<List<FacturaIdResult>> insertFactura =  model.InsertarFactura(paramsFactura);

            if (!insertFactura.IsSuccess) {
                MessageBox.Show(insertFactura.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            factura.FacturaId = insertFactura.Value[0].factura_id.PadLeft(10, '0');


            //Insertar en
            ResultPattern<int> insertArticulo;
            Dictionary<string, object> paramsArticulo;

            foreach (Articulo item in factura.articulos)
            {
                paramsArticulo = new Dictionary<string, object> {
                    {"factura_id",insertFactura.Value[0].factura_id},
                    {"codigo",item.Codigo },
                    {"cantidad",item.Cantidad },
                    {"total_descuento",item.TotalDesc },
                    {"total_pagar",item.TotalNeto }
                };

                insertArticulo = model.InsertarFacturaProductos(paramsArticulo);

                if (!insertArticulo.IsSuccess)
                {
                    MessageBox.Show(insertArticulo.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }



            if (chkFacturaFiscal.Checked == true)
            {
                facturaArchivo = new FiscalPDF();
            }
            else
            {
                facturaArchivo = new TicketPDF();
            }

            try
            {
                facturaArchivo.GenerarFactura(factura);
                facturaArchivo.MostrarArchivo();
                FrmClear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
           

        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (articulos_dataGridView.CurrentRow != null)
            {
                DataGridViewRow fila = articulos_dataGridView.CurrentRow;

                string codigo = fila.Cells["header_codigo"].Value?.ToString();

                DialogResult confirmar = MessageBox.Show($"Desea eliminar el articulo {codigo}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    factura.RemoverArticulo(codigo);
                    factura.CalcularFacturaTotales();
                    txtTotal.Text = factura.Total.ToString();
                    txtDescTotal.Text = factura.TotalDesc.ToString();
                    txtNetoTotal.Text = factura.TotalNeto.ToString();
                }


            }
        }

        private void FrmClear() {

            var autoValidate = this.AutoValidate;
            this.AutoValidate = AutoValidate.Disable;

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
            chkFacturaFiscal.Checked = false;
            existeCliente = false;
            txtNombreCliente.ReadOnly = false;

            factura.LimpiarArticulos();
            factura = null;
            factura = new Factura(impuestos);
            articulos_dataGridView.DataSource = factura.articulos;

            cboTipoDocumento.Select();

            this.AutoValidate = autoValidate;
        }

    }
}
