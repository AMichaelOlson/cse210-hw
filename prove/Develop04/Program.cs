using System;
using System.ComponentModel.Design;

class Program
{
    public static void Menu()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Welcome to the Mindful Activities program! You choices are below:\n");
            Console.Write("    1: Breathing Activity\n    2: Reflection Activity\n    3: Listing Activity\n    4: Quit\n");
            Console.Write("Please Type Your Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Breathing Activity was picked");
                    Breathing breathactivity = new Breathing("Breathing", "This Acitivity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                    breathactivity.RunBreathing();
                    break;

                case "2":
                    Console.WriteLine("Reflection Activity was picked");
                    Reflection reflectactivity = new Reflection("Reflection", "This Acitivity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
                    reflectactivity.RunReflection();
                    break;

                case "3":
                    Console.WriteLine("Listing Activity was picked");
                    Listing listingactivity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30);
                    listingactivity.RunListing();
                    break;

                case "4":
                Console.WriteLine("Quitting the Program...");
                Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-4:");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }
    }
    static void Main(string[] args)
    {
        Menu();
    }
    
}