using System;

class Reception : Event
{
    public string Email { get; set; }
    public void DisplayReceptionDetails()
    {
        DisplayEventDetails();
        Console.WriteLine("");

        DisplayFullDetails();
        Console.WriteLine($"RSVP Email: {Email}");
        Console.WriteLine("");

        DisplayShortDetails();
    }
}
