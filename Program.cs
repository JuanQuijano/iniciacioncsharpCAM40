using System;
using System.Globalization;

Console.Clear();

string[] values = ["12.3", "45", "ABC", "11", "DEF"];

var message = string.Empty;
var total = 0.0;

foreach (var valor in values)
{
    if (double.TryParse(valor, NumberStyles.Number, CultureInfo.InvariantCulture, out var number))
    {
        total += number;
    }
    else
    {
        message += valor;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total.ToString(CultureInfo.InvariantCulture)}");


