class BreathingActivity : Activity
{
    protected override void StartActivity(int duration)
    {

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathing in... ");
            CountdownAnimation(3, 1000);
            Console.Write("Breathing out... ");
            CountdownAnimation(3, 1000);
        }

    }

    private void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}
