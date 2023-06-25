class ChecklistGoal : Goal
{
    // Additional properties
    public int _Completed { get; set; } // Number of times the goal has been completed
    public int _Required { get; set; } // Number of times the goal needs to be accomplished for a bonus
    public int _Bonus { get; set; } // Bonus points awarded when the goal is completed the required number of times

    public ChecklistGoal(string title, string description, int points, int required, int bonus) : base(title, description)
    {
        _Points = points;
        _Required = required;
        _Bonus = bonus;
    }

    public static ChecklistGoal CreateChecklistGoal(List<Goal> goals)
    {
        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int required = Convert.ToInt32(Console.ReadLine()); // Converts a string to an integer

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = Convert.ToInt32(Console.ReadLine());

        ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, required, bonus);

        Console.WriteLine("Checklist Goal created successfully!");

        return checklistGoal;
    }

    public void CompleteGoal(ref int points)
    {
        _Completed++; // Adds 1 to the counter to indicate that the goal has been completed once
        if (_Completed >= _Required)
        {
            _IsCompleted = true;
            points += _Points; // Adds points for completing the goal
            Console.WriteLine("Congratulations! Goal completed!");
        }
        else
        {
            Console.WriteLine($"Goal partially completed. Currently completed: {_Completed}/{_Required}");
        }
    }
}