using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("912 Twin St", "New York", "NY", "USA");
        Address address2 = new Address("69 Elm St", "Berlin", "GER", "Germany");

        Customer customer1 = new Customer("Joseph Joestar", address1);
        Customer customer2 = new Customer("Van Stroheim", address2);

        Product product1 = new Product("Za Warudo", "StandoPower", 999.99m, 1);
        Product product2 = new Product("Can of Beans", "B456", 49.99m, 2);
        Product product3 = new Product("Watermelon", "C789", 79.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost}");
    }
}