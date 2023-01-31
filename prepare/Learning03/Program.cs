using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fract1 = new Fractions();
        Fractions fract2 = new Fractions(5);
        Fractions fract3 = new Fractions(3, 4);
        Fractions fract4 = new Fractions(1, 3);
        
        fract1.GetFractionString();
        Console.WriteLine(fract1.GetDecimalValue());
        fract2.GetFractionString();
        Console.WriteLine(fract2.GetDecimalValue());
        fract3.GetFractionString();
        Console.WriteLine(fract3.GetDecimalValue());
        fract4.GetFractionString();
        Console.WriteLine(fract4.GetDecimalValue());
    }
}