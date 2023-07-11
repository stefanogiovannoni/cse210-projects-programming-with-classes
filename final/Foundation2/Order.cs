class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost = totalCost + product.GetTotalPrice();
        }
        if (_customer.IsInUSA())
        {
            totalCost = totalCost + 5;
        }
        else
        {
            totalCost = totalCost + 35;
        }
        return  totalCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "";
        
        foreach (Product product in _products)
        {
            packingLabel = packingLabel + $"Name: {product.GetName()}\nProduct ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetFullAddress();
        return $"Name: {customerName} \nAddress: {customerAddress}";
    }
}