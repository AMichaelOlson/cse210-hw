using System;

class Program
{
    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        string name = GetName();
        int number = GetNumber();

        int squaredNumber = SqaureUserNumber(number);
        PrintSquaredNumber(name, squaredNumber);

    }

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");        
    }

        static string GetName()
    {
        Console.Write("Please type your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetNumber()
    {
        Console.Write("Please type a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SqaureUserNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void PrintSquaredNumber(string name, int square)
    {
        Console.WriteLine($"{name}, Your number squared is: {square}");
    }
}