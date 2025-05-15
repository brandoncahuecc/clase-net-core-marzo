using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Consola.Clases
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo, int anio) : base(marca, modelo, anio)
        { }

        public override string TipoVehiculo()
        {
            return "Motocicleta";
        }
    }
}
