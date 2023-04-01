public class Address
{
    private string _streetAdd = "";
    private string _city = "";
    private string _stateProvince = "";
    private string _country = "";

    public Address(string streetAdd, string city, string stateProvince, string country)
    {
        _streetAdd = streetAdd;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public void getAddress()
    {
         Console.WriteLine($"{_streetAdd}, {_city}, {_stateProvince}, {_country}");
    }
}