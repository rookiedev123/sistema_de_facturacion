using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.FormsViews
{
    public partial class FrmReporteVentasDetalle : Form
    {
        public FrmReporteVentasDetalle()
        {
            InitializeComponent();
        }

        private void facturas_productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturas_productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ferreteria_facturacionDataSet3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.productos' 
            this.productosTableAdapter.Fill(this.productosDataSet.productos);
            /*// TODO: esta línea de código carga datos en la tabla 'ferreteria_facturacionDataSet3.facturas_productos'
            this.facturas_productosTableAdapter.Fill(this.ferreteria_facturacionDataSet3.facturas_productos);*/

        }

        private void btnActualizarRepVtaDet_Click(object sender, EventArgs e)
        {
            int producto_id = Convert.ToInt32(cbxProductos.SelectedValue);
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

            var conexionSql = new sistema_de_facturacion.Models.Connections.SqlDataConn();
            string cadenaConexion = conexionSql.getConnectionString();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ReporteVentasDetalleProd",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productoId", producto_id);
                cmd.Parameters.AddWithValue("@fechaDesde",fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta",fechaHasta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgfacturas_producto.DataSource = dt;
            }

        }
    }
}