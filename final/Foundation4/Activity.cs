using System;

class Activity
{
    private int time;
    private double distance;
    private DateTime date;
    private double speed;
    private double pace;
    private string exercise;

    public int Time
    {
        get { return time; }
        set { time = value; }
    }

    public double Distance
    {
        get { return distance; }
        set { distance = value; }
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public double Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public double Pace
    {
        get { return pace; }
        set { pace = value; }
    }

    public string Exercise
    {
        get { return exercise; }
        set { exercise = value; }
    }

    public virtual void CollectActivityDetails()
    {
        Console.WriteLine("How long did you exercise for? (in minutes)");
        Time = Convert.ToInt32(Console.ReadLine());

        Date = DateTime.Now;
    }

    public void DisplayEventDetails()
    {
        Console.WriteLine("Summary Details:");
        Console.WriteLine($"Date: {Date.ToShortDateString()} {Exercise} ({Time} minutes) - Distance: {Distance:F1} Miles, Speed: {Speed:F1} mph, Pace: {Pace:F1} min per mile");
    }
}
