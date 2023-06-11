class Menu
{
    private int theChoice;

    public void Show()
    {
        Console.WriteLine("=== Mindfulness App ===");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
    }

    public int GetChoice()
    {
        Console.Write("Enter your choice: ");
        theChoice = Convert.ToInt32(Console.ReadLine());
        return theChoice;
    }

}
