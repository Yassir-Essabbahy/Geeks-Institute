using System;

class Exercise3
{
    public static void Run()
    {
        Console.WriteLine("Enter Number 1 : ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2 : ");
        int n2 = int.Parse(Console.ReadLine());
        int sum = n1 + n2;
        Console.WriteLine(sum);
    }
}
