using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static List<Entry> journal = new List<Entry>();
        // List that holds all the journal entries created by the user

        static void Main(string[] args)
        {
            GetPrompt promptGenerator = new GetPrompt();
            
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
                        // Generate a prompt for the new entry
                        WriteNewEntry(promptGenerator);
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

        static void WriteNewEntry(GetPrompt promptGenerator)
        // Use GetPrompt class as a parameter to generate the prompt for the new entry.
        {
            Console.WriteLine("New Entry:");
            // Prompt user with a random prompt from the list
            string _prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine("Prompt: " + _prompt);
            Console.Write("Response: ");
            // Register the answer
            string _response = Console.ReadLine();
            // Create a new entry object with info about the prompt, answer, date and time
            Entry _entry = new Entry(_prompt, _response, DateTime.Now);
            // Add the entry to the journal list
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
                    // Convert object to string (suitable to display)
                    Console.WriteLine(entry.ToString());
                    Console.WriteLine();
                }
            }
        }

        static void SaveJournal()
        {
            // Prompt user for a filename
            Console.Write("Enter a filename to save the journal to: ");
            string filename = Console.ReadLine();

            try
            {
                // Create a new file and write text to it
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    // Write all the entries in the journal list to a file
                    foreach (Entry entry in journal)
                    {
                        // Format data as a string
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
            // Prompt user for a filename
            Console.Write("Enter a filename to load the journal from: ");
            string filename = Console.ReadLine();

            try
            {
                // Create a new list to hold the entries loaded from the chosen file
                List<Entry> newJournal = new List<Entry>();
                // Read line by line of the file
                using (StreamReader reader = new StreamReader(filename))
                {
                    string _line;
                    while ((_line = reader.ReadLine()) != null)
                    {
                        // Split each line into 3 parts
                        string[] parts = _line.Split('|');
                        // Check if the line contains three parts, which is
                        // the expected number of parts for a valid entry
                        if (parts.Length == 3)
                        {
                            // Extract the prompt, response, and date values from the parts
                            string _prompt = parts[0];
                            string _response = parts[1];
                            DateTime _date;
                            if (DateTime.TryParse(parts[2], out _date))
                            {
                                // Create a new entry object from the extracted values and adds it to the
                                // newJournal list, replacing the actual journal with the one from the filename
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
    }
}