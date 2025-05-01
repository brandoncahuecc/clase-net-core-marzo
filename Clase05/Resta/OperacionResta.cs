using Clase05.Suma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Resta
{
    public class OperacionResta
    {
        public void Resta(int numeroUno, int numeroDos, ref int resultado)
        {
            resultado = numeroUno - numeroDos;
            numeroUno = numeroDos;
            numeroDos = resultado;
        }
    }
}
