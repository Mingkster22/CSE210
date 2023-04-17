using System;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";

    public int _startYear = 0;
    public int _endYear = 0;

    public void Display()
    {
       Console.WriteLine($"{_company}");
       Console.WriteLine($"{_jobTitle}"); 
       Console.WriteLine($"{_startYear}"); 
       Console.WriteLine($"{_endYear}"); 
    }
}