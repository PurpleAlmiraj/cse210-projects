using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class ReflectionActivity : Activity
{
    Animation animation = new Animation();
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    protected override void StartActivity(int duration)
    {
        Animation animation = new Animation();

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        int questionsCount = questions.Count;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        string prompt = prompts[promptIndex];
        promptIndex = (promptIndex + 1) % prompts.Length;

        Console.Write(prompt + " ");
        animation.Animationspin(5, 200);
        while (DateTime.Now < endTime)
        {

            DateTime questionEndTime = DateTime.Now.AddSeconds(5);

            while (DateTime.Now < questionEndTime && DateTime.Now < endTime)
            {
                Console.WriteLine();
                string question = questions[random.Next(questionsCount)];
                Console.Write(question + " ");
                animation.Animationspin(5, 200);
            }
        }


    Console.WriteLine();
    animation.Animationspin(4, 150);
    Console.WriteLine();

    }
}
