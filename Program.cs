using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] direccionesIp = new[] { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };

string[] direcciones;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (var ip in direccionesIp)
{
    direcciones = ip.Split('.');

    validLength = false;
    validZeroes = true;
    validRange = true;

    ValidaLaLongitud();
    if (validLength)
    {
        ValidaLosCeros();
        ValidaElRango();
    }

    ImprimeResultado(ip);
}

void ValidaLaLongitud()
{
    validLength = (direcciones.Length == 4);
}
void ValidaLosCeros()
{
    foreach (var numero in direcciones)
    {
        // empty segment is invalid
        if (string.IsNullOrEmpty(numero))
        {
            validZeroes = false;
            return;
        }

        // leading zeroes (e.g., "01") are invalid
        if (numero.Length > 1 && numero.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}
void ValidaElRango()
{
    foreach (string number in direcciones)
    {
        if (!int.TryParse(number, out int value))
        {
            validRange = false;
            return;
        }

        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;
}
void ImprimeResultado(string ip)
{ 
    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}