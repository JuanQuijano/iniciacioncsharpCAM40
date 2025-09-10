Console.Clear();

var value1 = 11;
var value2 = 6.2m;
var value3 = 4.3f;

var decimalDivision1 = (decimal)value1 / value2;
var result1 = (int)decimal.Round(decimalDivision1, 0, System.MidpointRounding.AwayFromZero);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

var value3AsDecimal = decimal.Parse(value3.ToString(System.Globalization.CultureInfo.InvariantCulture));
var result2 = value2 / value3AsDecimal;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

var result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


/*
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3909091
*/