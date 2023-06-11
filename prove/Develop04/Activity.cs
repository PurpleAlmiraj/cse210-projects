using System;

abstract class Activity
{
    protected string ActivityName { get; private set; }
    protected string Description { get; private set; }

    public void Start(int duration)
    {
        Console.WriteLine("Activity started...");
        Menu menu = new Menu();
        int choice = menu.GetChoice();

        ActivityName = string.Empty;
        Description = string.Empty;

        if (choice == 1)
        {
            ActivityName = "Breathing Activity";
            Description = "This activity will guide you through a relaxing breathing exercise.";
        }
        else if (choice == 2)
        {
            ActivityName = "Reflection Activity";
            Description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        }
        else if (choice == 3)
        {
            ActivityName = "Listing Activity";
            Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        Console.WriteLine($"Welcome to {ActivityName}");
        Console.WriteLine(Description);
        Console.Write("Get ready...");
        Pause(1000);
        Animation animation = new Animation();
        animation.Animationspin(4, 150);
        Console.WriteLine();
        StartActivity(duration);
        Console.Write($"Well done! You have completed the {ActivityName} for {duration} seconds. ");
        animation.Animationspin(4, 150);
        Console.WriteLine();
    }

    protected abstract void StartActivity(int duration);

    protected void Pause(int milliseconds)
    {
        System.Threading.Thread.Sleep(milliseconds);
    }
    
    public void CountdownAnimation(int count, int duration)
    {
        for (int i = count; i >= 1; i--)
        {
            Console.Write(i);
            Pause(duration); 
            Console.Write("\b \b"); 
        }

        Pause(1000); 
        Console.WriteLine();
    }
}
