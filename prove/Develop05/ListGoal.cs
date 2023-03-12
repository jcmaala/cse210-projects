public class ListGoal : Goals
{
    public int _listCounter = 0;
    public List<Goals> _goals = new List<Goals>();
    public string _fileName = "";

    public void displayGoals()
    {
        foreach (Goals goal in _goals)
        {
            _listCounter ++;
            Console.WriteLine($"{_listCounter}. {goal.getGoals()}");
        }
    }

    public void displayRecGoals()
    {
        foreach (Goals goal in _goals)
        {
            _listCounter ++;
            Console.WriteLine($"{_listCounter}. {goal.getRecGoals()}");
        }
    }

    public void saveGoals()
    {
        using (StreamWriter output = new StreamWriter(_fileName))
        {
            output.WriteLine(_goals);
        }
    }
}