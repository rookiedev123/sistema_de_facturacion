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
        private string descripcion;
        private decimal precio;
        private decimal cantidad;
        private decimal descuento;
        private decimal total;
        private decimal totalDesc;
        private decimal totalNeto;

        public string Codigo 
        { 
            get => codigo;
            set { if (codigo != value) { codigo = value; } } 
        }
        public decimal Precio
        {
            get => precio;
            set { if (precio != value) { precio = value; } }
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public decimal Cantidad
        {
            get => cantidad;
            set { if (cantidad != value) { cantidad = value; OnPropertyChanged(nameof(Cantidad)); } }
        }
        public decimal Descuento
        {
            set { if (descuento != value) { descuento = value; } }
        }

        public decimal Total
        {
            get => total;
            set { if (total != value) { total = value; OnPropertyChanged(nameof(Total)); } }
        }
        public decimal TotalDesc
        {
            get => totalDesc;
            set { if (totalDesc != value) { totalDesc = value; OnPropertyChanged(nameof(TotalDesc)); } }
        }
        public decimal TotalNeto
        {
            get => totalNeto;
            set { if (totalNeto != value) { totalNeto = value; OnPropertyChanged(nameof(TotalNeto)); } }
        }


        public void CalcTotales(List<Impuesto> impuestos) {

            Total = Math.Round(this.precio * this.cantidad, 2);
            TotalDesc = Math.Round((total * descuento), 2);

            decimal temporalNeto = (Total- TotalDesc);

            foreach (Impuesto imp in impuestos)
            {
                this.TotalNeto = Math.Round(temporalNeto + (temporalNeto * imp.Valor), 2); ;
            }

        }

        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
