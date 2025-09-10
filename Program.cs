using System.Globalization;

Console.Clear();
CultureInfo.CurrentCulture = new CultureInfo("es-ES");
CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;


string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
var formattedLine = paymentId.PadRight(6);
Console.WriteLine(formattedLine);

paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);