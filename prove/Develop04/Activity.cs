using System.Reflection.Metadata.Ecma335;

class Activity
{
    protected string _title;

    protected string _desc;

    protected int _duration;

    public Activity(string title, string desc, int duration)
    {
        _title = title;
        _desc = desc;
        _duration = duration;
    }
    public int GetDuration()
    {
        Console.WriteLine("How long would you like the Activity to be in seconds?\n");
        string duration = Console.ReadLine();
        int intdur = int.Parse(duration);
        _duration = intdur;
        return _duration;
    }

    public void LoadingAnimation(int time)
    {
        for (int i = 3; i>=0; i--){
            Console.Write("\b\b\bO-O");
            Thread.Sleep(time); 
            Console.Write("\b\b\b0o0");
            Thread.Sleep(time);
            Console.Write("\b\b\bo0o");
            Thread.Sleep(time);
            Console.Write("\b\b\b-O-");
            Thread.Sleep(time);
            Console.Write("\b\b\bo0o");
            Thread.Sleep(time);
            Console.Write("\b\b\b0o0");
            Thread.Sleep(time);
            Console.Write("\b\b\bO-O");
        }
        
    }
}





