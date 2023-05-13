using JournalApp;

public class Entry
{
    // Class entry has 3 properties (prompt, response, date)
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // This method returns a formatted string representation of the entry
    public override string ToString()
    {
        return "Date: " + Date.ToString("MM/dd/yyyy") + Environment.NewLine +
            "Prompt: " + Prompt + Environment.NewLine +
            "Response: " + Response;
    }

    public string ToFileString()
    // Returns a string representation of the entry in a format that can be used to save the entry to a file
    {
        // Returns the concatenated prompt as a string of the format:
        return Prompt + "|" + Response + "|" + Date.ToString("MM/dd/yyyy");
    }
}