using sistema_de_facturacion.Services.Facturacion;

namespace sistema_de_facturacion.Services.Documento
{
    internal interface IFacturaGenerator
    {


        void GenerarFactura(Factura factura);

        void MostrarArchivo();

    }
}
