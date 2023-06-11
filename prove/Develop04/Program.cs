class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice;

        do
        {
            menu.Show();
            choice = menu.GetChoice();


            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    StartActivity(breathingActivity);
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    StartActivity(reflectionActivity);
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    StartActivity(listingActivity);
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 4);

        Pause(4000); 
    }

    static void StartActivity(Activity activity)
    {
        Console.Write("Enter duration in seconds: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        activity.Start(duration);
    }

    static void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

}

