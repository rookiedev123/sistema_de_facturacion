using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_de_facturacion.Models.Connections;

namespace sistema_de_facturacion.Models.Provider
{
    internal interface IProvider
    {
        void SetConnectionString(IConnectionString connString);
        ResultPattern<List<T>> SelectSentences<T>(string sql, Dictionary<string, object> parameters = null);
        ResultPattern<int> ExecuteSentences(string sql, Dictionary<string, object> parameters = null);
    }
}
