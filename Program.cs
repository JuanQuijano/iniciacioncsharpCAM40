using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");



var calculadora = new Calculadora();

Console.WriteLine(calculadora.Sumar());
Console.WriteLine(calculadora.Multiplicar());


calculadora = new Calculadora(10, 20);
Console.WriteLine(calculadora.Sumar());
Console.WriteLine(calculadora.Multiplicar());


public class Calculadora
{
    int numero1 { get; set; }
    int numero2 { get; set; }

    public Calculadora(int numero1 = 0, int numero2 = 0)
    {
        this.numero1 = numero1;
        this.numero2 = numero2;
    }

    public int Sumar()
    {
        return numero1 + numero2;
    }
    public int Multiplicar()
    {
        return numero1 * numero2;
    }
}




