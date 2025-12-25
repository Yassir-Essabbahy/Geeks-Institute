using System;

class Exercise5
{
    public static void Run()
    {
        Console.WriteLine("Enter a Number (from 1 to 100) : ");
        int guess = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int generated = rnd.Next(1, 101);

        if (guess == generated)
            Console.WriteLine("Success! You guessd the correct number");
        else
            Console.WriteLine($"Fail! Your guess was {guess}, but the number was {generated}");
    }
}
