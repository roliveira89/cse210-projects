using System;

namespace MindfulnessApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");

            while (true)
            {
                // Display the menu options
                Console.WriteLine("Mindfulness App");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Select an activity (1-4):");

                // Read the user's input
                string input = Console.ReadLine();

                // Parse the input as an integer
                if (int.TryParse(input, out int choice))
                {
                    // Check the user's choice
                    switch (choice)
                    {
                        case 1:
                            RunBreathingActivity();
                            break;
                        case 2:
                            RunReflectionActivity();
                            break;
                        case 3:
                            RunListingActivity();
                            break;
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid activity.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
        }

        private static void RunBreathingActivity()
        {
            Console.WriteLine("Enter the duration in seconds:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int duration))
            {
                var _activity = new BreathingActivity(duration);
                _activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid duration. Please enter a valid number.");
            }
        }

        private static void RunReflectionActivity()
        {
            Console.WriteLine("Enter the duration in seconds:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int duration))
            {
                var _activity = new ReflectionActivity(duration);
                _activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid duration. Please enter a valid number.");
            }
        }

        private static void RunListingActivity()
        {
            Console.WriteLine("Enter the duration in seconds:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int duration))
            {
                var _activity = new ListingActivity(duration);
                _activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid duration. Please enter a valid number.");
            }
        }
    }
}