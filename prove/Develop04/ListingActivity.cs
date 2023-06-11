using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void StartActivity(int duration)
    {

        Animation animation = new Animation();

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        string prompt = prompts[promptIndex];

        Console.Write("Prompt: " + prompt + " ");
        animation.Animationspin(5, 200);

        List<string> answers = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string answer = Console.ReadLine();
            answers.Add(answer);
        }

        Console.Write("You entered {0} responses." + " ", answers.Count);
        animation.Animationspin(5, 200);
    }
}
