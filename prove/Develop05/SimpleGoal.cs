class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points) : base(title, description)
    {
        _Points = points;
    }

    public static SimpleGoal CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // Creates a new SimpleGoal object using the constructor
        SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
        Console.WriteLine("Simple goal created successfully!");

        return simpleGoal;
    }
}