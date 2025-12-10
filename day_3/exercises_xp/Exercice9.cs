using System;

class Exercise9
{
     public static Cat FindOldestCat(List<Cat> cats)
    {
        Cat oldest = cats[0];
        foreach (var cat in cats)
        {
            if (cat.Age > oldest.Age)
            oldest = cat;
        }
        return oldest;
    }

    public static void Run()
    {
        var cat1 = new Cat("Mimi", 2);
        var cat2 = new Cat("Oscar", 5);
        var cat3 = new Cat("Luna", 3);
        var cats = new List<Cat> {cat1,cat2,cat3};

        var oldest = FindOldestCat(cats);
        Console.WriteLine($"The oldest cat is {oldest.Name}, and is {oldest.Age} years old");

    }
    }



class Cat
{
    public string Name;
    public int Age;

    public Cat(string catName, int catAge)
    {
        Name = catName;
        Age = catAge;
    }
}
