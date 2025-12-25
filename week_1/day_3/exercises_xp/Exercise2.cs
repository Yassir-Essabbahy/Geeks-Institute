using System;

class Exercise2
{
    public static void Run()
    {
        Dictionary<string, int> family = new Dictionary<string, int>
        {
            { "rick", 43 },
            { "beth", 13 },
            { "morty", 5 },
            { "summer", 8 },
        };
        int total = 0;

        foreach (var person in family)
        {
            int price = 0;
            if (person.Value < 3)
                price = 0;
            else if (person.Value <= 12)
                price = 10;
            else
                price = 15;

            Console.WriteLine($"{person.Key} pays ${price}");
            total = total + price;
        }
        Console.WriteLine($"Total family cost: ${total}");
    }
}
