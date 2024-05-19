using System;

class Entry
{
    public static string entryCollector(string filename)
    {
        //This method runs the prompt generator, and then adds the date and time to it before saving it as a formatted string
        Prompt prompt = new Prompt();
        string randomPrompt = prompt.promptGenerator();

        Console.WriteLine(randomPrompt);
        Console.WriteLine("Enter your Journal Entry:");
        string entry = Console.ReadLine();

        DateTime CurrentTime = DateTime.Now;

        string formattedEntry = $"{CurrentTime}\n{randomPrompt}\n{entry}\n";

        SaveEntryToFile(formattedEntry, filename);

        return formattedEntry;
    }

    private static void SaveEntryToFile(string entry, string filename)
    {
        //This method allows the program to save the journal entry to the end of the chosen file.
        try
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename, true))
            {
                writer.WriteLine(entry);
            }

            Console.WriteLine("Entry saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving entry: {ex.Message}");
        }
    }

}