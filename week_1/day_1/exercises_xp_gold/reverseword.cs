using System;

class Exercise3
{
    public static void Run()
    {
        Console.Write("Type a Word : ");
        string word = Console.ReadLine();
        for (int i = word.Length - 1; i >= 0 ; i--)
        {
            Console.Write(word[i]);
        }
    }
}
