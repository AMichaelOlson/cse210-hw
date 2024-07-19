public class Program
{
    public static void Main(string[] args)
    {
        // Creating instances of each activity
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 19), 60, 3.0),
            new Cycling(new DateTime(2024, 7, 19), 60, 12.0),
            new Swimming(new DateTime(2024, 7, 19), 30, 50)
        };

        Console.Clear();
        // Displaying summaries
        foreach (var activity in activities)
        {

            Console.WriteLine(activity.GetSummary());
        }
    }
}