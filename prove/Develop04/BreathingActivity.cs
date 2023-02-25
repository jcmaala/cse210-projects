public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _startingMessage1 = "Welcome to Breathing Activity.";
        _startingMessage2 = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public BreathingActivity(int countdownTimer) : base(countdownTimer)
    {
        _countdownTimer = countdownTimer;
    }

    public string getBreathingActIntro()
    {
        return $"{_startingMessage1} \n\n{_startingMessage2} ";
    }

    
}