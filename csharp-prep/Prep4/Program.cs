using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;

        while (newNumber != 0)
        {
                Console.WriteLine("Type a number, type 0 to quit: ");
                string newEntry = Console.ReadLine();
                newNumber = int.Parse(newEntry);

                if (newNumber != 0)
                {
                    numbers.Add(newNumber);
                }
        }
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The total sum is {total}.");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The Average from the given numbers is {average}.");


        int highestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > highestNumber)
            {
                highestNumber = number;
            }
        }
        Console.WriteLine($"The highest number from the given numbers is {highestNumber}");
    }
}