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

    public class FacturaCliente
    {
        public int factura_id { get; set; }
        public string creado_en { get; set; }
        public string tipo_pago { get; set; }

        public string cliente_id {get; set; }
        public string nombreCompleto { get; set; }

        public string codigo { get; set; }
        public string descripcion { get; set; }

        public decimal cantidad { get; set; }
        public decimal total_descuento { get; set; }
        public decimal total_pagar { get; set; }
    }

    public class productoFacturaDetalle
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; }

        public decimal cantidad { get; set; }
        public decimal total_descuento { get; set; }
        public decimal total_pagar { get; set; }

        public int factura_id { get; set; }
        public string creado_en { get; set; }
        public string tipo_pago { get; set; }

        public string cliente_id { get; set; }
        public string nombreCompleto { get; set; }
    }

    internal class FacturacionModel : ProviderSQL
    {
        public ResultPattern<List<Clientes>> GetClientesAll()
        {

            string sql = "select * from clientes";

            return this.SelectSentences<Clientes>(sql);

        }
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

        public ResultPattern<List<FacturaCliente>> GetFacturaCliente(Dictionary<string, object> parameter)
        {

            string sql = @"select f.factura_id,
                f.creado_en,
                f.tipo_pago,
                c.cliente_id, 
                c.nombreCompleto,
                p.codigo,  
                p.descripcion,
                fp.cantidad,
                fp.total_descuento,
                fp.total_pagar
                from facturas_productos fp
                inner join facturas f on fp.factura_id = f.factura_id
                inner join clientes c on f.cliente_id = c.cliente_id
                inner join productos p on fp.codigo = p.codigo
                where 
                f.creado_en between @fechaInicio and @fechaFin
                and c.cliente_id = @clienteBuscado
                order by f.factura_id";

            return this.SelectSentences<FacturaCliente>(sql, parameter);

        }

        public ResultPattern<List<productoFacturaDetalle>> GetCodigoDetalle(Dictionary<string, object> parameter)
        {

            string sql = @"select 
                p.codigo,
                p.descripcion,
                p.precio,
                p.descuento,
                fp.cantidad,
                fp.total_descuento,
                fp.total_pagar,
                f.factura_id,
                f.creado_en,
                f.tipo_pago,
                c.cliente_id,
                c.nombreCompleto
            from productos p
            inner join facturas_productos fp on p.codigo = fp.codigo
            inner join facturas f on fp.factura_id = f.factura_id
            inner join clientes c on f.cliente_id = c.cliente_id
            where 
                p.codigo = @codigo
                and f.creado_en between @fechaInicio and @fechaFin
            order by f.factura_id";

            return this.SelectSentences<productoFacturaDetalle>(sql, parameter);

        }

    }
}
