using System;

class Exercise3
{
    public static void Run()
    {
        var brand = new Dictionary<string, object>
        {
            { "name", "Zara" },
            { "creation_date", 1975 },
            { "creator_name", "Amancio Ortega Gaona" },
            {
                "type_of_clothes",
                new List<string> { "men", "women", "children", "home" }
            },
            {
                "international_competitors",
                new List<string> { "Gap", "H&M", "Benetton" }
            },
            { "number_stores", 7000 },
            {
                "major_color",
                new Dictionary<string, List<string>>
                {
                    {
                        "France",
                        new List<string> { "blue" }
                    },
                    {
                        "Spain",
                        new List<string> { "red" }
                    },
                    {
                        "US",
                        new List<string> { "pink", "green" }
                    },
                }
            },
        };
        brand["number_stores"] = 2;

        var clients = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara sells clothes for : {string.Join(", ", clients)}");

        brand["country_creation"] = "Spain";

        var competitors = (List<string>)brand["international_competitors"];
        competitors.Add("Desigual");

        brand.Remove("creation_date");

        Console.WriteLine("Last competitor : " + competitors[competitors.Count - 1]);

        var colors = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine("US major colors: " + string.Join(", ", colors["US"]));

        Console.WriteLine("number of keys : " + brand.Count);

        foreach (var key in brand.Keys)
        {
            Console.WriteLine(key);
        }

        var more_on_zara = new Dictionary<string, object>
        {
            { "creation_date", 1975 },
            { "number_stores", 10000 },
        };

        foreach (var item in more_on_zara)
        {
            brand[item.Key] = item.Value;
        }

        Console.WriteLine("New number of stores : " + brand["number_stores"]);
        Console.WriteLine("the value was overwritten.");
    }
}
