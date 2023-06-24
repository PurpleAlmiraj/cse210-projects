public abstract class Goal
{
    protected string name;
    protected string description;
    protected int basePoints;
    protected int points; 
    protected bool completed;

    public Goal(string name, string description, int basePoints)
    {
        this.name = name;
        this.description = description;
        this.basePoints = basePoints;
        points = 0; 
        completed = false;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetBasePoints()
    {
        return basePoints;
    }

    public int GetPoints()
    {
        return points;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public void SetCompleted(bool value)
    {
        completed = value;
    }

    public virtual void CompleteGoal()
    {
        if (!completed)
        {
            points = basePoints;
            completed = true;
        }
    }

    public override string ToString()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} {name} - {description} (Points: {basePoints})";
    }
}
