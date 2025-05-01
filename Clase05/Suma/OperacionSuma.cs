

namespace Clase05.Suma
{
    public class OperacionSuma
    {
        public decimal Suma(int numeroUno, int numeroDos)
        {
            int resultado = numeroUno + numeroDos;
            return ConvertirEnteroADecimal(resultado);
        }

        public decimal Suma(int numeroUno, int numeroDos, int numeroTres)
        {
            int resultado = numeroUno + numeroDos + numeroTres;
            return ConvertirEnteroADecimal(resultado);
        }

        protected decimal ConvertirEnteroADecimal(int numero)
        {
            decimal resultado = numero;
            return resultado;
        }
    }

    public class Testeo : OperacionSuma
    {
        public decimal ConvertirEntero(int numero)
        {
            return ConvertirEnteroADecimal(numero);
        }
    }
}
