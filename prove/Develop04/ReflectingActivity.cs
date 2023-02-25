public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        _startingMessage1 = "Welcome to reflecting Activity";
        _startingMessage2 = "This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string getReflectingActIntro ()
    {
        return $"{_startingMessage1} \n\n{_startingMessage2}";
    }
}