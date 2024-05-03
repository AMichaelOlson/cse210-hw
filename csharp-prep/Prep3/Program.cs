using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game!");
        int guess = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        while (guess != number)
        {
            Console.WriteLine("Please enter your guess: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess < number)
            {
                Console.WriteLine($"You guessed {guess}, but that was too low.");
            }
            else if (guess > number)
            {
                Console.WriteLine($"You guessed {guess}, but that was too high.");
            }
        }
Console.WriteLine("Way to go! You guessed the number!");

    }
}