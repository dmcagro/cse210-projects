using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected DateTime GetDate()
    {
        return _date;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods (must be overridden)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Common summary method
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace {GetPace():0.0}";
    }
}