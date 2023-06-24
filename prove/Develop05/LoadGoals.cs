using System;
using System.IO;

class LoadGoals
{
    public static void Run(GoalTracker goalTracker)
    {
        Console.WriteLine("Load Goals");

        Console.Write("Enter the file name to load goals from: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                goalTracker.ClearGoals();
                string line;
                int totalPoints = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Total Points:"))
                    {
                        totalPoints = int.Parse(line.Substring("Total Points:".Length).Trim());
                    }
                    else
                    {
                        string[] goalData = line.Split(',');

                        string goalType = goalData[0].Trim();
                        string name = goalData[1].Trim();
                        string description = goalData[2].Trim();
                        int points = int.Parse(goalData[3].Trim());
                        bool completed = bool.Parse(goalData[4].Trim());

                        if (goalType == "SimpleGoal")
                        {
                            Goal goal = new SimpleGoal(name, description, points);
                            goal.SetCompleted(completed);
                            goalTracker.AddGoal(goal);
                        }
                        else if (goalType == "EternalGoal")
                        {
                            Goal goal = new EternalGoal(name, description, points);
                            goal.SetCompleted(completed);
                            goalTracker.AddGoal(goal);
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            int currentAmount = int.Parse(goalData[5].Trim());
                            int totalAmount = int.Parse(goalData[6].Trim());
                            int bonusPoints = int.Parse(goalData[7].Trim());
                            Goal goal = new ChecklistGoal(name, description, points, currentAmount, bonusPoints, totalAmount);

                            goal.SetCompleted(completed);
                            ((ChecklistGoal)goal).SetCurrentAmount(currentAmount);
                            goalTracker.AddGoal(goal);
                        }
                    }
                }

                goalTracker.SetScore(totalPoints);

                Console.WriteLine("Goals loaded successfully.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading goals: {e.Message}");
        }
    }
}
