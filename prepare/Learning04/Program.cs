using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment as1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(as1.GetSummary());
        Console.WriteLine();

        MathAssignment newas = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3" , "Problems 8-19");
        Console.WriteLine(newas.GetSummary());
        Console.WriteLine(newas.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}