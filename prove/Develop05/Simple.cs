
class Simple : Goal
{
    //Constructor
    public Simple(string goalName, string goalDesc, int points) : base(goalName, goalDesc, points)
    {

    }
    public override string NewGoal()
    {
        string goalInfo = ($"Simple Goal:[ ]:{_goalName}:{_goalDesc}:{_points}");
        return goalInfo;
    }
    public string RunSimple()
    {
        _goalName = GetGoalName();
        _goalDesc = GetGoalDesc();
        _points = GetPointValue();
        Simple simpleGoal = new Simple(_goalName, _goalDesc, _points);
        string newSimpleGoal = simpleGoal.NewGoal();
        return newSimpleGoal;
    }
    
}
