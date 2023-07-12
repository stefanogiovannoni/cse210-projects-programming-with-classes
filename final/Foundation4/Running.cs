using System;
using System.Collections.Generic;
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance)
        : base(date, length, distance)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance} kilometers, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}