public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _startingMessage1 = "Welcome to Listing Activity";
        _startingMessage2 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public string getListingActIntro()
    {
        return $"{_startingMessage1} \n\n{_startingMessage2}";
    }

    
}