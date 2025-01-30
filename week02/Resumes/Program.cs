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
        job1.Display();

        Job job2 = new Job();
        job2.Company = "Kellogg";
        job2.JobTitle = "Eating Consultant";
        job2.StartYear = 1998;
        job2.EndYear = 2000;
        job2.Display();

        Resume myResume = new Resume();
        myResume.Name = "Vincent";

        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.ResumeDisplay();
    }
}