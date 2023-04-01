public class Lectures : Event
{
    private string _speakerName = "";
    private string _capacity = "";

    public Lectures(string eventTitle, string description, string date, string time, string address, string speakerName, string capacity) : base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void getLectureDetails()
    {
        Console.WriteLine($"Guest speaker: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

}