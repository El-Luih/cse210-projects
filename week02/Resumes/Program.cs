using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Sula";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Leyde";
        job2._jobTitle = "System Administrator";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "Luis Maradiaga";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}