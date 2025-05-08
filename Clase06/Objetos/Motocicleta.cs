using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Objetos
{
    public class Motocicleta : Vehiculo
    {
        public bool TieneCasco { get; set; }

        public Motocicleta()
        {
            
        }

        public Motocicleta(int modelo, string marca, int llantas, string color, bool tieneCasco)
        : base(modelo, marca, llantas, color)
        {
            TieneCasco = tieneCasco;
        }

        public virtual void HacerCaballito()
        {
            Console.WriteLine(TieneCasco ? "Me coloco el casco" : "Arriesgo al no tener casco");
            Console.WriteLine($"Haciendo un caballito con mi {Marca} {Modelo}");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Estoy acelerando con mi mano");
        }
    }
}
