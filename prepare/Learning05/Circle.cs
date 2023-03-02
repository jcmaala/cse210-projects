public class Circle : Shape
{
    private double _radius = 0;

    public Circle(string color, double radius)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = 3.1416;
        double _radSquared = _radius * _radius;

        return pi * _radSquared;
    }
}