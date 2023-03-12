using System;

class Program
{
    static void Main(string[] args)
    {
        bool statement = true;

        Goals goal = new Goals();
        ListGoal listgoal = new ListGoal();
        RecordEvent recordedGoal = new RecordEvent();

        while (statement == true)
        {
            Console.WriteLine($"You have {goal._goalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            goal = new Goals();

            if (choice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();

                if (goalChoice == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDesc = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string amount = Console.ReadLine();
                    int amount_fin = int.Parse(amount);
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDesc);
                    listgoal._goals.Add(simpleGoal);
                    Console.WriteLine();
                    

                }
                
                else if (goalChoice == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string goalDesc = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string amount = Console.ReadLine();
                    int amount_fin = int.Parse(amount);
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDesc);
                    listgoal._goals.Add(eternalGoal);
                    Console.WriteLine();
                }

                else if (goalChoice == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string goalDesc = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string amount = Console.ReadLine();
                    int amount_fin = int.Parse(amount);
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string bonusTimes = Console.ReadLine();
                    int bonusTimes_fin = int.Parse(bonusTimes);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonusPoints = Console.ReadLine();
                    int bonusPoints_fin = int.Parse(bonusPoints);
                    Console.WriteLine();
                    ChecklistGoal checklistgoal = new ChecklistGoal(goalName, goalDesc, bonusTimes_fin);
                    listgoal._goals.Add(checklistgoal);
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("The Goals are:");
                listgoal.displayGoals();
                Console.WriteLine();
                listgoal._listCounter = 0;

            }

            else if (choice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                ListGoal file_name = new ListGoal();
                file_name._fileName = file;
                file_name.saveGoals();
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string file = Console.ReadLine();
            }

            else if (choice == "5")
            {
                Console.WriteLine("The Goals are:");
                listgoal.displayRecGoals();
                Console.Write("Which goal did you accomplish? ");
                string accomplish_choice = Console.ReadLine();
                listgoal._listCounter = 0;

            }

            else if (choice == "6")
            {
                statement = false;
            }

            else
            {
                Console.WriteLine("Invalid input. Please select from the choices of numbers above and try again.");
                Console.WriteLine();
            }
        }
    }
}