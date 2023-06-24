using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("You have {0} points.", goalTracker.GetScore());
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoals.Run(goalTracker);
                    break;
                case "2":
                    ListGoals.Run(goalTracker);
                    break;
                case "3":
                    SaveGoals.Run(goalTracker);
                    break;
                case "4":
                    LoadGoals.Run(goalTracker);
                    break;
                case "5":
                    RecordEvent.Run(goalTracker);
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
