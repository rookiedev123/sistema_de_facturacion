using sistema_de_facturacion.Models;
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
            //TODO: esta línea de código carga datos en la tabla 'productosDataSet1.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.productosDataSet1.productos);
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
                try
                {
                    string query = @"
                SELECT
                    p.codigo as 'Codigo Producto',
                    p.descripcion as Descripcion,
                    f.factura_id as 'Número de Factura',
                    f.creado_en as Fecha,
                    fp.cantidad as Cantidad,
                    fp.total_descuento as Descuento,
                    fp.total_pagar as Total
		            FROM facturas_productos fp
		            INNER JOIN productos p ON fp.producto_id = p.producto_id
		            INNER JOIN facturas f ON fp.factura_id = f.factura_id
		            WHERE fp.producto_id = @productoId
		            AND f.creado_en BETWEEN @fechaDesde AND DATEADD(SECOND, -1, DATEADD(DAY, 1, @fechaHasta))";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@productoId", producto_id);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgfacturas_producto.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese datos correctos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }


        }
    }
}