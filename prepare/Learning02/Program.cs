using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Job
        Job job1 = new Job();
        job1._jobTitle = "Data Analyst";
        job1._company = "Google";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._company = "Amazon";
        job2._startYear = 2021;
        job2._endYear = 2024;

        // Create an instance of Resume
        Resume resume = new Resume();
        resume._fullName = "Adam Kelly";
        resume._jobHistory.Add(job1);
        resume._jobHistory.Add(job2);

        // Display the resume
        resume.Display();
    }
}