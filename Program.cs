using System;

Console.Clear();

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

var input = string.Empty;
var normalized = string.Empty;
var validRole = false;

do
{
    input = Console.ReadLine();
    normalized = (input != null) ? input.Trim().ToLower() : string.Empty;
    validRole = normalized == "administrator" || normalized == "manager" || normalized == "user";

    if (!validRole)
    {
        Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (!validRole);

Console.WriteLine($"Your input value ({input.Trim()}) has been accepted.");

