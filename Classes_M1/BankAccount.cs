using System;

namespace Classes_M1;

public class BankAccount
{
    public int AccountNumber;
    public double Balance = 0;
    public static double InterestRate;
    public string AccountType = "Checking";
    public readonly string CustomerId;

    public BankAccount(string customerIdNumber = "", double balance = 0, string accountType = "Checking")
    {
        CreateBankAccountNumber();
        this.CustomerId = customerIdNumber;
        this.Balance = balance;
        this.AccountType = accountType;
    }

        private void CreateBankAccountNumber()
    {
        Random random = new Random();
        AccountNumber = random.Next(10000000, 20000000);
        InterestRate = 0;
    }
}