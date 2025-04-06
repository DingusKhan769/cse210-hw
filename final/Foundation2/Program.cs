using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Widget", "W123", 10.50, 2),
            new Product("Gadget", "G456", 15.75, 1),
            new Product("Thingamajig", "T789", 7.25, 3)
        };
        Order order1 = new Order(products1, customer1);

        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Doohickey", "D101", 12.99, 4),
            new Product("Whatchamacallit", "W202", 9.99, 2)
        };
        Order order2 = new Order(products2, customer2);

        PrintOrderDetails(order1);
        PrintOrderDetails(order2);
    }

    private static void PrintOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");
    }
}