using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private static readonly Random random = new Random();
        private static readonly List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private int _itemCount;
        private Timer _timer;

        public ListingActivity(int _duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", _duration)
        {
        }

        protected override void PerformActivity()
        {
            string _prompt = GetRandomPrompt();
            Console.WriteLine(_prompt);

            Thread.Sleep(3000); // Pause for 3 seconds

            _itemCount = 0;

            _timer = new Timer(EndActivity, null, _duration * 1000, Timeout.Infinite);

            while (true)
            {
                Console.Write("> ");
                string _item = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(_item))
                    break;

                _itemCount++;
            }

            _timer.Dispose();

            Console.WriteLine("");
            Console.WriteLine("You listed {0} items.", _itemCount);
        }

        private void EndActivity(object state)
        {
            Console.WriteLine("");
            Console.WriteLine("Time's up!");
            Console.WriteLine("");

            _timer.Dispose();

            Console.WriteLine("You listed {0} items.", _itemCount);
        }

        private string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}