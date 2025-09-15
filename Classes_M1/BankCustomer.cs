using System;

namespace Classes_M1;

public class BankCustomer
{

    public string FirstName = string.Empty;
    public string LastName = string.Empty;
    public readonly string CustomerIdNumber = string.Empty;


    public BankCustomer(string firstName = "Desconocido",
                      string lastName = "Desconocido")
    {
        FirstName = firstName;
        LastName = lastName;
        CustomerIdNumber = CreateCustonerIdNumber();
    }

    private static string CreateCustonerIdNumber()
    {
        Random random = new Random();
        var s_nextCustomerId = random.Next(10000000, 20000000);
        return s_nextCustomerId.ToString("D10");
    }
}
