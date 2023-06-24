public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int basePoints) : base(name, description, basePoints)
    {
    }

    public override void CompleteGoal()
    {
        if (!completed)
        {
            points = basePoints;
        }
    }

    public override string ToString()
    {
        return $"[ ] - Eternal: {name}, {description}, Points: {basePoints}";
    }
}
