using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Objetos
{
    public class Carro : Vehiculo
    {
        public bool TieneTricket { get; set; }

        public override void Arrancar()
        {
            Console.WriteLine($"Arranque mi carro {Marca} modelo {Modelo}");
        }

        public void CambiarLlanta()
        {
            Console.WriteLine("Debo cambiar la llanta");
            Console.WriteLine(TieneTricket ? "Tengo Tricket\nCambio la llanta" : "No tengo tricket :(");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Presionando acelerador con el pie");
        }
    }

}
