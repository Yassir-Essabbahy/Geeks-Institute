using System;

public class Account
{
    public string AccountNumber {get; set;}
    public int PIN {get; set;}
    public double Balance {get; set;}
    public List<string> Transactions {get; set;}

    public Account(string accountNumber, int pin, double balance)
    {
        AccountNumber = accountNumber;
        PIN = pin;
        Balance = balance;
        Transactions = new List<string>();
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Transactions.Add($"Deposit: {amount}");
        Console.WriteLine($"Deposit seccessful! New balance : {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficent balance");
            return;
        }

        Balance = Balance - amount;
        Transactions.Add($"Withdraw: {amount}");
        Console.WriteLine($"Withdraw successful! New balance: {Balance}");   
    }

    public void ShowTransactions()
    {
        Console.WriteLine("Transaction History:");
        if (Transactions.Count == 0)
        {
            Console.WriteLine("No transactions");
            return;
        }

        foreach (var t in Transactions)
            Console.WriteLine(t);
    }

    
    public void CheckBalance()
    {
        Console.WriteLine($"Your balance is: {Balance} MAD");
        Transactions.Add($"Checked balance: {Balance} MAD");
    }

    
}