using System;

class CreateNewGoals
{
    public static void Run(GoalTracker goalTracker)
    {
        Console.WriteLine("Create New Goals");

        Console.WriteLine("Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter goal type: ");
        string goalTypeChoice = Console.ReadLine();

        Goal goal;
        switch (goalTypeChoice)
        {
            case "1":
                goal = CreateSimpleGoal();
                break;
            case "2":
                goal = CreateEternalGoal();
                break;
            case "3":
                goal = CreateNewChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal creation canceled.");
                return;
        }

        goalTracker.AddGoal(goal);
        Console.WriteLine("Goal created successfully.");
    }

    private static SimpleGoal CreateSimpleGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter base points: ");
        int basePoints = Convert.ToInt32(Console.ReadLine());

        return new SimpleGoal(name, description, basePoints);
    }

    private static EternalGoal CreateEternalGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter base points: ");
        int basePoints = Convert.ToInt32(Console.ReadLine());

        return new EternalGoal(name, description, basePoints);
    }

    private static Goal CreateNewChecklistGoal()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the base points: ");
        int basePoints = int.Parse(Console.ReadLine());

        Console.Write("Enter the target count: ");
        int targetCount = int.Parse(Console.ReadLine());

        Console.Write("Enter the bonus points: ");
        int bonusPoints = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, basePoints, 0, bonusPoints, targetCount);
    }

}
