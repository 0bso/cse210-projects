using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Amazon";
        job1._startYear = 2005;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2010;
        job2._endYear = 2017;

        Resume resume1 = new Resume();
        resume1._name = "Taylor Kirk";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}