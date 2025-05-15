
using Clase07Consola.Interfaces;

namespace Clase07Consola.Clases
{
    public abstract class Vehiculo : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        ~Vehiculo()
        {
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"Vehículo {Marca} {Modelo} destruido");
            Console.WriteLine("Destrui todas las conexiones a base de datos y cerre todos los archivos utilizados");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
        }

        public abstract string TipoVehiculo();

        public void Encender(string nombreChofer)
            => Console.WriteLine("Vehículo encendido por " + nombreChofer);

        public void Apagar()
            => Console.WriteLine("Vehículo apagado");

    }
}