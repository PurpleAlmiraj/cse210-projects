using System;

class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Address { get; set; }
    public string Events { get; set; }

    public void DisplayEventDetails()
    {

        Console.WriteLine("Standard Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
        Console.WriteLine($"Time: {Time.ToString(@"hh\:mm")}");
        Console.WriteLine($"Address: {Address}");
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
        Console.WriteLine($"Time: {Time.ToString(@"hh\:mm")}");
        Console.WriteLine($"Address: {Address}");
    }
    public void DisplayShortDetails()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine($"Title: {Events}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
        Console.WriteLine("-=-----------------------------------------------------------------------------");
    }
}
