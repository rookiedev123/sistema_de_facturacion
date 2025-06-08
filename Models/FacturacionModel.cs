using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using sistema_de_facturacion.Models.Provider;

namespace sistema_de_facturacion.Models
{
    internal class Clientes { 
    
        public string cliente_id { set; get; }
        public string nombreCompleto { set; get; }


    }

    internal class Productos
    {

        public string codigo { set; get; }
        public string descripcion { set; get; }
        public decimal precio { set; get; }
        public decimal descuento { set; get; }


    }

    internal class FacturaIdResult
    {

        public string factura_id { set; get; }



    }

    internal class FacturacionModel : ProviderSQL
    {
        public ResultPattern<List<Clientes>> GetClientes(Dictionary<string, object> parameter) {

            string sql = "select * from clientes where cliente_id = @cliente_id";

            return this.SelectSentences<Clientes>(sql, parameter);

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


        public ResultPattern<int> InsertarCliente(Dictionary<string, object> parameters)
        {


            string sql = @"INSERT INTO Clientes(cliente_id,nombreCompleto)
            values(@cliente_id,@nombreCompleto)";

            return ExecuteSentences(sql, parameters);

        }

        public ResultPattern<List<FacturaIdResult>> InsertarFactura(Dictionary<string, object> parameters) {


            string sql = @"INSERT INTO facturas(tipo_pago,cliente_id,total)
            OUTPUT INSERTED.factura_id
            values(@tipo_pago,@cliente_id,@total)";

            return SelectSentences<FacturaIdResult>(sql, parameters);

        }

        public ResultPattern<int> InsertarFacturaProductos(Dictionary<string, object> parameters)
        {


            string sql = @"INSERT INTO facturas_productos(factura_id,codigo,cantidad,total_descuento,total_pagar)
            values(@factura_id,@codigo,@cantidad,@total_descuento,@total_pagar)";

            return ExecuteSentences(sql, parameters);

        }

    }
}
