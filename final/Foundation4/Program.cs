using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create activities
        // (Date, length in min, distance covered in km)
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 4.8f);
        // (Date, length in min, speed in km/h)
        Activity cycling = new Cycling(new DateTime(2022, 11, 4), 30, 25.5f);
        // (Date, length in min, number of laps)
        Activity swimming = new Swimming(new DateTime(2022, 11, 5), 30, 30);

        // Store activities in a list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}