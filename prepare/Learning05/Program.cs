using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("green", 2);
        Rectangle rec = new Rectangle("blue", 5, 3);
        Circle cir = new Circle("red", 4);
        

        List<Shape> shape = new List<Shape>();
        shape.Add(sq);
        shape.Add(rec);
        shape.Add(cir);

        foreach (Shape sh in shape)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The color of the shape is {color}.");
            Console.WriteLine($"The area of the shape is {area}.");
            Console.WriteLine();
        }

    }
}