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
        private string facturaId;
        private List<Impuesto> impuestos;
        public BindingList<Articulo> articulos = new BindingList<Articulo>();
        public Factura(List<Impuesto> impuestos) { 
            this.impuestos = impuestos;
        }


        public void AgregarArticulo(Articulo articulo) {

            Predicate<Articulo> predicate = ((a) => a.Codigo.Equals(articulo.Codigo));

            int index = this.articulos.ToList().FindIndex(predicate);

            if (index == -1) {
                articulo.CalcTotalDescuento();
                articulo.CalcTotalPagar(this.impuestos);
                this.articulos.Add(articulo);
                return;
            }

            this.articulos[index].Cantidad += 1;

            this.articulos[index].CalcTotalDescuento();
            this.articulos[index].CalcTotalPagar(this.impuestos);


            return;


        }

        public void RemoverArticulo(Articulo articulo)
        {

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

        }

        public double CalcularFacturaTotal() {

            double total = 0;
            foreach (Articulo item in articulos.ToList()){
                total += item.TotalPagar;
            }

            return total;
        }

        public void LimpiarArticulos() {
            this.articulos.Clear();

        }


    }
}
