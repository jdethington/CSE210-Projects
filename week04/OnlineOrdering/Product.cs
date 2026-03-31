using System;

public class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product(string name, string product, float price, int quantity)
    {
        _name = name;
        _productID = product;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        // float total = 0;
        // total = _price * _quantity;
        // return total;
        return _price * _quantity;
    }
    public string GetProduct()
    {
        string product = $"{_name} (ID: {_productID})";
        return product;
    }
}