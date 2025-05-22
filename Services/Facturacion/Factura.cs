using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace sistema_de_facturacion.Services.Facturacion
{
    public class Factura
    {
        private List<Impuesto> impuestos;
        public BindingList<Articulo> articulos = new BindingList<Articulo>();

        private string facturaId;
        private string documento;
        private string cliente;
        private string tipoPago;
        private decimal total;
        private decimal totalDesc;
        private decimal totalNeto;

        public Factura(List<Impuesto> impuestos) {
            this.impuestos = impuestos;
        }


        public string FacturaId { get => facturaId; set => facturaId = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public decimal Total { get => total; }
        public decimal TotalDesc { get => totalDesc; }
        public decimal TotalNeto { get => totalNeto;}

   

        public void AgregarArticulo(Articulo articulo) {

            Predicate<Articulo> predicate = ((a) => a.Codigo.Equals(articulo.Codigo));

            int index = this.articulos.ToList().FindIndex(predicate);

            if (index == -1) {
                articulo.CalcTotales(this.impuestos);
                this.articulos.Add(articulo);
                return;
            }

            this.articulos[index].Cantidad += 1;
            this.articulos[index].CalcTotales(this.impuestos); 

        }

        public void RemoverArticulo(Articulo articulo)
        {
            /*

            Predicate<Articulo> predicate = ((a) => a.Codigo.Equals(articulo.Codigo));

            int index = this.articulos.ToList().FindIndex(predicate);

            if (index == -1){
                return;
            }

            if (this.articulos[index].Cantidad > 0) {
                this.articulos[index].Cantidad -= 1;
            }

            if (this.articulos[index].Cantidad <= 0) {
                this.articulos.RemoveAt(index);
                return;
            }

            this.articulos[index].CalcTotalDescuento();
            this.articulos[index].CalcTotalPagar(this.impuestos);

            return;
            */

        }

        public void CalcularFacturaTotales() {
            
            total = 0;
            totalNeto = 0;
            totalDesc = 0;
            foreach (Articulo item in articulos.ToList()){
                total += item.Total;
                totalNeto += item.TotalNeto;
                totalDesc += item.TotalDesc;
            }

        }

        public void LimpiarArticulos() {
            this.articulos.Clear();

        }


    }
}
