public class Comments
{
    public string _commentersName = "";
    public string _commentText = "";

    public void DisplayCommentFormat()
    {
        Console.WriteLine($"{_commentText} -{_commentersName}");
    }
}