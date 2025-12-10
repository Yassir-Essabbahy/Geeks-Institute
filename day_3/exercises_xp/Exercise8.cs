using System;

class Exercise8 
{
    public static void Run()
    {
      int correct = 0;
int wrong = 0;

var wrongAnswers = new List<(string question, string userAnwser, string correctAnwser)>();

    Console.WriteLine("Start Quiz");
    var data = Questions();
    foreach (var item in data)
        {
            Console.WriteLine(item["question"]);
            string user = Console.ReadLine();

            if (user.Trim().ToLower() == item["answer"].ToLower())
            {
                correct++;
            }
            else
            {
                wrong++;
                wrongAnswers.Add((item["question"], user, item["answer"]));
            }
        }

        Console.WriteLine($"\nCorrect: {correct}, Wrong : {wrong}");

        if (wrong > 0)
        {
            Console.WriteLine("\nWrong answers:");
            foreach (var w in wrongAnswers)
            {
                Console.WriteLine($"Q: {w.question}\nYour answer : {w.userAnwser}\nCorrect: {w.correctAnwser}\n");
            }

        }
        if (wrong > 3)
        {
            Console.WriteLine("You got more than 3 wrong, play again?");
            string retry = Console.ReadLine();
            if (retry.ToLower() == "yes") Run();
        }
    }

    public static List<Dictionary<string, string>> Questions()
    {
        var data = new List<Dictionary<string, string>>
{
    new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
    new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
    new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
    new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
    new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
    new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
};


return data;
    }
}
