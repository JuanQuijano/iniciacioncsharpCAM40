using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");


void DisplayRandomNumbers()
{
    var random = new Random();
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"La tirada ha sido de: {random.Next(1, 101)} puntos.");
    } 
    Console.WriteLine();
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();
