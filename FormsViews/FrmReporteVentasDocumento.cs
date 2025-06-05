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


namespace sistema_de_facturacion.FormsViews
{
    public partial class FrmReporteVentasDocumento : Form
    {
        public FrmReporteVentasDocumento()
        {
            InitializeComponent();
        }

        private void frmReporteDeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteria_facturacionDataSet2.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.ferreteria_facturacionDataSet2.clientes);
           
            dtgReporteVentas.DataSource = null;
            dtgReporteVentas.Rows.Clear();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(cbxBuscadorClientes.SelectedValue);
            DateTime fechaDesde = dtpDesdeR.Value.Date;
            DateTime fechaHasta = dtpHastaR.Value.Date.AddDays(1).AddSeconds(-1);

            var conexionSql = new sistema_de_facturacion.Models.Connections.SqlDataConn();
            string cadenaConexion = conexionSql.getConnectionString();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    string query = @"
                SELECT 
                        f.factura_id as Factura,
                        c.document as Documento,
                        c.nombres as Nombres,
                        c.apellidos as Apellidos,
                        p.codigo as 'Codigo Producto',
                        p.descripcion as Descripción,
                        fp.cantidad as Cantidad,
                        fp.total_descuento as Descuento,
                        fp.total_pagar as Total
		                FROM facturas f
		                INNER JOIN clientes c ON f.clienteId = c.clienteId
		                INNER JOIN facturas_productos fp ON f.factura_id = fp.factura_id
		                INNER JOIN productos p ON fp.producto_id = p.producto_id
		                WHERE f.clienteId = @clienteId
		                AND f.creado_en BETWEEN @fechaDesde AND DATEADD(SECOND, -1, DATEADD(DAY, 1, @fechaHasta))";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgReporteVentas.DataSource = dt;
                }
                catch (Exception ex) 
                
                {
                    MessageBox.Show("Ingresar datos correctos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

    }
}

