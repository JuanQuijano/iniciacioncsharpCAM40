using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

CountTo(7);

void CountTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}