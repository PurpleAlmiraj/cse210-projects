using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Astronaut";
        job1._company = "NASA";
        job1._startYear = 1995;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Chef";
        job2._company = "AppleBees";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Joe Biddy";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
