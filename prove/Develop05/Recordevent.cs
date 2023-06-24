using System;

class RecordEvent
{
    public static void Run(GoalTracker goalTracker)
    {
        Console.WriteLine("Record Event");

        if (goalTracker.GoalsCount() == 0)
        {
            Console.WriteLine("No goals available. Create goals first.");
            return;
        }

        Console.WriteLine("Select a goal to record an event:");

        Goal[] goals = goalTracker.GetGoals();
        for (int i = 0; i < goalTracker.GoalsCount(); i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        Console.Write("Enter goal number: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= goalTracker.GoalsCount())
        {
            Goal selectedGoal = goalTracker.GetGoal(goalNumber - 1);

            if (selectedGoal.IsCompleted())
            {
                Console.WriteLine("This goal has already been completed. Event recording canceled.");
                return;
            }

            selectedGoal.CompleteGoal();
            int pointsEarned = selectedGoal.GetPoints();
            goalTracker.UpdateScore(pointsEarned);

            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number. Event recording canceled.");
        }
    }
}
