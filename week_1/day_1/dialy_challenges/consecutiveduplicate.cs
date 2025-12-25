using System;

class Exercise2
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "" + input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result += input[i];
            }
        }

        Console.WriteLine(result);
    }
}
