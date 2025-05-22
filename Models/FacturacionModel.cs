using System;
using System.Collections.Generic;
using sistema_de_facturacion.Models.Provider;

namespace sistema_de_facturacion.Models
{
    internal class Clientes { 
    
        public string dui { set; get; }
        public string creado_en { set; get; }
        public string nombres { set; get; }
        public string apellidos { set; get; }


    }

    internal class Productos
    {

        public string codigo { set; get; }
        public string descripcion { set; get; }
        public decimal precio { set; get; }
        public decimal descuento { set; get; }


    }

    internal class FacturacionModel : ProviderSQL
    {
        public ResultPattern<List<Clientes>> GetClientes() {

            string sql = "select * from clientes";

            return this.SelectSentences<Clientes>(sql);

        }

        public ResultPattern<List<Productos>> GetProducts()
        {

            string sql = "select codigo,descripcion,precio,descuento from productos";

            return this.SelectSentences<Productos>(sql);

        }

        public ResultPattern<List<Productos>> GetProduct(Dictionary<string,object> parameter)
        {

            string sql = "select codigo,descripcion,precio,descuento from productos where codigo = @codigo";

            return this.SelectSentences<Productos>(sql, parameter);

        }

    }
}
