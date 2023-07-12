using System;
using System.Collections.Generic;
public class Activity
{
    private DateTime _date;
    public int _length;
    private double _distance;

    public Activity(DateTime date, int length, double distance)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_length} min per km)";
    }
}