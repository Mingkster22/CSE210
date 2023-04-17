using System;
/* primitive */
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2025;
        Console.WriteLine("Hello Learning02 World!");

        Job job2 = new Job();
        job2._company = "adobe";
        job2._jobTitle = "web developer";
        job2._startYear = 2026;
        job2._endYear = 2027;

        Resume resume1 = new Resume();
        resume1._name = "Minkee";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}