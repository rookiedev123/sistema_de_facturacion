using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.FormsViews
{
    public partial class PagosDeudasForm2 : Form
    {
        public PagosDeudasForm2()
        {
            InitializeComponent();
        }

        private void reporte_pagos_deudasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reporte_pagos_deudasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ferreteria_facturacionDataSet);

        }

        private void PagosDeudasForm2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteria_facturacionDataSet.reporte_pagos_deudas' Puede moverla o quitarla según sea necesario.
            this.reporte_pagos_deudasTableAdapter.Fill(this.ferreteria_facturacionDataSet.reporte_pagos_deudas);

        }

        internal void LayoutMdi(Login_Form login_Form)
        {
            throw new NotImplementedException();
        }
    }
}
