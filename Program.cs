using System;

Console.Clear();

Console.WriteLine("Procesando las cadenas...");
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (var frase in myStrings[0].Split('.'))
{ Console.WriteLine(frase.Trim()); }

Console.WriteLine(myStrings[1]);
Console.WriteLine("Proceso completado.");

