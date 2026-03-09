using System;

public class Job
{
    // Responsibilities: Keeps track of...
    // Company
    public string _companyName = "";
    // Job Title
    public string _jobTitle = "";
    // Start Year
    public int _startYear = 1900;
    // End Year
    public int _endYear = 1900;

    // Behaviors: Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}