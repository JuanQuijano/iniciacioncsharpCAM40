using System;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};
string externalDomain = "hayworth.com";

ShowEmailAddresses(corporate);
ShowEmailAddresses(external, externalDomain);

static void ShowEmailAddresses(string[,] employees, string domain = "contoso.com")
{
    for (int i = 0; i < employees.GetLength(0); i++)
    {
        string firstName = employees[i, 0];
        string lastName = employees[i, 1];

        string userPrefix = firstName.Length >= 2 ? firstName.Substring(0, 2) : firstName;
        string user = (userPrefix + lastName).ToLowerInvariant();

        Console.WriteLine($"{user}@{domain}");
    }
}