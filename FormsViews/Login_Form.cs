using sistema_de_facturacion.FormsViews;
using sistema_de_facturacion.Models;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Punto de ruptura: Verifica si se llega aquí al hacer clic en el botón
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Usuario usuario = new Usuario();
            bool isValid = usuario.ValidarUsuario(username, password);

            // Punto de ruptura: Verifica si isValid es true o false
            if (isValid)
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                MainForm mainForm = new MainForm();
                this.Hide(); // Oculta el formulario de inicio de sesión
                mainForm.Show(); // Muestra el MainForm
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagosDeudasForm2 pagoDeudasForm = new PagoDeudasForm();
            pagoDeudasForm.LayoutMdi(this);
            pagoDeudasForm.Show();
        }

        private class PagoDeudasForm : PagosDeudasForm2
        {
        }
    }
}
