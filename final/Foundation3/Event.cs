
public abstract class Event

{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    public void SetEvent(string eventType, string eventTitle, string description, string date, string time, string address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address ();
        _address.SetAddress(address);

    }

    public void ListStandardDetails()
    {
        Console.WriteLine("\nStandard Message:");
        Console.WriteLine($"{_eventTitle}\n{_description}\n{_date}\n{_time}\n");
        _address.DisplayAddressParticulars();
    }

    public void ShortDescription()
    {
        Console.WriteLine("\nShort Message:");
        Console.WriteLine ($"{_eventType}\n{_eventTitle}\n{_date}");
    }

    public abstract void FullDetails();
    



}