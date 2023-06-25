class Program
{
    private Goals _goals;
    private int _points;

    public Program() // Constructor creates new instance of the Goals class and set points to 0
    {
        _goals = new Goals();
        _points = 0;
    }

    public void Run()
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine($"You have {_goals.GetPoints()} points.\n"); // Displays current points by calling the GetPoints method of the goals object

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string _choice = Console.ReadLine();
            Console.WriteLine();

            switch (_choice)
            {
                case "1":
                    _goals.CreateNewGoal();
                    break;
                case "2":
                    _goals.ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    _goals.RecordEvent();
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void SaveGoals()
    {
        // Need to do this
        Console.WriteLine("SaveGoals() method is not implemented yet.");
    }

    private void LoadGoals()
    {
        // Need to do this
        Console.WriteLine("LoadGoals() method is not implemented yet.");
    }

    static void Main(string[] args)
    {
        // Creates an instance of the Program class and calls the Run method to start the program logic
        Program program = new Program();
        program.Run();
    }
}