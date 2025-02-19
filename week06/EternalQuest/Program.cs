using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("EternalQuest Program");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    goalManager.ListGoalDetails();
                    break;
                case "4":
                    goalManager.CreateGoal();
                    break;
                case "5":
                    Console.Write("Enter goal name to record event: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    break;
                case "6":
                    goalManager.SaveGoals();
                    break;
                case "7":
                    goalManager.LoadGoals();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}