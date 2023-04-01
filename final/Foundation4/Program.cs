using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercises:");
        Running running = new Running("Running", 4.8, 30);
        Cycling cycling = new Cycling("Cycling", 10, 40);
        Swimming swimming = new Swimming("Swimming", 4, 15);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity act in activities)
        {
            act.getSummary();
        }
        
    }
}