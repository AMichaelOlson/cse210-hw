
class Eternal : Goal
{
    //Constructor
    public Eternal(string goalName, string goalDesc, int points) : base(goalName, goalDesc, points)
    {

    }
    public override string NewGoal()
    {
        string goalInfo = ($"Eternal Goal:[ ]:{_goalName}:{_goalDesc}:{_points}");
        return goalInfo;
    }
    public string RunEternal()
    {
        _goalName = GetGoalName();
        _goalDesc = GetGoalDesc();
        _points = GetPointValue();
        Eternal eternalGoal = new Eternal(_goalName, _goalDesc, _points);
        string newEternalGoal = eternalGoal.NewGoal();
        return newEternalGoal;
    }
    
}
