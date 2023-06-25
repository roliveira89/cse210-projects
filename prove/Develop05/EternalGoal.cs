class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title, description)
    {
        _Points = points;
    }

    public static EternalGoal CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // Create a new EternalGoal object using the constructor
        EternalGoal eternalGoal = new EternalGoal(title, description, points);
        Console.WriteLine("Eternal goal created successfully!");

        return eternalGoal;
    }
}