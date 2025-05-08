using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Objetos
{
    public abstract class Vehiculo
    {
        public int Modelo { get; set; }
        public string Marca { get; set; }
        public int Llantas { get; set; }
        public string Color { get; set; }

        public Vehiculo()
        {
            Modelo = 0;
            Marca = string.Empty;
            Llantas = 0;
            Color = string.Empty;
        }

        public Vehiculo(int modelo, string marca, int llantas, string color)
        {
            Modelo = modelo;
            Marca = marca;
            Llantas = llantas;
            Color = color;
        }

        public virtual void Arrancar()//Podemos tener instrucciones comunes para los hijos
        {
            Console.WriteLine($"Arranque mi {Marca} {Modelo}");
        }

        public abstract void Acelerar();//Debemos de implementar esta función/método en las clases derivadas o hijas
    }
}
