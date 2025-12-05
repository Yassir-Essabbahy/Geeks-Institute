using System;

class Exercise1
{
    public static void Run()
    {
        Console.Write("enter a number : ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("enter a length : ");
        int length = int.Parse(Console.ReadLine());

        List<int> multiples = new List<int>();

        for ( int i = 1 ; i <= length ; i++)
        {
            multiples.Add(num * i);
        }

        Console.WriteLine("Result: ");
        Console.WriteLine(string.Join(", ", multiples));

    }
}