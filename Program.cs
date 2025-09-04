Console.Clear();

Random dado = new();
var tirada = dado.Next(1, 7);
Console.WriteLine("Has sacado un " + tirada);
