using System;

class CyclingActivity : Activity
{
    public override void CollectActivityDetails()
    {
        base.CollectActivityDetails();
        Console.WriteLine("What is your Speed? (in MPH): ");
        Speed = Convert.ToDouble(Console.ReadLine());
        Distance = (int)(Speed * Time) / 60;
        Pace = (double)Time / Distance;
    }
}
