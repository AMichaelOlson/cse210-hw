using System;
using System.IO;

public class Menu
{
    public static void DisplayMenu()
    {
        //Print out the available options of the menu
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1: Load");
        Console.WriteLine("2: Write");
        Console.WriteLine("3: Display");
        Console.WriteLine("4: Quit");
    }

    public static void MenuSelection(string selection, ref string filename)
    {
        //Begin a switch statement allowing the user to select any option until the choose option 4
        switch (selection)
        {
            case "1":
                filename = LoadEntries();
                break;
            case "2":
                WriteEntry(filename);
                break;
            case "3":
                DisplayEntries(filename);
                break;
            case "4":
                Console.WriteLine("Thanks for typing!");
                Environment.Exit(0);
                break;
            default:
            //Default reminds them to choose an applicable option
                Console.WriteLine("Please choose a number from 1 to 4.");
                break;
        }
    }

    private static string LoadEntries()
    {
        //This method allows the user to choose a file to add to. default value is journal.txt
        Console.WriteLine("Please enter the name of the file you want to load: \n");
        string filename = Console.ReadLine();
        Console.WriteLine("Loading entries...");
        return filename;
    }

    private static void DisplayEntries(string filename)
    {
        //This will output each line in the file assuming it has lines of text to display
        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"File '{filename}' not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error displaying entries: {ex.Message}");
        }
    }

    private static void WriteEntry(string filename)
    { 
        //This method allows the user to type their entry
        string entry = Entry.entryCollector(filename);
        Console.WriteLine("Entry saved:");
        Console.WriteLine(entry);

    }

    public static void RunMenu(string defaultFileName = "journal.txt")
    {
        //This method runs the menu for the program
        string filename = defaultFileName;
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            MenuSelection(choice, ref filename);
        }
    }
}