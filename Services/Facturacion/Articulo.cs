using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistema_de_facturacion.Services.Facturacion
{
    public class Articulo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string codigo;
        private double precio;
        private double cantidad;
        private double descuento;
        private double totalDescuento;
        private double totalPagar;

        public string Codigo 
        { 
            get => codigo;
            set { if (codigo != value) { codigo = value; } } 
        }
        public double Precio
        {
            get => precio;
            set { if (precio != value) { precio = value; } }
        }
        public double Cantidad
        {
            get => cantidad;
            set { if (cantidad != value) { cantidad = value; OnPropertyChanged(nameof(Cantidad)); } }
        }
        public double Descuento
        {
            get => descuento;
            set { if (descuento != value) { descuento = value; } }
        }
        public double TotalDescuento
        {
            get => totalDescuento;
            set { if (totalDescuento != value) { totalDescuento = value; OnPropertyChanged(nameof(TotalDescuento)); } }
        }
        public double TotalPagar
        {
            get => totalPagar;
            set { if (totalPagar != value) { totalPagar = value; OnPropertyChanged(nameof(TotalPagar)); } }
        }

        public void CalcTotalDescuento() {

            double precioCalculado = this.precio * this.cantidad;
            this.TotalDescuento = Math.Round(precioCalculado - (precioCalculado * this.descuento),2);
        }

        public void CalcTotalPagar(List<Impuesto> impuestos){

            foreach(Impuesto imp in impuestos) {
                this.TotalPagar = Math.Round(this.TotalDescuento * ((imp.Valor + 1)),2);
            }

        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
