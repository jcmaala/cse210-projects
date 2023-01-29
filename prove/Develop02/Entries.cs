public class Entries
{
    
    public List<Write> _entries = new List<Write>();
    
    public string _fileName = "";

    public Entries()
    {
    }
    
    public void DisplayEntries()
    {
        foreach (Write entry in _entries)
        {
            entry.DisplayEntryFormat();
        }
    }

    public void SaveEntries()
    {   
        using (StreamWriter output = new StreamWriter(_fileName))
        {
            output.WriteLine(_entries);
        }
    }


    
}