using System;
using System.Collections.Generic;

abstract class Goal
{
    public string _Title { get; set; }
    public string _Description { get; set; }
    public bool _IsCompleted { get; set; }
    public int _Points { get; set; }

    public Goal(string title, string description) // Constructor initializing properties
    {
        _Title = title;
        _Description = description;
        _IsCompleted = false;
        _Points = 0;
    }

    // Overrides the base implementation and eturns a string representation of the goal
    public override string ToString()
    {
        return $"Title: {_Title}\nDescription: {_Description}\nIsCompleted: {_IsCompleted}\nPoints: {_Points}";
    }
}

class Goals
{
    // Store goals in a list and keep track of points
    private List<Goal> _goals = new List<Goal>();
    private int _points;

    public Goals()
    {
        _points = 0;
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice. Returning to the main menu.");
                break;
        }
    }

    // Creates goals and adds them to the goals list
    private void CreateSimpleGoal()
    {
        SimpleGoal simpleGoal = SimpleGoal.CreateSimpleGoal();
        _goals.Add(simpleGoal);
    }

    private void CreateEternalGoal()
    {
        EternalGoal eternalGoal = EternalGoal.CreateEternalGoal();
        _goals.Add(eternalGoal);
    }

    private void CreateChecklistGoal()
    {
        ChecklistGoal checklistGoal = ChecklistGoal.CreateChecklistGoal(_goals);
        _goals.Add(checklistGoal);
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];

            if (goal is ChecklistGoal checklistGoal)
            {
                // Displays checklist goals
                string completedSymbol = checklistGoal._IsCompleted && checklistGoal._Completed >= checklistGoal._Required ? "X" : " ";
                Console.WriteLine($"{i + 1}. [{completedSymbol}] {checklistGoal._Title} ({checklistGoal._Description}) - {checklistGoal._Points} points - Currently completed: {checklistGoal._Completed}/{checklistGoal._Required}");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                // Displays eternal goals
                Console.WriteLine($"{i + 1}. [ ] {eternalGoal._Title} ({eternalGoal._Description}) - {eternalGoal._Points} points");
            }
            else
            {
                // Displays simple goals
                string completedSymbol = goal._IsCompleted ? "X" : " ";
                Console.WriteLine($"{i + 1}. [{completedSymbol}] {goal._Title} ({goal._Description}) - {goal._Points} points");
            }
        }

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");

        for (int i = 0; i < _goals.Count; i++)
        {
            // Gets corresponding goal from the goals list through the index
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal._Title}");
        }

        Console.Write("Enter the number of the goal you accomplished: ");
        string goalChoice = Console.ReadLine();
        Console.WriteLine();

        // Converts string into integer to check the goal index
        // Checks if the goal index is within the range indexes in the goals list, to make sure it exists
        if (int.TryParse(goalChoice, out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            // Subtracts 1 to get the correct index used to access the goal from the list
            Goal goal = _goals[goalIndex - 1];

            if (goal is ChecklistGoal checklistGoal)
            {
                checklistGoal.CompleteGoal(ref _points);
                if (checklistGoal._IsCompleted)
                {
                    _points += checklistGoal._Bonus; // Adds bonus points to the total points
                    Console.WriteLine($"Congratulations! You have earned {checklistGoal._Points} points for completing the goal!");
                    Console.WriteLine($"You have also earned {checklistGoal._Bonus} bonus points!");
                }
                else
                {
                    _points += checklistGoal._Points; // Adds base points for completion without bonus
                    Console.WriteLine($"Congratulations! You have earned {checklistGoal._Points} points for completing the goal!");
                }
            }
            else
            {
                goal._IsCompleted = true;
                _points += goal._Points; // Add points for other goals here
                Console.WriteLine($"Congratulations! You have earned {goal._Points} points!");
            }

            Console.WriteLine($"You now have {_points} total points.");
        }
        else
        {
            Console.WriteLine("Invalid goal choice. No event recorded.");
        }
    }

    public int GetPoints()
    {
        return _points;
    }
}