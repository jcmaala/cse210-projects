using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        string name_fin = PromptUserName(name);
        Console.Write("Please enter your favorite number: ");
        string favenum = Console.ReadLine();
        int user_num = int.Parse(favenum);
        int num_fin = PromptUserNumber(user_num);
        int square = SquareNumber(num_fin);
        
        DisplayResult(name_fin, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(string name)
    {
       string name_fin =  name;
       return name_fin;
    }

    static int PromptUserNumber(int user_num)
    {
       int user_num_fin = user_num;
       return user_num_fin;
    }

    static int SquareNumber (int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

}