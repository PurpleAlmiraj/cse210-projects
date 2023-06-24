using System;
using System.IO;

class SaveGoals
{
    public static void Run(GoalTracker goalTracker)
    {
        Console.WriteLine("Save Goals");

        Console.Write("Enter the file name to save goals to: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                
                writer.WriteLine($"Total Points: {goalTracker.GetScore()}");

                
                foreach (Goal goal in goalTracker.GetGoals())
                {
                    string goalType = goal.GetType().Name;
                    string name = goal.GetName();
                    string description = goal.GetDescription();
                    int points = goal.GetBasePoints();
                    bool completed = goal.IsCompleted();

                    if (goalType == "SimpleGoal")
                    {
                        writer.WriteLine($"{goalType}, {name}, {description}, {points}, {completed}");
                    }
                    else if (goalType == "EternalGoal")
                    {
                        writer.WriteLine($"{goalType}, {name}, {description}, {points}, {completed}");
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int currentAmount = ((ChecklistGoal)goal).GetCurrentAmount();
                        int totalAmount = ((ChecklistGoal)goal).GetTotalAmount();
                        int bonusPoints = ((ChecklistGoal)goal).GetBonusPoints();

                        writer.WriteLine($"{goalType}, {name}, {description}, {points}, {completed}, {currentAmount}, {totalAmount}, {bonusPoints}");
                    }
                }

                Console.WriteLine("Goals saved successfully.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving goals: {e.Message}");
        }
    }
}
