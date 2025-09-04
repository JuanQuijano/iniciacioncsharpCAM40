Console.Clear();

var suma = 7 + 5;
var resta = 7 - 5;
var multiplicacion = 7 * 5;
var division = 7 / 5;

Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + division);


var divivendo = 233;
var divisor = 5;
var divisionDecimal = (decimal)divivendo / divisor;
Console.WriteLine("División decimal: " + divisionDecimal);
Console.WriteLine("Resto: " + (decimal)divivendo % divisor);  

/*PEMDAS
Parentesis
Exponentes
Multiplicación
División
Suma y resta

de izquierda a derecha
*/

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);