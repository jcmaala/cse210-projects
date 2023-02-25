public class Activity
{
    protected string _startingMessage1 = "";
    protected string _startingMessage2 = "";
    protected string _endingMessage = "";
    protected int _countdownTimer = 0;

    public Activity()
    {
        
    }

    public Activity(int countdownTimer)
    {
        _countdownTimer = countdownTimer;
    }

    public string getOpening()
    {
        return $"Get ready...";
    }

    public string getSessionMessage()
    {
        return $"How long, in seconds, would you like for your session?";
    }
}