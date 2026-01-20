    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();

        Console.Write("Enter task description: ");
        string description = Console.ReadLine();

        Task task = new Task
        {
            Title = title,
            Description = description
        };

        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }
    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        Console.WriteLine("\nYour Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            tasks[i].DisplayTask(i + 1);
        }
    }
    static void UpdateTaskStatus()
    {
        ViewTasks();
        if (tasks.Count == 0) return;

        Console.Write("Enter task number to update: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            Task task = tasks[index - 1];
            task.Status = task.Status == "Pending" ? "Completed" : "Pending";
            Console.WriteLine($"Task status updated to {task.Status}.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    static void DeleteTask()
    {
        ViewTasks();
        if (tasks.Count == 0) return;

        Console.Write("Enter task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            Console.Write($"Are you sure you want to delete '{tasks[index - 1].Title}'? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task deleted successfully.");
            }
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
// just testing 
