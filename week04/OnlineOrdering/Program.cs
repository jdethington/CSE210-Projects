using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("1234 West Main Street", "Mesa", "Arizona", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProductToOrder("Wireless Mouse", "WM-456", 35.99F, 4);
        order1.AddProductToOrder("Wireless Keyboard", "W6-123", 78.99F, 1);
        order1.AddProductToOrder("Headphones", "HP-025", 24.99F, 3);
        order1.AddProductToOrder("Speakers", "SP-510", 249.99F, 5);

        Address address2 = new Address("1234 West Main Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Alice Johnson", address2);
        Order order2 = new Order(customer2);
        order2.AddProductToOrder("Mouse", "WM-457", 35.99F, 1);
        order2.AddProductToOrder("Keyboard", "W6-124", 78.99F, 1);
        order2.AddProductToOrder("Headphones", "HP-035", 124.99F, 1);
        order2.AddProductToOrder("Speakers", "SP-210", 149.99F, 1);



        Console.Clear();

        Console.WriteLine("==========Order 1==========");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total: {order1.TotalCostOfOrder().ToString("C2")}\n");

        Console.WriteLine("==========Order 2==========");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total: {order2.TotalCostOfOrder().ToString("C2")}\n");
    }
}