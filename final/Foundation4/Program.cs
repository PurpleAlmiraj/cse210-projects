using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Swimming");
        Console.WriteLine("Which activity would you like? ");
        string activityChoice = Console.ReadLine();
        

        Activity activity;

        if (activityChoice == "1")
        {
            activity = new RunningActivity();
            activity.Exercise = "Running";  
        }
        else if (activityChoice == "2")
        {
            activity = new CyclingActivity();
            activity.Exercise = "Cycling"; 
        }
        else if (activityChoice == "3")
        {
            activity = new SwimmingActivity();
            activity.Exercise = "Swimming"; 
        }
        else
        {
            Console.WriteLine("Invalid activity choice.");
            return;
        }

        activity.CollectActivityDetails();
        activity.DisplayEventDetails();
    }
}
