using System;

class Program
{
    
    static void Main(string[] args)
    {   
        bool statement = true;
        Order ord = new Order();
        while (statement == true)
        {
            
            Console.WriteLine("Welcome to JC Computer Parts!");
            Console.WriteLine("Our Products:");
            Console.WriteLine("Product ID   Product Name        Price");
            Console.WriteLine("1001         PC Motherboard      $50.43");
            Console.WriteLine("1002         PC Processor        $75.00");
            Console.WriteLine("1003         RAM                 $24.99");
            Console.WriteLine("1004         Computer Case       $30.00");
            Console.WriteLine("1005         PC Storage          $20.55");
            Console.WriteLine();
            Console.Write("Please enter the Product ID of the item that you want to order: ");
            string userOrder = Console.ReadLine();


            if (userOrder == "1001")
            {
                Console.Write("Please enter the quantity of the item you want to order: ");
                string userQuant = Console.ReadLine();
                int userQuantFin = Int32.Parse(userQuant);
                Product prod = new Product("1001", "PC Motherboard", 50.43, userQuantFin);
                double prodprice = 50.43*userQuantFin;
                ord._prodList.Add(prod);
                ord._totalprice.Add(prodprice);
            }

            else if (userOrder == "1002")
            {
                Console.Write("Please enter the quantity of the item you want to order: ");
                string userQuant = Console.ReadLine();
                int userQuantFin = Int32.Parse(userQuant);
                Product prod = new Product("1002", "PC Processor", 75.00, userQuantFin);
                double prodprice = 75.00*userQuantFin;
                ord._prodList.Add(prod);
                ord._totalprice.Add(prodprice);
            }

            else if (userOrder == "1003")
            {
                Console.Write("Please enter the quantity of the item you want to order: ");
                string userQuant = Console.ReadLine();
                int userQuantFin = Int32.Parse(userQuant);
                Product prod = new Product("1003", "RAM", 24.99, userQuantFin);
                double prodprice = 24.99*userQuantFin;
                ord._prodList.Add(prod);
                ord._totalprice.Add(prodprice);
            }

            else if (userOrder == "1004")
            {
                Console.Write("Please enter the quantity of the item you want to order: ");
                string userQuant = Console.ReadLine();
                int userQuantFin = Int32.Parse(userQuant);
                Product prod = new Product("1004", "Computer Case", 30.00, userQuantFin);
                double prodprice = 30.00*userQuantFin;
                ord._prodList.Add(prod);
                ord._totalprice.Add(prodprice);
            }

            else if (userOrder == "1005")
            {
                Console.Write("Please enter the quantity of the item you want to order: ");
                string userQuant = Console.ReadLine();
                int userQuantFin = Int32.Parse(userQuant);
                Product prod = new Product("1005", "PC Storage", 20.55, userQuantFin);
                double prodprice = 20.55*userQuantFin;
                ord._prodList.Add(prod);
                ord._totalprice.Add(prodprice);
            }
            else
            {
                Console.WriteLine("Invalid Product ID. Please try again.");
            }

            Console.WriteLine("Another order? Y/N: ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                statement = true;
            }
            else
            {
                statement = false;
            }

        }
        
        Console.WriteLine();
        Console.WriteLine("Please enter your Name: ");
        string customerName = Console.ReadLine();
        Customer customer = new Customer(customerName);
        Console.WriteLine("Please enter your address:");
        Console.Write("Street Address: ");
        string streetAdd = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State/Province: ");
        string stateProvince = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();
        Address address = new Address(streetAdd, city, stateProvince, country);

        Console.WriteLine();
        Console.WriteLine("Order Information:");
        Console.WriteLine("To be Shipped to:");
        customer.getCustomerName();
        address.getAddress();
        Console.WriteLine();
        ord.DisplayOrder();
        double subtotal = ord._totalprice.Sum();
        Console.WriteLine($"Subtotal: {subtotal}");

        if (country == "USA")
        {
            Console.WriteLine("Shipping fee: $5.00");
            double total = subtotal + 5.00;
            Console.WriteLine($"Total: ${total}");
        }
        else
        {
            Console.WriteLine("Shipping fee outside US: $35.00 ");
            double total = subtotal + 35.00;
            Console.WriteLine($"Total: ${total}");
        }

        Console.WriteLine();
        Console.WriteLine("Thank you so much for your purchase! Happy shopping!");
        
        

        


    }
}