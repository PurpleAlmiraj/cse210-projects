using System;

class Lecture : Event
{
    public string SpeakerName { get; set; }
    public int Capacity { get; set; }


    public void DisplayLectureDetails()
    {
        DisplayEventDetails();
        Console.WriteLine("");
        DisplayFullDetails();
        Console.WriteLine($"Speaker: {SpeakerName}");
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine("");
        DisplayShortDetails();
    }
}
