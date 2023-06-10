using System;
using System.Threading;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private static readonly Random random = new Random();

        public ReflectionActivity(int _duration) : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", _duration)
        {
        }

        protected override void PerformActivity()
        {
            string[] prompts = {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            string[] reflectionQuestions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            string _prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(_prompt);

            List<string> usedQuestions = new List<string>();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                string question = GetRandomQuestion(reflectionQuestions, usedQuestions);

                Console.WriteLine("Reflection question: " + question);
                usedQuestions.Add(question);

                Thread.Sleep(10000); // Pause for 10 seconds
            }
        }

        // Exceeding requirements to not use reflection questions more than once
        private string GetRandomQuestion(string[] questions, List<string> usedQuestions)
        {
            // Filter out the questions that have already been used
            var availableQuestions = questions.Except(usedQuestions).ToArray();

            // If all questions have been used, reset the usedQuestions list
            if (availableQuestions.Length == 0)
            {
                usedQuestions.Clear();
                availableQuestions = questions;
            }

            // Select a random question from the available questions
            return availableQuestions[random.Next(availableQuestions.Length)];
        }
    }
}