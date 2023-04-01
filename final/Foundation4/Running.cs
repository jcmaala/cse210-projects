public class Running : Activity
{
    public Running(string exercise, double distance, double minutes) :base(exercise, distance, minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public override double _distanceFinal()
    {
        return _distance;
    }

    public override double _speedFinal()
    {
        double formula = (_distance / _minutes) * 60;
        return formula;
    }

    public override double _paceFinal()
    {
        double sp = _speedFinal();
        return 60/sp;
    }
}