public class Program
{
    public static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            // Running with date of July 19, 2024 and time of 60 mins/ speed of 3 mph
            new Running(new DateTime(2024, 7, 19), 60, 3.0),
            // Cycling with date of July 19, 2024 and time of 60 mins/ speed of 12 mph
            new Cycling(new DateTime(2024, 7, 19), 60, 12.0),
            // Swimming with date of July 19, 2024 and time of 30 mins/ 50 laps
            new Swimming(new DateTime(2024, 7, 19), 30, 50)
        };

        Console.Clear();
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}