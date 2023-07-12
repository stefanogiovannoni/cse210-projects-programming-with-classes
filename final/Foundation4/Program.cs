using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = new DateTime(2023, 12, 7);
        int length = 45;

        double distance = 8.9;
        activities.Add(new Running(date, length, distance));

        int speed = 40;
        double swimmingDistance = 7.3;
        activities.Add(new Cycling(date, length, speed, swimmingDistance));

        int laps = 25;
        activities.Add(new Swimming(date, length, laps, distance));

       
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            
        }
    }
}