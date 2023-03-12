public class Goals
{
    protected string _goalName = "";
    protected string _goalDesc = "";
    public int _goalPoints = 0;
    protected string _marker = "";


    public virtual string getGoals()
    {
        return $"[{_marker}] {_goalName} ({_goalDesc})";
    }

    public string getRecGoals()
    {
        return $"{_goalName}";
    }

}