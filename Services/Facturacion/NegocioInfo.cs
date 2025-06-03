using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Services.Facturacion
{
    internal class NegocioInfo
    {

        private string nombre = "Ferreteria MAX";
        private string direccion = "En algún lugar de Narnia";
        private string telefono = "9999-9999";

        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        public string Telefono { get => telefono; }
    }
}
