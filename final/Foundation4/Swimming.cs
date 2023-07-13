public class Swimming : Activity
{
    private int _laps; // Assuming 1 lap = 50 m

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this._laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50f / 1000f; // km
    }

    public override float GetSpeed()
    {
        return (GetDistance() / base._lengthInMinutes) * 60f; // km/h
    }

    public override float GetPace()
    {
        return base._lengthInMinutes / GetDistance(); // min/km
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({base._lengthInMinutes} min): " +
            $"Distance {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} km/h, Pace: {Math.Round(GetPace(), 2)} min/km";
    }
}