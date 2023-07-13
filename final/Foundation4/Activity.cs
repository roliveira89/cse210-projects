using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime _date;
    protected int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this._date = date;
        this._lengthInMinutes = lengthInMinutes;
    }

    // Methods return 0, but derived classes will override them
    public virtual float GetDistance()
    {
        return 0f;
    }

    public virtual float GetSpeed()
    {
        return 0f;
    }

    public virtual float GetPace()
    {
        return 0f;
    }

    // Derived classes override this method to include details of each activity
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")}";
    }
}