using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sistema_de_facturacion.Models
{
    public class Usuario
    {
        private string connectionString = "Server=DESKTOP-6BSO7KF;Database=ferretería_facturacion;Integrated Security=True";

        // Constructor de la clase Usuario
        public Usuario()
        {
        }

        // Método para validar el usuario
        public bool ValidarUsuario(string nombre, string password)
        {
            bool esValido = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Nombre = @Nombre AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Password", password);

                    int resultado = (int)command.ExecuteScalar();
                    esValido = resultado > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar el usuario: " + ex.Message);
            }

            return esValido;
        }
    }
}