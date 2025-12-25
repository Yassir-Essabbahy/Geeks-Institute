using System;

class Exercise6
{
    public static void Run()
    {
        SayHello("Yassir");
        SayHello("Yasser");
        SayHello("Yassine");
    }

    private static void SayHello(string name)
    {
        Console.WriteLine(name);
    }
}
