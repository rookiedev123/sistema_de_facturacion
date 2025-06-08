using Dapper;
using sistema_de_facturacion.Models.Connections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Models.Provider
{
    internal class ProviderSQL : IProvider
    {

        IConnectionString connString;
        public void SetConnectionString(IConnectionString connString)
        {
            this.connString = connString;
        }

        /// <summary>
        /// Función para consultas que no retornan tablas de datos
        /// </summary>
        /// <param name="sql">Sentencia SQL</param>
        /// <param name="parameters">Parametros de la sentencia SQL</param>
        /// <returns></returns>
        public ResultPattern<int> ExecuteSentences(string sql, Dictionary<string, object> parameters = null)
        {

            int row = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connString.getConnectionString()))
                {
                    row = connection.Execute(sql, parameters);
                }
            }
            catch (Exception e)
            {
                return ResultPattern<int>.Failure(e.Message);
            }

            if (row == 0)
            {

                return ResultPattern<int>.Failure("Los datos no se ha ingresado a la base de datos correctamente");
            }

            return ResultPattern<int>.Success(row);

        }
        /// <summary>
        /// Función para consultas que retornan tablas de datos
        /// </summary>
        /// <typeparam name="T">Tabla Entidad</typeparam>
        /// <param name="sql">Sentencia SQL</param>
        /// <param name="parameters">Parametros de la sentencia SQL</param>
        /// <returns></returns>
        public ResultPattern<List<T>> SelectSentences<T>(string sql, Dictionary<string, object> parameters = null)
        {

            List<T> data = new List<T>();

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connString.getConnectionString()))
                {
                    data.AddRange(connection.Query<T>(sql, parameters).ToList());
                }
            }
            catch (Exception e)
            {
                return ResultPattern<List<T>>.Failure(e.Message);
            }
            return ResultPattern<List<T>>.Success(data);

        }

         public ResultPattern<int> SqlWithLastId(string sql, Dictionary<string, object> parameters = null)
        {

            int data = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connString.getConnectionString()))
                {
                    data = connection.QuerySingle<int>(sql, parameters);
                }
            }
            catch (Exception e)
            {
                return ResultPattern<int>.Failure(e.Message);
            }
            return ResultPattern<int>.Success(data);

        }

    }
}
