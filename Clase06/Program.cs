
using Clase06.Clases;
using Clase06.Objetos;


Carro carro = new Carro()
{
    Modelo = 2024,
    Color = "Rojo",
    Llantas = 4,
    Marca = "Toyota",
    TieneTricket = true
};

carro.Arrancar();
carro.CambiarLlanta();
carro.Acelerar();

Console.WriteLine("-------------------------------");
Console.WriteLine("-------------------------------");

Motocicleta motocicleta = new Motocicleta()
{
    Modelo = 2023,
    Color = "Azul",
    Llantas = 2,
    Marca = "Honda",
    TieneCasco = false
};

motocicleta.Arrancar();
motocicleta.HacerCaballito();
motocicleta.Acelerar();






void ControlDeExcepcionesPerzonalizadas()
{
    string numero;
    try
    {
        string dividentoString = "d00";

        if (!int.TryParse(dividentoString, out int dividendo))
        {
            throw new FormatoIncorrectoException("El número ingresado no es valido", dividentoString, 104);
        }
        numero = dividendo.ToString();
        Console.WriteLine("Formato correcto");
        Console.WriteLine(numero);
    }
    catch (FormatoIncorrectoException ex)
    {
        Console.WriteLine("Ocurrio un error de formato");

        Console.WriteLine("Código de Error: " + ex.CodigoError);
        Console.WriteLine("Valor Ingresado: " + ex.ValorIncorrecto);
        Console.WriteLine("Mensaje: " + ex.Message);
    }
    finally
    {
        numero = null;
        Console.WriteLine("Finally ejecutado exitosamente");
    }
}

void ControlDeExcepciones()
{
    try
    {
        string dividentoString = "100";

        if (!int.TryParse(dividentoString, out int dividendo))
        {
            throw new FormatException("El número ingresado no es valido");
        }

        //int dividendo = Convert.ToInt32(dividentoString);
        int divisor = 10;
        int resultado = dividendo / divisor;

        Console.WriteLine("División exitosa");
        Console.WriteLine(resultado);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Ocurrio un error de división entre cero");
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Ocurrio un error de formato");
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocurrio un error general");
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Finalizamos Aplicación");
}