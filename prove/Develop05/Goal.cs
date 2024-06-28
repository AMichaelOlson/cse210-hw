
class Goal
{
    protected string _goalName;
    protected string _goalDesc;
    protected int _points;

    public Goal(string goalName, string goalDesc, int points)
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
        _points = points;
    }
    public string GetGoalName()
    {
        Console.WriteLine("What will you call your goal? ");
        _goalName = Console.ReadLine();
        return _goalName;
    }
    public string GetGoalDesc()
    {
        Console.WriteLine("What is a short description of your goal? ");
        _goalDesc = Console.ReadLine();
        return _goalDesc;
    }
    public int GetPointValue()
    {
        Console.WriteLine("How many points is completing this goal once worth? ");
        string pointvalue = Console.ReadLine();
        int _points = int.Parse(pointvalue);
        return _points;
    }
    public virtual string NewGoal()
    {
        string polymorphism = "This will be replaced";
        return polymorphism;
    }
}
