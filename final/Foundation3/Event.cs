public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToString()}\nAddress: {_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {_type}\nEvent Title: {_title}\nDate: {_date.ToShortDateString()}";
    }
}