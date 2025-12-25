using System;

class Exercise10
{
    public static void Run()
    {
        Console.WriteLine("Enter a Number : ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int sum = num * i;
            Console.WriteLine($"{num} * {i} = {sum}");
        }
    }
}
