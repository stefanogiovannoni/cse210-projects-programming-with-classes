using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "IT Support Specialist";
        job1._company = "JP Morgan";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job1._jobTitle = "Chairman and CEO";
        job1._company = "BlackRock";
        job1._startYear = 2023;
        job1._endYear = 2024;
    
        Resume _resume = new Resume();
        _resume._name = "Stefano Giovanoni";

        _resume._jobs.Add(job1);
        _resume._jobs.Add(job2);
        
        
        

        _resume.DisplayJobDetails();
    }
}