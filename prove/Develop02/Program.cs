using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static List<Entry> journal = new List<Entry>();
        static List<string> prompts = new List<string> {
            "What was the best thing that happened today?",
            "What was the most challenging thing you faced today?",
            "How did I see the hand of the Lord in my life today?",
            "What did you learn today?",
            "What are you grateful for today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something you want to improve on?"
        };

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Journal App Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string _choice = Console.ReadLine();
                Console.WriteLine();

                switch (_choice)
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        DisplayJournal();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void WriteNewEntry()
        {
            Console.WriteLine("New Entry:");
            string _prompt = GetRandomPrompt();
            Console.WriteLine("Prompt: " + _prompt);
            Console.Write("Response: ");
            string _response = Console.ReadLine();
            Entry _entry = new Entry(_prompt, _response, DateTime.Now);
            journal.Add(_entry);
        }

        static void DisplayJournal()
        {
            if (journal.Count == 0)
            {
                Console.WriteLine("Journal is empty.");
            }
            else
            {
                foreach (Entry entry in journal)
                {
                    Console.WriteLine(entry.ToString());
                    Console.WriteLine();
                }
            }
        }

        static void SaveJournal()
        {
            Console.Write("Enter a filename to save the journal to: ");
            string filename = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Entry entry in journal)
                    {
                        writer.WriteLine(entry.ToFileString());
                    }
                }

                Console.WriteLine("Journal saved to " + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving journal: " + ex.Message);
            }
        }

        static void LoadJournal()
        {
            Console.Write("Enter a filename to load the journal from: ");
            string filename = Console.ReadLine();

            try
            {
                List<Entry> newJournal = new List<Entry>();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string _line;
                    while ((_line = reader.ReadLine()) != null)
                    {
                        string[] parts = _line.Split('|');
                        if (parts.Length == 3)
                        {
                            string _prompt = parts[0];
                            string _response = parts[1];
                            DateTime _date;
                            if (DateTime.TryParse(parts[2], out _date))
                            {
                                Entry entry = new Entry(_prompt, _response, _date);
                                newJournal.Add(entry);
                            }
                        }
                    }
                }

                journal = newJournal;
                Console.WriteLine("Journal loaded from " + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading journal: " + ex.Message);
            }
        }

        static string GetRandomPrompt()
        {
            Random random = new Random();
            int _index = random.Next(prompts.Count);
            return prompts[_index];
        }
    }

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return "Date: " + Date.ToString("MM/dd/yyyy") + Environment.NewLine +
            "Prompt: " + Prompt + Environment.NewLine +
            "Response: " + Response;
    }

    public string ToFileString()
    {
        return Prompt + "|" + Response + "|" + Date.ToString("MM/dd/yyyy");
    }
}
}