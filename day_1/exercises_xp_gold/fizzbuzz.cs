using System;

class Exercise1
{
    public static void Run()
    {
        Console.WriteLine("Enter A Number Between 0 and 100 : ");
        int num = int.Parse(Console.ReadLine());
        if (num % 5 == 0 && num % 3 == 0)
        {
            Console.WriteLine($"{num} is  a Multiplication of 3 and 5");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine($"{num} is  a Multiplication of 5");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine($"{num} is  a Multiplication of 3");
        }
    }
}
