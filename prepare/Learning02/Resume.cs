using System;
using System.Collections.Generic;

public class Resume
{
    public string _fullName;

    // Initialize the list of jobs
    public List<Job> _jobHistory = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Full Name: {_fullName}");
        Console.WriteLine("Job History:");

        // Iterate through the list of jobs and display each one
        foreach (Job job in _jobHistory)
        {
            job.Display();
        }
    }
}