public class Fractions
{
    private int _top = 0;
    private int _bottom = 0;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fractions (int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public int GetTopNum()
    {
        return _top;
    }

    public int GetBottomNum()
    {
        return _bottom;
    }

    public void GetFractionString()
    {
       Console.WriteLine($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {
        double _decimalVal = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return _decimalVal;
    }


}