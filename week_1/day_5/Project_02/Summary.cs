    static void ViewSummary()
    {
        decimal totalIncome = transactions.Where(t => t.Category.ToLower() == "income").Sum(t => t.Amount);
        decimal totalExpenses = transactions.Where(t => t.Category.ToLower() == "expense").Sum(t => t.Amount);
        decimal balance = totalIncome - totalExpenses;

        Console.WriteLine($"\nTotal Income: {totalIncome:C}");
        Console.WriteLine($"Total Expenses: {totalExpenses:C}");
        Console.WriteLine($"Balance: {balance:C}");

        Console.WriteLine("\nExpenses by Category:");
        var expenseByCategory = transactions
            .Where(t => t.Category.ToLower() == "expense")
            .GroupBy(t => t.Title)
            .Select(g => new { Category = g.Key, Total = g.Sum(x => x.Amount) });

        foreach (var item in expenseByCategory)
        {
            Console.WriteLine($"{item.Category}: {item.Total:C}");
        }
    }
