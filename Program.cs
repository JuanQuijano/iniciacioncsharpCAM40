using System;

public static class IntExtensions
{
    public static bool IsNull(this int numero)
    {
        return numero == null;
    }
}


class Program
{
    static void Main(string[] args)
    {
        var cantidad = 0;
        Console.WriteLine(cantidad.IsNull());

    }
}
