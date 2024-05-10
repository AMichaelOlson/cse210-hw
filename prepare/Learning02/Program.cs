using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Discord";
        job1._startYear = 2028;
        job1._endYear = 2033;

        Job job2 = new Job();
        job2._jobTitle = "Backend Web Dev";
        job2._company = "Roll20";
        job2._startYear = 2033;
        job2._endYear = 2037;

        Resume myResume = new Resume();
        myResume._name = "Anthony Olson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}