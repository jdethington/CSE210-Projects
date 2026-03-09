using System;

public class Resume
{
    // Responsibilities: Keeps track of...
    // Person's Name
    public string _name = "Name";
    // list of their jobs
    public List<Job> _jobs = new List<Job>();
    // Behaviors: 
    // Displays the resume, which shows the name first, followed by displaying each one of the jobs.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}