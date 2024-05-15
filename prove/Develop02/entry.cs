using System;
using System.Runtime.Intrinsics.Arm;


class Entry
{
    public static void entryCollector()
    {
        Prompt prompt = new();
        string randomPrompt = prompt.promptGenerator();

        Console.WriteLine(randomPrompt);
        Console.WriteLine("Enter your Journal Entry:");
        string entry = Console.ReadLine();

        return;
    }
}