using System;

class Program
{
static void Main()
{
    Scripture scripture = new Scripture();

    scripture.AddToList(new Words("And "));
    scripture.AddToList(new Words("he "));
    scripture.AddToList(new Words("said "));
    scripture.AddToList(new Words("unto "));
    scripture.AddToList(new Words("them: "));
    scripture.AddToList(new Words("Behold, "));
    scripture.AddToList(new Words("my "));
    scripture.AddToList(new Words("bowels "));
    scripture.AddToList(new Words("are "));
    scripture.AddToList(new Words("filled "));
    scripture.AddToList(new Words("with "));
    scripture.AddToList(new Words("compassion "));
    scripture.AddToList(new Words("towards "));
    scripture.AddToList(new Words("you. "));

    if (scripture.ListWords.Count > 0)
    {
        Random random = new Random();

        Console.WriteLine("Press Enter to reveal");
        Console.ReadLine();

        scripture.Display(); // Display the entire scripture initially

        while (scripture.ListWords.Exists(word => word.Show))
        {
            Console.ReadLine(); // Wait for user input before revealing the next set of words
            Console.Clear(); // Clear the console before displaying the next set of words

            // Reveal three random words at a time
            for (int i = 0; i < 3; i++)
            {
                scripture.RandomWordUnderscore();
            }

            scripture.Display(); // Display the updated scripture with hidden words
        }
    }

    Console.WriteLine("\nAll words revealed. Press Enter to exit.");
    Console.ReadLine();
}
}