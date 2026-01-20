using System;

class Transaction
{
    public Guid ID { get; private set; } 
    public string Title { get; set; }
    public decimal Amount { get; set; }     
    public string Category { get; set; } 
    public DateTime Date { get; set; }

    public Transaction(string title, decimal amount, string category, DateTime date)
    {
        ID = Guid.NewGuid();
        Title = title;
        Amount = amount;
        Category = category;
        Date = date;
    }

    public void DisplayTransaction()
    {
        Console.WriteLine($"{ID} | {Title} | {Amount:C} | {Category} | {Date:yyyy-MM-dd}");
    }
        static void AddTransaction()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter category (Income/Expense): ");
        string category = Console.ReadLine();

        Console.Write("Enter date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Transaction t = new Transaction(title, amount, category, date);
        transactions.Add(t);
        Console.WriteLine("Transaction added successfully!");
    }
        static void ViewTransactions()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("No transactions found.");
            return;
        }

        Console.WriteLine("\nAll Transactions:");
        foreach (var t in transactions)
        {
            t.DisplayTransaction();
        }
    }
    static void UpdateTransaction()
    {
        ViewTransactions();
        Console.Write("Enter Transaction ID to update: ");
        string idInput = Console.ReadLine();

        Transaction t = transactions.FirstOrDefault(x => x.ID.ToString() == idInput);
        if (t == null)
        {
            Console.WriteLine("Transaction not found.");
            return;
        }

        Console.Write("Enter new title (leave blank to keep): ");
        string newTitle = Console.ReadLine();
        if (!string.IsNullOrEmpty(newTitle)) t.Title = newTitle;

        Console.Write("Enter new amount (leave blank to keep): ");
        string newAmount = Console.ReadLine();
        if (!string.IsNullOrEmpty(newAmount)) t.Amount = decimal.Parse(newAmount);

        Console.Write("Enter new category (Income/Expense) (leave blank to keep): ");
        string newCategory = Console.ReadLine();
        if (!string.IsNullOrEmpty(newCategory)) t.Category = newCategory;

        Console.Write("Enter new date (yyyy-MM-dd) (leave blank to keep): ");
        string newDate = Console.ReadLine();
        if (!string.IsNullOrEmpty(newDate)) t.Date = DateTime.Parse(newDate);

        Console.WriteLine("Transaction updated successfully.");
    }
    static void DeleteTransaction()
    {
        ViewTransactions();
        Console.Write("Enter Transaction ID to delete: ");
        string idInput = Console.ReadLine();

        Transaction t = transactions.FirstOrDefault(x => x.ID.ToString() == idInput);
        if (t == null)
        {
            Console.WriteLine("Transaction not found.");
            return;
        }

        Console.Write($"Are you sure you want to delete '{t.Title}'? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            transactions.Remove(t);
            Console.WriteLine("Transaction deleted successfully.");
        }
    }


}
