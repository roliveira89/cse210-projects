using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        if (percent == 100)
        {
            sign = "";
        }
        else if (percent % 10 >= 7)
        {
            sign = "+";
        }
        else if (percent % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time!");
        }
    }
}