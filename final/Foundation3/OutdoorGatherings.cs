using System;


class OutdoorGathering : Event
{
  
    public string WeatherStatement { get; set; }

    public void DisplayOutdoorGatheringDetails()
    {
        DisplayEventDetails();
        Console.WriteLine("");

        DisplayFullDetails();
        Console.WriteLine($"Weather Statement: {WeatherStatement}");
        Console.WriteLine("");

        DisplayShortDetails();
    }
}
