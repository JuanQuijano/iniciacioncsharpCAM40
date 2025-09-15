using Classes_M1;
Console.Clear();

string firstName = "Tim";
string lastName = "Shao";


var customer1 = new BankCustomer();

firstName = "Lisa";
var customer2 = new BankCustomer(firstName, lastName);

firstName = "Sandy";
lastName = "Zoeng";

var customer3 = new BankCustomer(firstName, lastName);

Console.WriteLine($"BankCustomer 1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerIdNumber}");
Console.WriteLine($"BankCustomer 2: {customer2.FirstName} {customer2.LastName} {customer2.CustomerIdNumber}");
Console.WriteLine($"BankCustomer 3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerIdNumber}");


 BankAccount account1 = new BankAccount(customer1.CustomerIdNumber);
 BankAccount account2 = new BankAccount(customer2.CustomerIdNumber, 1500, "Checking");
 BankAccount account3 = new BankAccount(customer3.CustomerIdNumber, 2500, "Checking");

 
 Console.WriteLine($"Account 1: Account # {account1.AccountNumber}, type {account1.AccountType}, balance {account1.Balance}, rate {BankAccount.InterestRate}, customer ID {account1.CustomerId}");
 Console.WriteLine($"Account 2: Account # {account2.AccountNumber}, type {account2.AccountType}, balance {account2.Balance}, rate {BankAccount.InterestRate}, customer ID {account2.CustomerId}");
 Console.WriteLine($"Account 3: Account # {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance}, rate {BankAccount.InterestRate}, customer ID {account3.CustomerId}");

