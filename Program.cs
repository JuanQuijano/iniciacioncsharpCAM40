using System.Linq;

Console.Clear();

/* Muestro el número de veces que aparece una letra en una frase que muestro al reves*/

var frase = "The quick brown fox jumps over the lazy dog.";
var fraseAlReves = frase.Reverse();
int numeroDeVecesAparece = 0;

foreach (var letra in fraseAlReves)
{
    if (letra == 'o')
    { numeroDeVecesAparece++; }
}

Console.WriteLine(string.Concat(fraseAlReves));
Console.WriteLine($"'o' appears {numeroDeVecesAparece} times.");