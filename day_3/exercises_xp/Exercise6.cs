using System;

class Exercise6
{
    public static void Run()
    {
        MakeShirt();
        MakeShirt("Medium");
        MakeShirt("Small","l3alamiya");
    }

    public static void MakeShirt(string size = "Large", string text = "I love C#")
{
    Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
}

}
