using System;
using System.Collections.Generic;
using System.Linq;

class Zoo
{
    public string Name;
    public List<string> Animals;

    public Zoo(string zooName)
    {
        Name = zooName;
        Animals = new List<string>();
    }

    public void AddAnimal(string newAnimal)
    {
        if (!Animals.Contains(newAnimal))
        {
            Animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added!");
        }
        else
        {
            Console.WriteLine($"{newAnimal} already exists.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine("Animals in the zoo:");
        foreach (var a in Animals)
            Console.WriteLine(a);
    }

    public void SellAnimal(string animalSold)
    {
        if (Animals.Remove(animalSold))
            Console.WriteLine($"{animalSold} was sold.");
        else
            Console.WriteLine($"{animalSold} not found.");
    }

    public Dictionary<char, List<string>> SortAnimals()
    {
        var sorted = Animals
            .OrderBy(a => a)
            .GroupBy(a => a[0])
            .ToDictionary(g => g.Key, g => g.ToList());

        return sorted;
    }

    public void GetGroups()
    {
        var groups = SortAnimals();
        foreach (var g in groups)
        {
            Console.WriteLine($"{g.Key}: {string.Join(", ", g.Value)}");
        }
    }
}

class Exercise12
{
    public static void Run()
    {
        var newYorkZoo = new Zoo("New York Zoo");

        while (true)
        {
            Console.WriteLine("Which animal should we add to the zoo? (type 'stop' to finish)");
            string input = Console.ReadLine();
            if (input.ToLower() == "stop") break;

            newYorkZoo.AddAnimal(input);
        }

        newYorkZoo.GetAnimals();
        newYorkZoo.GetGroups();
    }
}
