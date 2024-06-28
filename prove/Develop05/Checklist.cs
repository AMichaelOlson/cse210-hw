
class Checklist : Goal
{
    //COnstructor
    public Checklist(string goalName, string goalDesc, int points) : base(goalName, goalDesc, points)
    {

    }
    public override string NewGoal()
    {
        string goalInfo = ($"Checklist Goal:[ ]:{_goalName}:{_goalDesc}:{_points}");
        return goalInfo;
    }
    public string RunChecklist()
    {
        _goalName = GetGoalName();
        _goalDesc = GetGoalDesc();
        _points = GetPointValue();
        Checklist checklistGoal = new Checklist(_goalName, _goalDesc, _points);
        string newChecklistGoal = checklistGoal.NewGoal();
        return newChecklistGoal;
    }
    
}
