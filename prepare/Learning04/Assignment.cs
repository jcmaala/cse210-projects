public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment (string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}