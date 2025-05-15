
using Clase07Consola.Clases;

Ejecutar();

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("Finalice limpieza!!!");

void Ejecutar()
{
    Carro carro = new Carro("Toyota", "Yaris", 2024, 4);
    Motocicleta motocicleta = new Motocicleta("Susuki", "GN125", 2025);
    CarroElectronico carroElectronico = new CarroElectronico("Tesla", "Cybertruck", 2023, 4);

    carro.Encender("Brandon");
    Console.WriteLine(carro.TipoVehiculo());
    carro.Apagar();

    Console.WriteLine("- - - - - - - - - - - - - - - - - -");
    Console.WriteLine("- - - - - - - - - - - - - - - - - -");

    motocicleta.Encender("Victor");
    Console.WriteLine(motocicleta.TipoVehiculo());
    motocicleta.Apagar();

    Console.WriteLine("- - - - - - - - - - - - - - - - - -");
    Console.WriteLine("- - - - - - - - - - - - - - - - - -");

    carroElectronico.Encender("Alexander");
    Console.WriteLine(carroElectronico.TipoVehiculo());
    Console.WriteLine(carroElectronico.CargarBateria());
    carroElectronico.Apagar();
}
