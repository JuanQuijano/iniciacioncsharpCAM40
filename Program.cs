Console.Clear();

var ataque = new Random();
var saludHeroe = 10;
var saludMonstruo = 10;
var mensaje = string.Empty;


while (saludHeroe > 0 && saludMonstruo > 0)
{
    var danoHeroe = ataque.Next(1, 11);
    saludMonstruo -= danoHeroe;
    mensaje = $"Ataque del hero le hace {danoHeroe} puntos de daño al monstruo, que ahora tiene {saludMonstruo} de salud.";
    Console.WriteLine(mensaje);

    if (saludMonstruo > 0)
    {
        var danoMonstruo = ataque.Next(1, 11);
        saludHeroe -= danoMonstruo;
        mensaje = $"Ataque del monstruo le hace {danoMonstruo} puntos de daño al heroe, que ahora tiene {saludHeroe} de salud.";
        Console.WriteLine(mensaje);
    }
}

mensaje = (saludHeroe > 0) ? "¡Héroe gana!" : "¡Monstruo gana!";
Console.WriteLine(mensaje);
