using System;

class Exercise7
{
    public static void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"The Number {i} is even");
            }
            else
            {
                Console.WriteLine($"The Number {i} is odd");
            }
        }
    }
}
