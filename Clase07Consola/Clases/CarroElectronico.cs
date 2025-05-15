using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Consola.Clases
{
    public sealed class CarroElectronico : Carro
    {
        public CarroElectronico(string marca, string modelo, int anio, int llantas) : base(marca, modelo, anio, llantas)
        { }

        public string CargarBateria() => "Batería cargada";

    }
}
