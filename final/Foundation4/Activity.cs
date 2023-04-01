public class Activity
{
    static DateTime theTime = DateTime.Now;
    private string dateText = theTime.ToShortDateString();
    protected double _minutes = 0;
    protected string _exercise = "";

    protected double _speed = 0;
    protected double _distance = 0;
    protected double _pace = 0;

     public Activity(string exercise, double distance, double minutes)
    {
        _exercise = exercise;
        _distance = distance;
        _minutes = minutes;
    }

    public virtual double _distanceFinal()
    {
        return _distance;
    }

    public virtual double _speedFinal()
    {
        return _speed;
    }

    public virtual double _paceFinal()
    {
        return _pace;
    }

    public void getSummary()
    {
        double distanceFinal = _distanceFinal();
        double speedFinal = _speedFinal();
        double paceFinal = _paceFinal();
        Console.WriteLine($"{dateText} {_exercise}({_minutes} min)- Distance:{distanceFinal} km, Speed:{speedFinal} kph, Pace:{paceFinal} min per km.");
    }

   

   


}