using System;

class SwimmingActivity : Activity
{
    public override void CollectActivityDetails()
    {
        base.CollectActivityDetails();
        Console.WriteLine("How many Laps do you do? ");
        int laps = Convert.ToInt32(Console.ReadLine());

        Distance = (50 * laps) / 1609.34;
        Speed = Distance / Time * 60;
        Pace = Time / Distance;
    }
}
