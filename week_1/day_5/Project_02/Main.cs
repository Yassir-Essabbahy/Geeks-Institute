using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Transaction> transactions = new List<Transaction>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nPersonal Expense Tracker");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. View Transactions");
            Console.WriteLine("3. Update Transaction");
            Console.WriteLine("4. Delete Transaction");
            Console.WriteLine("5. View Summary");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddTransaction(); break;
                case "2": ViewTransactions(); break;
                case "3": UpdateTransaction(); break;
                case "4": DeleteTransaction(); break;
                case "5": ViewSummary(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
    }
