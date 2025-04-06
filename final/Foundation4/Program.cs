using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; private set; }
    public int Duration { get; private set; } // in minutes

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Duration} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}

public class Running : Activity
{
    public double Distance { get; private set; } // in kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }
}

public class Cycling : Activity
{
    public double Speed { get; private set; } // in kilometers per hour

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * Duration) / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}

public class Swimming : Activity
{
    public int Laps { get; private set; }

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 45, 20),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}