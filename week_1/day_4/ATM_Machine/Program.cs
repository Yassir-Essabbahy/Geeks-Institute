using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var accounts = new Dictionary<string, Account>()
        {
            { "0001", new Account("0001", 1234, 1000)},
            { "2222", new Account("2222", 0000, 500)},
            { "2025", new Account("2025", 9999, 2500)}
        };

        ATM atm = new ATM(accounts);

        Console.WriteLine("Welcome to the ATM machine!");

        Account loggedAcc = null;

        while (loggedAcc == null)
        {
            loggedAcc = atm.Authenticate();
        }

        string choice = "";
        while (choice != "5")
        {
            atm.ShowMenu();
            Console.Write("Select an option: ");
            choice = Console.ReadLine();

            atm.PerformAction(loggedAcc, choice);
        }

        Console.WriteLine("\nYour Summary: ");
        loggedAcc.ShowTransactions();
    }
}
