public class Event
{
    private string _eventTitle = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private string _address = "";

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void getStandardDetails()
    {
        Console.WriteLine($"{_eventTitle} {_date} | {_time} at {_address} ");
        Console.WriteLine(_description);
    }

     public void getLectureShort()
    {
        Console.WriteLine("Lecture Event");
        Console.WriteLine($"{_eventTitle} on {_date}");
    }

    public void getReceptionShort()
    {
        Console.WriteLine("Reception Event");
        Console.WriteLine($"{_eventTitle} on {_date}");
    }

    public void getOutdoorShort()
    {
        Console.WriteLine("Outdoor Event");
        Console.WriteLine($"{_eventTitle} on {_date}");
    }

}