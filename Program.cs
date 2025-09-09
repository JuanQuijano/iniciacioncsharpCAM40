using System;

Console.Clear();

var numero = 0; ;
var entrada = string.Empty;
var salida = false;

Console.WriteLine("Introduce un valor entero entre 5 y 10");

while (salida == false)
{
    var mensaje = string.Empty;
    entrada = Console.ReadLine();
    salida = int.TryParse(entrada, out numero);

    if (salida)
    {
        if (!(numero >= 5 && numero <= 10))
        {
            salida = false;
            mensaje = $"El número {numero} no está en el rango permitido. Ingresa un número entre 5 y 10.";
        }
    }
    else
    { mensaje = "Lo siento, ingresaste un número no válido, intenta de nuevo"; }

    if (mensaje != string.Empty)
        Console.WriteLine(mensaje);
}

Console.WriteLine($"Su valor de entrada ({numero}) ha sido aceptado.");


