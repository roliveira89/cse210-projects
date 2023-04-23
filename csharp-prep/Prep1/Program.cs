using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks user's first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        // Asks user's last name
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        // Print user's name to the terminal
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}