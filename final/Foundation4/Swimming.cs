using System;
using System.Collections.Generic;
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps, double distance)
        : base(date, length, distance)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / _length) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return _length / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Laps: {_laps}, Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}