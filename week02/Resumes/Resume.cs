// Keeps track of the person's name and a list of their jobs.
public class Resume
{
    // Displays the resume, which shows the name first, followed by displaying each one of the jobs.
    public string Name { get; set; }

    public List<Job> Jobs { get; set; } = new List<Job>();

    public void ResumeDisplay()
    {
        Console.WriteLine($"Resume of: {Name}");
        foreach (Job job in Jobs)
        {
            Console.WriteLine($"- {job.JobTitle} at {job.Company}, from {job.StartYear} to {job.EndYear}.");
        }

    }
}