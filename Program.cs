using System.Globalization;

Console.Clear();
CultureInfo.CurrentCulture = new CultureInfo("es-ES");
CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;


string first = "Hello";
string second = "World";
string result = string.Format("{0} {0} {1}!", first, second);
Console.WriteLine(result);

Console.WriteLine("---------");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

Console.WriteLine("---------");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N6} units");

Console.WriteLine("---------");
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

Console.WriteLine("---------");
price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
string yourDiscount1 = $"You saved {price - salePrice:C2} off the regular {price:C2} price. ";
Console.WriteLine(yourDiscount);
Console.WriteLine(yourDiscount1);

