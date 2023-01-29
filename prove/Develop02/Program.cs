using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int question_num = randomGenerator.Next(0, 5);
        bool statement = true;
        Console.WriteLine("Welcome to the Journal Program!");

        Write write1 = new Write();
        Entries entry = new Entries();
        Entries save = new Entries();

        while (statement == true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            write1 = new Write();

            if (choice == "1")
            {
                string [] question = {"Who was the most interesting person I interacted with today?",
                "What was the best part of my day?","How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"};
                //add more questions

                string randomQuestion = question[question_num];
                write1._questionFinal = randomQuestion;
                Console.WriteLine($"> {randomQuestion}");
                string answer = Console.ReadLine();
                write1._answer = answer;
                entry._entries.Add(write1);
                
                question_num = randomGenerator.Next(0, 5);
                
            }
            if (choice == "2")
            {
                entry.DisplayEntries();
            }

            if (choice == "4")
            {
                Console.WriteLine("Enter the name of the file:");
                string fname = Console.ReadLine();
                save._fileName = fname;
                save.SaveEntries();                
            }

            if (choice == "5"){
                statement = false;
            }
        
        }
    }
}