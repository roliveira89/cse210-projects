public class Running : Activity
{
    private float _distance; // km

    public Running(DateTime date, int lengthInMinutes, float distance)
        : base(date, lengthInMinutes)
    {
        this._distance = distance;
    }

    public override float GetDistance()
    {
        return _distance; // km
    }

    public override float GetSpeed()
    {
        return (_distance / base._lengthInMinutes) * 60f; // k/h
    }

    public override float GetPace()
    {
        return base._lengthInMinutes / _distance; // min/km
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({base._lengthInMinutes} min): " +
            $"Distance: {Math.Round(_distance, 2)} km, Speed: {Math.Round(GetSpeed(), 2)} km/h, Pace: {Math.Round(GetPace(), 2)} min/km";
    }
}