public class Square: Shape
{
    private double _side  = 0;

    public Square(string color, double side)
    {
        _color = color;
        _side = side;
    }

    public override double GetArea()
    {
        return _side * 4;
    }
}