class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade Percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        if (number >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got a F");
        }
        if (number < 60)
        {
            Console.WriteLine("You didn't pass the class");
        }
        if (number >= 60)
        {
            Console.WriteLine("You passed the class");
        }
    }
}