public class Write
{
    static DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    public string _questionFinal = "";
    public string _answer = "";
    

    public Write()
    {
    }

    public void DisplayEntryFormat()
    {
        Console.WriteLine($"Date: {dateText} - Prompt: {_questionFinal}");
        Console.WriteLine($"{_answer}");
        Console.WriteLine();
    }

    
    

}