public class Swimming : Activity
{
    private double _swimmingLaps = 0;

    public Swimming(string exercise, double swimmingLaps, double minutes) :base(exercise, swimmingLaps, minutes)
    {
        _swimmingLaps = swimmingLaps;
        _minutes = minutes;
    }

    public override double _distanceFinal()
    {
        double formula = _swimmingLaps * 50;
        double formula_fin = formula / 1000;
        return formula_fin;
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
