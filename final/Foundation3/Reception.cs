public class Reception : Event
{
    private string _registration;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string registration, string type)
        : base(title, description, date, time, address, type)
    {
        _registration = registration;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_registration}";
    }
}