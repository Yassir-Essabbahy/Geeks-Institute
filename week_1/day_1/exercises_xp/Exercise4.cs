using System;

class Exercise4
{
    public static void Run()
    {
        Console.WriteLine("Enter Your Age : ");
        int user_Age = int.Parse(Console.ReadLine());

        if (user_Age >= 18)
        {
            Console.WriteLine("Access Granted.");
        }
        else
        {
            Console.WriteLine("Access Denied.");
        }
    }
}
