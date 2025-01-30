// Keeps track of the company, job title, start year, and end year.
public class Job
{
    // Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void Display()
    {
        Console.WriteLine(Company);
        Console.WriteLine(JobTitle);
        Console.WriteLine(StartYear);
        Console.WriteLine(EndYear);
    }
}