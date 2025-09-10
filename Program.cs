using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

int[] numeros = [1,2,3,4,5];

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (var numero in numeros)
    {
        Console.Write($"{numero} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello() 
{
    Console.WriteLine("Hello World!");
}