public class Running : Activity
{
    private double distance; // distance in miles or kilometers

    public Running(DateTime date, int duration, double distance) 
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {distance} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}