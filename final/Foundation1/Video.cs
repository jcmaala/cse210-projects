public class Video
{
    public string _title = "";
    public string _author = "";
    public string _length = "";

    public void DisplayVideoFormat()
    {
        Console.WriteLine($"Title: {_title} by: {_author}");
        Console.WriteLine($"Video Length: {_length}");
    }
}