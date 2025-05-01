using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Division
{
    public class OperacionDivision
    {
        public int Division (int numeroUno, int numeroDos, ref int residuo)
        {
            int resultado = numeroUno / numeroDos;
            residuo = numeroUno % numeroDos;
            return resultado;
        }
    }
}
