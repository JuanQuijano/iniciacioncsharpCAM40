using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");


var numero1 = 3;
var numero2 = 4;

Console.WriteLine($"La suma de {numero1} más {numero2} es igual a {SumaDosNumeros(numero1, numero2)} ");

int SumaDosNumeros(int numero1, int numero2)
{ 
    return numero1 + numero2;
}