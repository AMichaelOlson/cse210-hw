class Listing:Activity
{
    // constructor

    public Listing(string title, string desc, int duration) : base(title, desc, duration)
    {

    }


    public string RandomPrompt()
    {
        List<string> prompts = new();
        string prompt1 = "Who are people that you appreciate?";
        string prompt2 = "What are personal strengths of yours?";
        string prompt3 = "Who are people that you have helped this week?";
        string prompt4 = "When have you felt the Holy Ghost this month?";
        string prompt5 = "Who are some of your personal heroes?";

        
        prompts.Add(prompt1);
        prompts.Add(prompt2);
        prompts.Add(prompt3);
        prompts.Add(prompt4);
        prompts.Add(prompt5);

        Random randomPrompt = new();
        int index = randomPrompt.Next(prompts.Count);
        return prompts[index];
    }


    public void RunListing()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity!\n");
        Console.WriteLine(_desc);
        _duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        int counter = 0;
        string prompt = RandomPrompt();
        Console.WriteLine(prompt);
        while (DateTime.Now < futureTime)
        {
            Console.Write("\n> ");
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"You entered {counter} entries!");
        Thread.Sleep(3000);


        Console.Clear();
        Console.WriteLine($"\n{_title} Activity over. Returning to Menu");

        Thread.Sleep(2000);    
        Console.Clear();
    }
}