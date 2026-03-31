using System;

public class Order
{
    private float _totalCost;
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        // _products = products;
    }
    public void AddProductToOrder(string name, string product, float price, int quantity)
    {
        Product product1 = new Product(name, product, price, quantity);
        _products.Add(product1);
    }
    public float TotalCostOfOrder()
    {
        _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.TotalCost();
        }
        _totalCost += ShippingCost();
        return _totalCost;
    }
    public string PackingLabel()
    {
        string label = "---Packing Label---\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetProduct()}\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        string label = $"---Shipping Label---\n{_customer.CustomerName()}\n{_customer.DisplayAddress()}";
        return label;
    }
    private float ShippingCost()
    {
        int shipping;
        if (_customer.IsInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }
}