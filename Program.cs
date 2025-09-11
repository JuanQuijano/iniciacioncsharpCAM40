using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");


string input = "En un lugar de la mancha de cuyo nombre no quiero acordarme";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));


string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}