using System.Globalization;

Console.Clear();
CultureInfo.CurrentCulture = new CultureInfo("es-ES");
CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

string sharesStr = currentShares.ToString("N2");
string currReturnStr = (currentReturn * 100).ToString("F2") + "%";
string newReturnStr = (newReturn * 100).ToString("F2") + "%";
string currProfitStr = currentProfit.ToString("C2");
string newProfitStr = newProfit.ToString("C2");

string message =
$"Dear {customerName},\n" +
$"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n" +
$"Currently, you own {sharesStr} shares at a return of {currReturnStr}.\n\n" +
$"Our new product, {newProduct} offers a return of {newReturnStr}.  Given your current volume, your potential profit would be {newProfitStr}.\n";

Console.WriteLine(message);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = string.Empty;

// Construir la tabla de comparación
comparisonMessage =
	$"{currentProduct.PadRight(20)}{currReturnStr.PadLeft(8)}   {currProfitStr}\n" +
	$"{newProduct.PadRight(20)}{newReturnStr.PadLeft(8)}   {newProfitStr}  ";

// Imprimir la tabla (la línea con "Here's a quick comparison:" ya está en el código)
Console.WriteLine(comparisonMessage);

/*
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/