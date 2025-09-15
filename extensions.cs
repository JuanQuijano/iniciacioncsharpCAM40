using System;

namespace Classes_M2;

public static class BankCustomerExtensions
{
    // Extension method to check if the customer ID is valid
    public static bool IsValidCustomerId(this BankCustomer customer)
    {
        return customer.CustomerId.Length == 10;
    }

    // Extension method to greet the customer
    public static string GreetCustomer(this BankCustomer customer)
    {
        return $"Hello, {customer.ReturnFullName()}!";
    }
}

public static class BankAccountExtensions
{
    public static bool IsOverdrawn(this BankAccount account)
    {
        return account.Balance < 0;
    }
    public static bool CanWithdraw(this BankAccount account, double amount)
    {
        return account.Balance >= amount;
    }
}



