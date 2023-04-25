using System;

class Program
{
    static void Main(string[] args)
    {

        int guess = 0;
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 100);
        while (guess != magicnumber)
        {
            Console.Write("What do you guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.Write("Higher ");
            }
            if (magicnumber < guess)
            {
                Console.Write("Lower ");
            }
            if (magicnumber == guess)
            {
                Console.Write($"You Got it its {magicnumber}");
            }

        }

    }
}