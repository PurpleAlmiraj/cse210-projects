using System;

class Program
{
    static void Main(string[] args)
    {
        var lecture = new Lecture
        {
            Title = "Programming 101",
            Description = "Introduction to Programming",
            Date = DateTime.Now.Date,
            Time = new TimeSpan(9, 0, 0),
            Address = "123 Main Street",
            SpeakerName = "Matt Cake",
            Capacity = 100,
            Events = "Lecture"
        };

        var reception = new Reception
        {
            Title = "Company Anniversary",
            Description = "Celebrating 10 years",
            Date = DateTime.Now.Date.AddDays(7),
            Time = new TimeSpan(18, 30, 0),
            Address = "456 Oak Avenue",
            Email = "rsvp@example.com",
            Events = "Reception"
        };
 
        var outdoorGathering = new OutdoorGathering
        {
            Title = "Family Picnic",
            Description = "Fun-filled day with family",
            Date = DateTime.Now.Date.AddDays(14),
            Time = new TimeSpan(11, 0, 0),
            Address = "789 Elm Street",
            WeatherStatement = "Please bring sunscreen and hats.",
            Events = "OutdoorGatherings"
        };

        lecture.DisplayLectureDetails();
        Console.WriteLine();

        reception.DisplayReceptionDetails();
        Console.WriteLine();

        outdoorGathering.DisplayOutdoorGatheringDetails();
    }
}
