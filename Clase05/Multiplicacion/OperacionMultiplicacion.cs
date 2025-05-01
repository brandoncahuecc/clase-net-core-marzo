using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Multiplicacion
{
    public class OperacionMultiplicacion
    {
        public void Multiplicacion(int numeroUno, int numeroDos, out int resultado)
        {
            resultado = numeroUno * numeroDos;
        }

        public int Multiplicacion(int numeroUno, int numeroDos = 1)
        {
            int resultado = numeroUno * numeroDos;
            return resultado;
        }
    }
}
