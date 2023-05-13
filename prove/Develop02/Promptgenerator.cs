using System;

public class PromptGenerator
{
    int indexcheck = -1;
    private Random rand;
    private string[] prompts;

    public PromptGenerator()
    {
        rand = new Random();
        prompts = new string[]
        {
            "Write about a recent challenge you faced.",
            "Describe a person who has been a positive influence in your life.",
            "What is something you're grateful for?",
            "Write about a place that makes you feel peaceful.",
            "Describe a goal you'd like to accomplish in the near future.",
            "Write about a time when you had to make a difficult decision.",
            "Describe a place that you would love to visit and why.",
            "Write about a moment when you felt truly proud of yourself.",
            "What is a habit that you would like to develop or break? Why?",
            "Describe a challenge that you have overcome in the past. What did you learn from the experience?",
            "How have you seen the Lord's hand today?"
        };
    }

    public string GetRandomPrompt()
    {
        int index = rand.Next(prompts.Length);
        while (index == indexcheck)
        {
            indexcheck = index;
            index = rand.Next(prompts.Length);
        }

        return prompts[index];
    }
}