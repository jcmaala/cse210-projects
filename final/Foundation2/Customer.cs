public class Customer
{
    private string _customerName = "";

    public Customer(string customerName)
    {
        _customerName = customerName;
    }


    public void getCustomerName()
    {
        Console.WriteLine($"{_customerName}");
    }


}