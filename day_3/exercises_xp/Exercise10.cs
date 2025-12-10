using System;

class Dog
{
    public string Name;
    public int Height;

    public Dog(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} goes woof!");
    }

    public void Jump()
    {
        Console.WriteLine($"{Name} jumps {Height * 2} cm high!");
    }
}

class Exercise10
{
    public static void Run()
    {
        var davidsDog = new Dog("Rex", 50);
        var sarahsDog = new Dog("Teacup", 20);

        davidsDog.Bark();
        davidsDog.Jump();

        sarahsDog.Bark();
        sarahsDog.Jump();

        if (davidsDog.Height > sarahsDog.Height)
            Console.WriteLine($"{davidsDog.Name} is taller.");
        else
            Console.WriteLine($"{sarahsDog.Name} is taller.");
    }
}
