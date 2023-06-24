using System;

public class ListGoals
{
    public static void Run(GoalTracker goalTracker)
    {
        Goal[] goals = goalTracker.GetGoals();

        if (goals.Length == 0)
        {
            Console.WriteLine("You have no goals.");
            return;
        }

        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
    }
}
