public class ChecklistGoal : Goals
{
    protected int _bonusTimes = 0;
    protected int _bonusPoints = 0;
    protected int _goalDone = 0;

    public ChecklistGoal (string goalName, string goalDesc)
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
    }
    public ChecklistGoal (string goalName, string goalDesc, int bonusTimes)
    {
        _goalName = goalName;
        _goalDesc = goalDesc;
        _bonusTimes = bonusTimes;
    }

    public override string getGoals()
    {
        return $"[{_marker}] {_goalName} ({_goalDesc}) -- Currently completed: {_goalDone}/{_bonusTimes}";
    }
    
}