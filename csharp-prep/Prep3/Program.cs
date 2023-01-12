using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to 'Guess my Number' game! ");
        Console.WriteLine();
        Random randomGenerator = new Random();
        int magic_num_fin = randomGenerator.Next(1, 100);

        bool loop = true;
        int counter = 0;
        while (loop == true)
        {
            Console.Write("What is your guess? ");
            string guess_num = Console.ReadLine();
            int guess_num_fin = int.Parse(guess_num);
        
            if (guess_num_fin > magic_num_fin)
            {
                Console.WriteLine("Lower");
                counter ++;
                loop = true;
            }
            else if (guess_num_fin < magic_num_fin)
            {
                Console.WriteLine("Higher");
                counter ++;
                loop = true;
            }
            else if (guess_num_fin == magic_num_fin)
            {
                Console.WriteLine("You guessed it!");
                counter ++;
                loop = false;

                Console.WriteLine($"You guessed the number {counter} times.");
                Console.WriteLine();
                Console.Write("Would you like to play again? Y/N: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "Y")
                {
                    loop = true;
                    magic_num_fin = randomGenerator.Next(1, 100);
                }
                else if (choice == "N")
                {
                    Console.WriteLine("Thank you for playin the game!");
                    loop = false;
                }
            }
        }
        
        
        
    }
}