using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using sistema_de_facturacion.Models;
using sistema_de_facturacion.Models.Connections;
using sistema_de_facturacion.Models.Provider;


namespace sistema_de_facturacion.FormsViews
{
    public partial class FrmReporteVentasDocumento : Form
    {
        FacturacionModel model;
        BindingList<FacturaCliente> origenDatos;

        public FrmReporteVentasDocumento()
        {
            InitializeComponent();
        }

        private void frmReporteDeVentas_Load(object sender, EventArgs e)
        {
            model = new FacturacionModel();
            model.SetConnectionString(new SqlDataConn());

            ResultPattern<List<Clientes>> clientes = model.GetClientesAll();

            if (!clientes.IsSuccess) {
                MessageBox.Show(clientes.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] clienteCache = clientes.Value.Select(p => p.cliente_id).ToArray();


            foreach (string item in clienteCache)
            {
                cbxBuscadorClientes.Items.Add(item);
            }

            origenDatos = new BindingList<FacturaCliente>();
            dtgReporteVentas.DataSource = origenDatos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            origenDatos.Clear();
        
            DateTime inicio = dtpDesdeR.Value;
            DateTime final = dtpHastaR.Value;



            Dictionary<string,object> parameters = new Dictionary<string, object>() {
                {"clienteBuscado", cbxBuscadorClientes.Text},
                {"fechaInicio", inicio.ToString("yyyy-MM-dd 00:00:00")},
                {"fechaFin", final.ToString("yyyy-MM-dd 23:59:59")}

            };

            ResultPattern<List<FacturaCliente>> clientes = model.GetFacturaCliente(parameters);


            if (!clientes.IsSuccess) {
                MessageBox.Show(clientes.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            foreach (FacturaCliente item in clientes.Value)
            {
                origenDatos.Add(item);
            }


        }

    }
}

