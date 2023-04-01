public class Product
{
    private string _prodID = "";
    private string _prodName = "";
    private double _prodPrice = 0;

    private double _totalPrice = 0;
    private int _quantity = 0;
    
 
    

    public Product()
    {
    }

    public Product(string prodID, string prodName, double prodPrice, int quantity)
    {
        _prodID = prodID;
        _prodName = prodName;
        _prodPrice = prodPrice;
        _quantity = quantity;
    }

    public Product(double price)
    {
        _totalPrice = price;
    }

    public void DisplayOrderFormat()
    {
        {
        Console.WriteLine($"{_prodID} {_prodName} - ${_prodPrice} ({_quantity})");
        }
    }

}