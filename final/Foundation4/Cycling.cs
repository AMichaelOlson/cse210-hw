public class Cycling : Activity
{
    private double speed; // speed in miles per hour

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * Duration) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance: {GetDistance():0.0} miles, Speed: {speed} mph, Pace: {GetPace():0.0} min per mile";
    }
}