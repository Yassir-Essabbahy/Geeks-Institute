using System;

class Exercise8
{
    public static void Run()
    {
        Console.Write("Enter The Temperature in Celsius : ");
        int c = int.Parse(Console.ReadLine());
        int f = c * (9 / 5) + 32;
        Console.WriteLine($"The Temperature in Fahrenheit is : {f}");
    }
}
