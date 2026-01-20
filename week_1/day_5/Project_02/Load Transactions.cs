using System.IO;
using System.Text.Json;

static void SaveTransactions()
{
    File.WriteAllText("transactions.json", JsonSerializer.Serialize(transactions));
}

static void LoadTransactions()
{
    if (File.Exists("transactions.json"))
    {
        transactions = JsonSerializer.Deserialize<List<Transaction>>(File.ReadAllText("transactions.json"));
    }
}
