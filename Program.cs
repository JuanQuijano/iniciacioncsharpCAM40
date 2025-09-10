using Microsoft.VisualBasic;

Console.Clear();
/*
var first = 2;
var second = "4";
var result = first + second;
Console.WriteLine(result);

Console.WriteLine("-----");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

Console.WriteLine("-----");


int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

Console.WriteLine("-----");*/

string sfirst = "5";
string ssecond = "a";
var salida = 0;
var salida1 = 0;

if(int.TryParse(sfirst, out salida) && int.TryParse(ssecond, out salida1))
{
    int sum =  salida + salida1;
    Console.WriteLine(sum);
}
else
{ Console.WriteLine("Error: Uno de los valores no es un número válido.");}

