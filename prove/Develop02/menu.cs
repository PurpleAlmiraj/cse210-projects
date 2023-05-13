using System;
public class Show
{

    public int Display()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        return userInput;
    }
}