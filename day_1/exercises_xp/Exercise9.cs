using System;

class Exercise9
{
    public static void Run()
    {
        Console.WriteLine("Enter Number 1 : ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2 : ");
        int n2 = int.Parse(Console.ReadLine());
        int temp;
        temp = n1;
        n1 = n2;
        n2 = temp;
        Console.WriteLine($" Number 1 : {n1} - Number 2 : {n2}");
    }
}
