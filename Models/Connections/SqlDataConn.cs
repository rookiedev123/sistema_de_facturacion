using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Models.Connections
{
    internal class SqlDataConn : IConnectionString
    {
        private string database = "ferreteria_facturacion";

        public string getConnectionString()
        {

            string execPath = AppContext.BaseDirectory;

            return String.Format(@"Server=(localdb)\MSSQLLocalDB;
                            Integrated Security=true;
                            AttachDbFilename={0}Data\{1}.mdf;", execPath, database);

        }
    }
}
