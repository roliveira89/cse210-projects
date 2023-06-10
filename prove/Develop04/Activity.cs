using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name { get; set; }
        protected string _description { get; set; }
        protected int _duration { get; set; }

        protected Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        protected abstract void PerformActivity();

        protected void DisplayStartingMessage()
        {
            Console.WriteLine(_name + " Activity");
        }

        protected void DisplayDescription()
        {
            Console.WriteLine("Description: " + _description);
        }

        protected void PerformPreparation()
        {
            Console.WriteLine("Prepare to begin...");
            SpinnerAnimation(6); // Display spinner animation for 6 seconds
        }

        protected void PerformEnding()
        {
            Console.WriteLine("Good job!");
            Console.WriteLine("You completed the activity for " + _duration + " seconds.");
        }

        protected void SpinnerAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b-");
                Thread.Sleep(250);
                Console.Write("\b\\");
                Thread.Sleep(250);
                Console.Write("\b|");
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        protected void CountdownTimer(int duration)
        {
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                int remainingSeconds = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
                Console.WriteLine("Time remaining: " + remainingSeconds + " seconds");
                Thread.Sleep(1000);
            }
        }

        public void Run()
        {
            DisplayStartingMessage();
            DisplayDescription();

            PerformPreparation();

            Console.WriteLine("Start activity...");

            PerformActivity();

            PerformEnding();
        }
    }
}