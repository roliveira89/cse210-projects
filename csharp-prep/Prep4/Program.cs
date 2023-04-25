using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Adding numbers to the list that are not zero
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Computing the sum
        int sum = 0;
        foreach (int entry in numbers)
        {
            sum += entry;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Computing the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Finding the maximum and minimum numbers
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");

        // Finding the minimum positive number
        int minPosNum = numbers.Where(i => i > 0).Min();
        Console.WriteLine($"The smallest positive number is: {minPosNum}");

        // Sorted list
        numbers.Sort();
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}