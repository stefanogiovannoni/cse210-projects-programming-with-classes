using System;
using System.Collections.Generic;
public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed, double distance)
        : base(date, length, distance)
    {
        _speed = speed;
    }
    
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} kph, Pace: {GetPace():F1} min per km";
    }
}
