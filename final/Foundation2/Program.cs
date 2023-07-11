using System;

class Program
{
    static void Main(string[] args)
    {
        Address firstAddress = new Address("449 Broadway", "Cambridge", "MA", "USA");
        Customer firstCustomer = new Customer("Stefano", firstAddress);
        Product firstProduct = new Product("iPhone 14", "485926", 1000, 1);
        Product secondProduct = new Product("iPhone 14 case",  "849562", 15, 1);
        Order fisrtOrder = new Order(new List<Product> { firstProduct, secondProduct }, firstCustomer);

        Address secondAddress = new Address("127 44 St SE", "Calgary", "Alberta", "Canada");
        Customer secondCustomer = new Customer("Julieta", secondAddress);
        Product thirdProduct = new Product("Bible", "617894", 35, 5);
        Order secondOrder = new Order(new List<Product> { thirdProduct }, secondCustomer);

        Console.WriteLine("#1 Order Packing Label:");
        Console.WriteLine(fisrtOrder.GeneratePackingLabel());
        Console.WriteLine();

        Console.WriteLine("#1 Order Shipping Label:");
        Console.WriteLine(fisrtOrder.GenerateShippingLabel());
        Console.WriteLine();

        Console.WriteLine("#1 Order Total Cost: $" +fisrtOrder.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("#2 Order Packing Label:");
        Console.WriteLine(secondOrder.GeneratePackingLabel());
        Console.WriteLine();

        Console.WriteLine("#2 Order Shipping Label:");
        Console.WriteLine(secondOrder.GenerateShippingLabel());
        Console.WriteLine();

        Console.WriteLine("#2 Order Total Cost: $" + secondOrder.CalculateTotalCost());
        
    }
}