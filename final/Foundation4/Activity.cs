public class Activity
{
    private DateTime date;
    private int duration; // duration in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} ({duration} min)";
    }
}