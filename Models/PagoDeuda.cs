using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Models
{
    internal class PagoDeuda
    {
        public int ClienteId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Pago { get; set; }
        public decimal Deuda { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        public DateTime FechaProximoPago { get; set; }
        public decimal MontoPago { get; set; }
    }
}
