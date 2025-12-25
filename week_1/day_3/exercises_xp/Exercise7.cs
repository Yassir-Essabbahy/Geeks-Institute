using System;

class Exercise7
{
    public static void Run()
    {
        Console.Write("Enter season (winetr/spring/summer/autumn): ");
        string season = Console.ReadLine();
        int temp = GetRandomTemp(season);
        Console.WriteLine($"The temperature is {temp}C)");

        if (temp < 0)
            Console.WriteLine("wear a heavy coat");
        else if (temp < 15)
            Console.WriteLine("wear something warm");
        else if (temp < 30)
            Console.WriteLine("it's a bit warm have fun");
        else
            Console.WriteLine("stay hydrated");
    }

    public static int GetRandomTemp(string season)
    {
        Random rnd = new Random();
        int min = -10,
            max = 40;

        if (season == "winter")
        {
            min = -10;
            max = 16;
        }
        if (season == "spring")
        {
            min = 0;
            max = 23;
        }
        if (season == "summer")
        {
            min = 16;
            max = 40;
        }
        if (season == "autumn")
        {
            min = 0;
            max = 23;
        }

        return rnd.Next(min, max + 1);
    }
}
