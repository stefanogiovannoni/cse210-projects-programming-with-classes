public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather, string type)
        : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {_weather}";
    }
}
