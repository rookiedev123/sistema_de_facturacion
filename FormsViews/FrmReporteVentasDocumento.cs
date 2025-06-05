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
            DateTime fechaHasta = dtpHastaR.Value.Date.AddDays(1).AddSeconds(-1); // hasta fin del día

            // Obtener la cadena de conexión desde SqlDataConn
            var conexionSql = new sistema_de_facturacion.Models.Connections.SqlDataConn();
            string cadenaConexion = conexionSql.getConnectionString();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ReporteVentasPorCliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clienteId", clienteId);
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgReporteVentas.DataSource = dt;
            }
        }

    }
}

