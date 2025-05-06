using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Services.Facturacion
{
    public class Impuesto
    {
        private string concepto;
        private double valor;
        

        public Impuesto(string concepto, double valor)
        {
            this.concepto = concepto;
            this.valor = valor;
        }

        public string Concepto { get => concepto; }
        public double Valor { get => valor; }
    }
}
