using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Clases
{
    public class FormatoIncorrectoException : Exception
    {
        public string ValorIncorrecto { get; }
        public int CodigoError { get; }

        public FormatoIncorrectoException()
        {
            ValorIncorrecto = string.Empty;
            CodigoError = 0;
        }

        public FormatoIncorrectoException(string message, string valorIncorrecto, int codigoError) : base(message)
        {
            message = "Error de formato 01: " + message;
            ValorIncorrecto = valorIncorrecto;
            CodigoError = codigoError;
        }

        public FormatoIncorrectoException(string message, string valorIncorrecto, int codigoError, Exception innerException)
            : base(message, innerException)
        {
            message = "Error de formato 02: " + message;
            ValorIncorrecto = valorIncorrecto;
            CodigoError = codigoError;
        }
    }
}
