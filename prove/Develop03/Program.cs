using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int wordSelector = randomGenerator.Next(0, 25);

        Scripture script = new Scripture();
        Console.WriteLine($" {script.getReference()} {script.getScripture()}");

        Console.WriteLine();
        Console.WriteLine("Please enter to continue or type 'quit' to finish.");
        string user = Console.ReadLine();

        
    }
}