public class Reception : Event
{
    private string _email = "";

    public Reception(string eventTitle, string description, string date, string time, string address, string email) : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public void getReceptionDetails()
    {
        Console.WriteLine("Please let us know if you can attend by sending a message through this email:");
        Console.WriteLine($"{_email}");
    }
}