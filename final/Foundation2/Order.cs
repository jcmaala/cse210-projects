public class Order
{
    public List<Product> _prodList = new List<Product>();
    public List<double> _totalprice = new List<double>();

    

   
    public void DisplayOrder()
    {
        foreach (Product prod in _prodList)
        {
            prod.DisplayOrderFormat();
        }
    }
}