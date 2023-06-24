public class ChecklistGoal : Goal
{
    private int currentAmount;
    private int bonusPoints;
    private int totalAmount;

    public ChecklistGoal(string name, string description, int basePoints, int currentAmount, int bonusPoints, int totalAmount)
        : base(name, description, basePoints)
    {
        this.currentAmount = currentAmount;
        this.bonusPoints = bonusPoints;
        this.totalAmount = totalAmount;
    }

    public int GetCurrentAmount()
    {
        return currentAmount;
    }

    public int GetBonusPoints()
    {
        return bonusPoints;
    }

    public int GetTotalAmount()
    {
        return totalAmount;
    }

    public void SetCurrentAmount(int amount)
    {
        currentAmount = amount;
    }

    public void SetBonusPoints(int points)
    {
        bonusPoints = points;
    }

    public void IncrementCurrentAmount()
    {
        currentAmount++;
    }

    public override void CompleteGoal()
    {
        IncrementCurrentAmount();
        if (!completed && currentAmount >= totalAmount)
        {
            points = basePoints + bonusPoints;
            completed = true;
        }
        else if (!completed)
        {
            points = basePoints;
        }
    }


    public override string ToString()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} {name} - {description} (Current: {currentAmount}/{totalAmount}, Base Points: {basePoints}, Bonus Points: {bonusPoints})";
    }
}
