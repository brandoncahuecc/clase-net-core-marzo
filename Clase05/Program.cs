
using Clase05.Division;
using Clase05.Multiplicacion;
using Clase05.Resta;
using Clase05.Suma;

OperacionMultiplicacion multiplicacion = new();

multiplicacion.Multiplicacion(4, 3, out int resultado);
Console.WriteLine("Resultado: {0}", resultado);

int respuesta = multiplicacion.Multiplicacion(numeroDos: 4, numeroUno: 10);
Console.WriteLine("Respuesta: {0}", respuesta);



void Division()
{
    OperacionDivision division = new();
    int residuo = 0;
    int resultado = division.Division(5, 3, ref residuo);

    Console.WriteLine("Resultado: {0}", resultado);
    Console.WriteLine("Residuo: {0}", residuo);
}

void Resta()
{
    OperacionResta resta = new();

    int numeroUno = 6;
    int numeroDos = 3;
    int resultado = 0;

    Console.WriteLine("Numero Uno: {0}", numeroUno);
    Console.WriteLine("Numero Dos: {0}", numeroDos);
    Console.WriteLine("Resultado: {0}", resultado);

    resta.Resta(numeroUno, numeroDos, ref resultado);

    Console.WriteLine("Numero Uno: {0}", numeroUno);
    Console.WriteLine("Numero Dos: {0}", numeroDos);
    Console.WriteLine("Resultado: {0}", resultado);
}

void Suma()
{

    OperacionSuma suma = new();

    int numero = 10;

    decimal resultadoSuma = suma.Suma(3, 5, 4);

    Console.WriteLine(resultadoSuma);
}

void Listas()
{
    List<string> vocales = new() { "e", "u", "o", "i", "a" };
    vocales.AddRange(["d", "z"]);

    Console.WriteLine("Desordenados");
    foreach (string item in vocales)
    {
        Console.WriteLine(item);
    }

    vocales.Sort();

    Console.WriteLine("Ordenados");
    foreach (string item in vocales)
    {
        Console.WriteLine(item);
    }
}

void Arreglos()
{
    int[] numeros = { 5, 10, 2, 6, 1, 4 };
    Array.Resize(ref numeros, numeros.Length + 1);
    numeros[6] = 2;
    Console.WriteLine("Desordenados");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }

    Array.Sort(numeros);

    Console.WriteLine("Ordenados");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}

void Ciclos()
{
    Console.WriteLine("Ciclo For");

    for (int i = 0; i < 25; i++)
    {
        Console.WriteLine(i + 1);
    }

    Console.WriteLine();
    Console.WriteLine("Ciclo While");
    int numero = 100;

    while (numero < 1001)
    {
        Console.WriteLine(numero);
        numero++;
    }

    Console.WriteLine();
    Console.WriteLine("Ciclo Do While");
    numero = 100;

    do
    {
        Console.WriteLine(numero);
        numero++;
    }
    while (numero < 1001);
}