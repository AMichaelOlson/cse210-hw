using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first and last name when prompted.");
        Console.Write("Enter your first name: ");
        string first = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string last = Console.ReadLine();

        Console.WriteLine($"Nice to meet you {last}, {first} {last}.");
    }
}