using System;

namespace Classes_M2;

public class BankCustomer
{
    private static int s_nextCustomerId;
    public string FirstName { get; set; } = "Tim";
    public string LastName { get; set; } = "Shao";
    public readonly string CustomerId;

    static BankCustomer()
    {
        Random random = new Random();
        s_nextCustomerId = random.Next(10000000, 20000000);
    }
    public BankCustomer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        this.CustomerId = (s_nextCustomerId++).ToString("D10");
    }


    public void UpdateName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string ReturnFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string DisplayCustomerInfo()
    {
        return $"{ReturnFullName()} {CustomerId}";
    }
}
