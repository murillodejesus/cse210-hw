using System;

class Program {
    static void Main(string[] args) {
        Product product1 = new Product { Name = "Product A", ProductId = 1, Price = 10, Quantity = 2};
        Product product2 = new Product { Name = "Product B", ProductId = 2, Price = 20, Quantity = 1};

        Customer customer = new Customer {
            Name = "John Doe",
            Address = new Address { Street = "135 Main St", City = "New York", State = "NY", Country = "USA" } 
        };
        
        Order order = new Order { Customer = customer };
        order.Products.Add(product1);
        order.Products.Add(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
    }
}