using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Reference myReference = new Reference();
        string randomItem = myReference.GetRandomItem();

        List<string> scriptureList = myReference.GetScripture(randomItem);
        string scripture = string.Join(" ", scriptureList);

        Console.WriteLine(randomItem + " " + scripture);
        int number = 1;
        bool shouldContinue = true;
        while (shouldContinue && ContainWords.ContainsWordsToBlank(scripture))
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to quit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                shouldContinue = false;
            }
            else
            {
                Blank blankProcessor = new Blank();
                scripture = blankProcessor.ProcessScripture(randomItem, scripture, number);
                number = 2;
                string modifiedScripture = randomItem + " " + scripture;
                Console.WriteLine(modifiedScripture);

                if (!ContainWords.ContainsWordsToBlank(scripture))
                {
                    Console.WriteLine("All words have been blanked out. Program ending.");
                    shouldContinue = false;
                }
            }
        }
    }
}
