using System.Collections.Generic;

public class GoalTracker
{
    private List<Goal> goals;
    private int score;

    public GoalTracker()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RemoveGoal(Goal goal)
    {
        goals.Remove(goal);
    }

    public Goal[] GetGoals()
    {
        return goals.ToArray();
    }

    public int GoalsCount()
    {
        return goals.Count;
    }

    public Goal GetGoal(int index)
    {
        if (index >= 0 && index < goals.Count)
            return goals[index];

        return null;
    }

    public void UpdateScore(int points)
    {
        score += points;
    }

    public int GetScore()
    {
        return score;
    }

    public void ClearGoals()
    {
        goals.Clear();
    }

    public void SetScore(int newScore)
    {
        score = newScore;
    }
}
