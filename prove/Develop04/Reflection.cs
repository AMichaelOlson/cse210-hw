class Reflection:Activity
{
    // constructor

    public Reflection(string title, string desc, int duration) : base(title, desc, duration)
    {

    }

    public string RandomPrompt()
    {
        List<string> prompts = new();
        string prompt1 = "Think of a time when you stood up for someone else.";
        string prompt2 = "Think of a time when you did something really difficult.";
        string prompt3 = "Think of a time when you helped someone in need.";
        string prompt4 = "Think of a time when you did something truly selfless.";

        
        prompts.Add(prompt1);
        prompts.Add(prompt2);
        prompts.Add(prompt3);
        prompts.Add(prompt4);

        Random randomPrompt = new();
        int index = randomPrompt.Next(prompts.Count);
        return prompts[index];
    }

    public string RandomQuestion()
    {
        List<string> questions = new();
        string question1 = "Why was this experience meaningful to you?";
        string question2 = "Have you ever done anything like this before?";
        string question3 = "How did you get started?";
        string question4 = "How did you feel when it was complete?";
        string question5 = "What made this time different than other times when you were not as successful?";
        string question6 = "What is your favorite thing about this experience?";
        string question7 = "What could you learn from this experience that applies to other situations?";
        string question8 = "What did you learn about yourself through this experience?";
        string question9 = "How can you keep this experience in mind in the future?";
        
        questions.Add(question1);
        questions.Add(question2);
        questions.Add(question3);
        questions.Add(question4);
        questions.Add(question5);
        questions.Add(question6);
        questions.Add(question7);
        questions.Add(question8);
        questions.Add(question9);

        Random randomPrompt = new();
        int index = randomPrompt.Next(questions.Count);
        return questions[index];
    }

    public void RunReflection()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity!\n");
        Console.WriteLine(_desc);
        _duration = GetDuration();



        Console.WriteLine("Get Ready...");
        LoadingAnimation(200);
        Console.WriteLine("\n");
        Console.Clear();
        string prompt = RandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Think for a moment, when you have something in mind press enter:\n");
        Console.ReadLine();
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"You may begin in: {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            
        }
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(prompt);
            string randomquestion = RandomQuestion();
            Console.WriteLine($"\n{randomquestion}");
            LoadingAnimation(400);
            Console.Clear();


        }



        Console.Clear();
        Console.WriteLine($"\n{_title} Activity over. Returning to Menu");

        Thread.Sleep(2000);    
        Console.Clear();
    }
}