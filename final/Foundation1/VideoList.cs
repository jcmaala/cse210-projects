public class VideoList
{
    public List<Video> _videoList = new List<Video>();
    public List<Comments> _commentsList = new List<Comments>();

    public void Display()
    {
        foreach (Video vid in _videoList)
        {
            Console.WriteLine();
            vid.DisplayVideoFormat();
            Console.WriteLine("Comments:");
            
            foreach (Comments comment in _commentsList)
            {
                comment.DisplayCommentFormat();
            }
        }
    }
}