using System;

class Exercise4
{
    public static void Run()
    {
     DescribeCity("Rabat");   
    }

    public static void DescribeCity(string city, string country = "Iceland")
{
    Console.WriteLine($"{city} is in {country}.");
}
}
