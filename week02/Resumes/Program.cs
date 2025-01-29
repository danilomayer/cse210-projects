using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.Company = "Google";
        job1.JobTitle = "CEO";
        job1.StartYear = 2001;
        job1.EndYear = 2025;
        Console.WriteLine(job1.Company);

        /* Resume my_resume = new Resume();
        my_resume.Name = "Vincent"; */
    }
}

/* Keeps track of the person's name and a list of their jobs.
public class Resume
{
Displays the resume, which shows the name first, followed by displaying each one of the jobs.

string name;
} */