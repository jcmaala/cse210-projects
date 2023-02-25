using System;

class Program
{
    static void Main(string[] args)
    {
        bool statement = true;
        string userTime = "";
        int _userTimeFin = 0;
        Random randomGenerator = new Random();
        int questionItem = randomGenerator.Next(0,4);
        

        while (statement == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();
                BreathingActivity breathAct = new BreathingActivity();
                Console.WriteLine(breathAct.getBreathingActIntro());
                Console.WriteLine();
                Activity _session = new Activity();
                Console.WriteLine(_session.getSessionMessage());
                userTime = Console.ReadLine();
                _userTimeFin = int.Parse(userTime);
                BreathingActivity breathTime = new BreathingActivity(_userTimeFin);

                string breathIn = "Breath in....";
                string breathOut = "Breath out....";
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(_userTimeFin);

                
                Console.Clear();
                Activity op = new Activity();
                Console.WriteLine(op.getOpening());

                for (int i = 1; i<=3; i++)
                {
                    Console.Write("-");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write(@"\");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("|");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("/");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                }

                Console.WriteLine();
                while (startTime < futureTime)
                {
                    Console.WriteLine();
                    Console.Write($"{breathIn}");

                    for (int i = 5; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b");
                    }

                    Console.WriteLine();
                    Console.Write($"{breathOut}");

                    for (int i= 5; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b");   
                    }
                    Console.WriteLine();

                    // Console.WriteLine();
                    // Console.Write($"{breathIn}");
                    // Console.Write("5");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("4");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("3");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("2");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("1");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // //Thread.Sleep(div);
                    // Console.WriteLine();
                    // Console.Write($"{breathOut}");
                    // //Thread.Sleep(div);
                    // Console.Write("5");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("4");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("3");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("2");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.Write("1");
                    // Thread.Sleep(1000);
                    // Console.Write("\b");
                    // Console.WriteLine();

                    startTime = DateTime.Now;
                }

                Console.WriteLine();
                Console.WriteLine("Well done!");

                for (int i = 1; i<=3; i++)
                {
                    Console.Write("-");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write(@"\");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("|");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("/");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"You have completed another {_userTimeFin} seconds of the Breathing Activity");

                 for (int i = 1; i<=3; i++)
                {
                    Console.Write("-");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write(@"\");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("|");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("/");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                }

                Console.Clear();
                
            }

            else if (answer == "2")
            {
                Console.Clear();
                ReflectingActivity reflectAct = new ReflectingActivity();
                Console.WriteLine(reflectAct.getReflectingActIntro());
                Console.WriteLine();
                Activity _session = new Activity();
                Console.WriteLine(_session.getSessionMessage());
                userTime = Console.ReadLine();
                _userTimeFin = int.Parse(userTime);

                Console.Clear();
                Activity op = new Activity();
                Console.WriteLine(op.getOpening());

                   for (int i = 1; i<=3; i++)
                {
                    Console.Write("-");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write(@"\");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("|");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                    Console.Write("/");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                }

                string [] _questionList = {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
                string que = _questionList[questionItem];
                Console.WriteLine();
                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine();
                Console.WriteLine($"--- {que} ---");
                
            }

            else if (answer == "3")
            {
                Console.Clear();
                ListingActivity listAct = new ListingActivity();
                Console.WriteLine(listAct.getListingActIntro());
                Console.WriteLine();
                Activity _session = new Activity();
                Console.WriteLine(_session.getSessionMessage());
                userTime = Console.ReadLine();
                _userTimeFin = int.Parse(userTime);

                
                
            }
            else if (answer == "4")
            {
                statement = false;
            }
            else
            {
                Console.WriteLine("Sorry, your answer is invalid. Please try again and choose between 1-4.");
                statement = false;
            }
        }
    }
}