class Program
{
    static void Main()
    {
        // (Street, city, province/state, country)
        Address address1 = new Address("123 Main St", "City 1", "State 1", "USA");
        Customer customer1 = new Customer("Nathan", address1);

        // (Name, product ID, price, quantity)
        Product product1 = new Product("Product 1", 1, 10, 2);
        Product product2 = new Product("Product 2", 2, 15, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Address address2 = new Address("456 Elm St", "City 2", "State 2", "Canada");
        Customer customer2 = new Customer("Raphael", address2);

        Product product3 = new Product("Product 3", 3, 20, 2);
        Product product4 = new Product("Product 4", 4, 25, 1);
        Product product5 = new Product("Product 5", 5, 23, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("\nOrder 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");

        Console.ReadLine();
    }
}