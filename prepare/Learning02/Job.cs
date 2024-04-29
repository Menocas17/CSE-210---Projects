using System.Runtime.InteropServices;

public class Job
{
    public string _company;
    public string _jobTitle;
    public string _starYear;
    public string _endYear;

    public void DisplayJobDetails ()
    {
        string jobDetails = ($"{_jobTitle} ({_company}) {_starYear}-{_endYear}");

        Console.WriteLine (jobDetails);
    }

}