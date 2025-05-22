using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Models.Provider
{
    internal class ResultPattern<T>
    {

        public T Value { get; }

        public bool IsSuccess { get; }

        public string Error { get; }

        private ResultPattern(T value, bool isSuccess, string error)
        {
            Value = value;
            IsSuccess = isSuccess;
            Error = error;
        }

        public static ResultPattern<T> Success(T value) => new ResultPattern<T>(value, true, null);

        public static ResultPattern<T> Failure(string error) => new ResultPattern<T>(default, false, error);


    }
}
