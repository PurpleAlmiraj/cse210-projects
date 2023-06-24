public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int basePoints) : base(name, description, basePoints)
    {
    }

    public override void CompleteGoal()
    {
        if (!completed)
        {
            completed = true;
            points = basePoints;
        }
    }
    public override string ToString()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} - Simple: {name}, {description}, Points: {basePoints}";
    }
}


