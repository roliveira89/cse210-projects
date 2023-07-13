public class Cycling : Activity
{
    private float _speed; // km/h

    public Cycling(DateTime date, int lengthInMinutes, float speed)
        : base(date, lengthInMinutes)
    {
        this._speed = speed;
    }

    public override float GetSpeed()
    {
        return _speed; // km/h
    }

    public override float GetDistance()
    {
        return (_speed * base._lengthInMinutes) / 60f; // km
    }

    public override float GetPace()
    {
        return 60f / _speed; // min/km
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({base._lengthInMinutes} min): " +
            $"Distance: {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(_speed, 2)} km/h, Pace: {Math.Round(GetPace(), 2)} min/km";
    }
}