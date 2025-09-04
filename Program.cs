using System.Runtime.ExceptionServices;

Console.Clear();

var nombre = "Bob";
var saludo = "Hola";
var mensaje = $"{saludo} {nombre}! Me alegro volver a verte {nombre}.";
Console.WriteLine(mensaje);

Console.WriteLine();
var version = 11;
var textoActualizacion = "Actualiza a Windows";
mensaje = $"{textoActualizacion} {version}!";
Console.WriteLine(mensaje);

Console.WriteLine();
var nombreProyecto = "Primer-Projecto";
Console.WriteLine($@"C:\Output\{nombreProyecto}\Data");