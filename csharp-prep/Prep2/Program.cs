using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type your grade percentage into the terminal: ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);

        string grade = "";

        if (percent >= 90){
            grade = "A";
        }

        else if (percent >= 80){
            grade = "B";
        }

        else if (percent >= 70){
            grade = "C";
        }

        else if (percent >= 60){
            grade = "D";
        }

        else{
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}.");

        if (percent >= 70){
            Console.WriteLine("Congrats! You passed that class!");
        }

        else{
            Console.WriteLine("Oops, looks like you'll need to take that one again.");
        }
    }
}