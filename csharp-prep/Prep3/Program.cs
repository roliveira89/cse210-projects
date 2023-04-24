using System;

class Program
{
    static void Main(string[] args)
    {
        // User provides the magic number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // User guesses the number
        // Console.Write("What is your guess? ");
        // int guess = int.Parse(Console.ReadLine());

        Console.WriteLine("Let's play a game.");
        Console.WriteLine("Try to guess a number from 1 to 100.");

        do
        {
            PlayGame();
            Console.WriteLine("Would you play to play again? Y or N");
        } while (Console.ReadLine().ToLower() == "y");
    }

    public static void PlayGame()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        int guesses = 0;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                guesses++;
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                guesses++;
                Console.WriteLine("Higher");
            }
            else
            {
                guesses++;
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You did it in {guesses} attempts.");
            }
        }                    
    }
}