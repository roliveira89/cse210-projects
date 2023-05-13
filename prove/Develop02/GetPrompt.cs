using JournalApp;

public class GetPrompt
{
    private List<string> prompts = new List<string> {
            // Randomly displayed prompts to the user when creating a new entry
            "What was the best thing that happened today?",
            "What was the most challenging thing you faced today?",
            "How did I see the hand of the Lord in my life today?",
            "What did you learn today?",
            "What are you grateful for today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something you want to improve on?"
        };

        public string GetRandomPrompt()
        {
            Random random = new Random();
            // Generates a random integer between 0 and the number of prompts in the prompts list minus 1
            int _index = random.Next(prompts.Count);
            return prompts[_index];
        }
}