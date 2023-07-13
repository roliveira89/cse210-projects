class Program
{
    static void Main()
    {
        // Create address (street, city, state/province, country)
        Address address1 = new Address("123 Bel St", "Belém", "Pará", "Brazil");
        Address address2 = new Address("456 Gui St", "Guimarães", "Braga", "Portugal");
        Address address3 = new Address("789 Cal St", "Calgary", "Alberta", "Canada");

        // Create events
        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming", new DateTime(2023, 7, 10), new TimeSpan(10, 0, 0), address1, "Nathan Parrish", 50);
        Reception reception = new Reception("City Anniversary", "Join us in celebrating 900th anniversary of our city", new DateTime(2023, 7, 15), new TimeSpan(18, 0, 0), address2, "rsvp@email.com");
        Outdoor gathering = new Outdoor("Summer Camp", "Enjoy exciting days in the Canadian Rockies", new DateTime(2023, 7, 20), new TimeSpan(08, 0, 0), address3, "Sunny with a slight breeze");

        // Generate marketing messages
        Console.WriteLine("--- Lecture ---");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n--- Reception ---");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n--- Outdoor Gathering ---");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(gathering.GetShortDescription());
    }
}