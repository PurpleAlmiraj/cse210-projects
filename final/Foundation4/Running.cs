using System;

class RunningActivity : Activity
{
    public override void CollectActivityDetails()
    {
        base.CollectActivityDetails();

        Console.WriteLine("Enter distance (in miles): ");
        Distance = Convert.ToInt32(Console.ReadLine());

        Speed = ((double)Distance / (double)Time) * 60;
        Pace = (double)Time / (double)Distance;
    }
}
