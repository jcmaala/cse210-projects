public class Outdoor : Event
{
    private string _weatherStatement = "";


    public Outdoor(string eventTitle, string description, string date, string time, string address, string weatherStatement) : base(eventTitle, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public void getOutdoorDetails()
    {
        Console.WriteLine($"Weather: {_weatherStatement}");
    }
}