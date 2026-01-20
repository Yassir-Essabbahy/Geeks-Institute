using System;
using System.Collections.Generic;

class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = "Pending"; 
    public DateTime? DueDate { get; set; } 

    public void DisplayTask(int index)
    {
        Console.WriteLine($"{index}. {Title} | {Description} | Status: {Status} | Due: {DueDate?.ToString("yyyy-MM-dd") ?? "N/A"}");
    }
}
class Program {
    static List<Task> tasks = new List<Task>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to Your Task Manager!");
            Console.WriteLine("1. Add a Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task Status");
            Console.WriteLine("4. Delete a Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    UpdateTaskStatus();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}