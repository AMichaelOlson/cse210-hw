class Breathing:Activity
{
    // constructor

    public Breathing(string title, string desc, int duration) : base(title, desc, duration)
    {
        
    }
    
    public void RunBreathing()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity!\n");
        Console.WriteLine(_desc);

        _duration = GetDuration();
        LoadingAnimation(200);
        Console.Write("\b\b\b");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Clear();
            Console.WriteLine("\nBreathe in...");
            Console.WriteLine("3");
            Thread.Sleep(1000);
 
            Console.WriteLine("2");
            Thread.Sleep(1000);

            Console.WriteLine("1");
            Thread.Sleep(1000);

            Console.WriteLine("\nBreathe Out...");
            Console.WriteLine("3");
            Thread.Sleep(1000);
 
            Console.WriteLine("2");
            Thread.Sleep(1000);

            Console.WriteLine("1");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine($"\n{_title} Activity over. Returning to Menu");

        Thread.Sleep(2000);    
        Console.Clear();
    }

}