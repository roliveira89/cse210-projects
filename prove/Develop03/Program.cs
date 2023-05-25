using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        Scripture scripture = new Scripture(new Reference("Proverbs 3:5-6"), "Trust in the Lord with all thine heart; and lean not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths.");

        Console.WriteLine("Complete Scripture:");
        scripture.DisplayScripture();

        Console.WriteLine("\nPress Enter to hide 3 words or type 'quit' to exit.");
        string input = Console.ReadLine();

        Random random = new Random();

        while (input.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.HideRandomWords(random, 3);

            Console.WriteLine("Partial Scripture:");
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide 3 words or type 'quit' to exit.");
            input = Console.ReadLine();
        }

        Console.WriteLine("Program ended.");
    }
}