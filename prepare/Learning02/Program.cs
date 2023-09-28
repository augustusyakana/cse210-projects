using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2012;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2024;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "John Doe";
        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);
        resume.DisplayResumeDetails();


    }
}