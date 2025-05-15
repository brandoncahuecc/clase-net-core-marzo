using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Consola.Clases
{
    public class Carro : Vehiculo
    {
        public int Llantas { get; set; }
        public Carro(string marca, string modelo, int anio, int llantas) : base(marca, modelo, anio)
        {
            Llantas = llantas;
        }

        public override string TipoVehiculo() => $"Carro de {Llantas} ruedas";
    }
}
