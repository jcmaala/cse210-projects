using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_num = Console.ReadLine();
        int grade_num_fin = int.Parse(grade_num);

        string letter = "";

        if (grade_num_fin >= 90)
        {
            letter = "A";
        }
        else if (grade_num_fin >= 80)
        {
            letter = "B";
        }
        else if (grade_num_fin >= 70)
        {
            letter = "C";
        }
        else if (grade_num_fin >= 60)
        {
            letter = "D";
        }
        else if (grade_num_fin < 60)
        {
            letter = "F";
        }
        
        Console.WriteLine();
        Console.WriteLine($"Your letter grade is {letter}.");

        if (grade_num_fin >= 70)
        {
            Console.WriteLine("Congratulations! You passed the subject!");
        }
        else
        {
            Console.WriteLine("It's okay. You can try again next time.");
        }

    }
}