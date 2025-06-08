using sistema_de_facturacion.Models;
using sistema_de_facturacion.Models.Connections;
using sistema_de_facturacion.Models.Provider;
using sistema_de_facturacion.Services.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.FormsViews
{
    public partial class FrmReporteVentasDetalle : Form
    {

        FacturacionModel model;
        BindingList<productoFacturaDetalle> origenDatos;

        public FrmReporteVentasDetalle()
        {
            InitializeComponent();
        }

        private void FrmReporteVentasDetalle_Load(object sender, EventArgs e)
        {

            model = new FacturacionModel();
            model.SetConnectionString(new SqlDataConn());

            ResultPattern<List<Productos>> productos = model.GetProducts();

            if (!productos.IsSuccess)
            {
                MessageBox.Show(productos.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] ProductoCache = productos.Value.Select(p => p.codigo).ToArray();


            foreach (string item in ProductoCache)
            {
                cbxProductos.Items.Add(item);
            }

            origenDatos = new BindingList<productoFacturaDetalle>();
            dtgfacturas_producto.DataSource = origenDatos;
        }


        private void btnActualizarRepVtaDet_Click(object sender, EventArgs e)
        {

            origenDatos.Clear();

            DateTime inicio = dtpDesde.Value;
            DateTime final = dtpHasta.Value;



            Dictionary<string, object> parameters = new Dictionary<string, object>() {
                {"codigo", cbxProductos.Text},
                {"fechaInicio", inicio.ToString("yyyy-MM-dd 00:00:00")},
                {"fechaFin", final.ToString("yyyy-MM-dd 23:59:59")}

            };

            ResultPattern<List<productoFacturaDetalle>> productDetalle = model.GetCodigoDetalle(parameters);


            if (!productDetalle.IsSuccess)
            {
                MessageBox.Show(productDetalle.Error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            foreach (productoFacturaDetalle item in productDetalle.Value)
            {
                origenDatos.Add(item);
            }


        }

      
    }
}