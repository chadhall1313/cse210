using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("5325 Stuart Ave", "Chubbuck", "Idaho", "US");
        Customer customer1 = new Customer("Chad", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct("Banana", "BAN01", 0.68, 7);
        order1.AddProduct("Bread", "BRE02", 5.34, 2);
        order1.AddProduct("Cheesecake", "CHE03", 10.99, 12);
        order1.AddProduct("Caramel Sauce", "CAR04", 6.49, 2);

        Address address2 = new Address("112 Linda St", "Bristol", "none", "EN");
        Customer customer2 = new Customer("Bob", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct("Ibuprofin", "MED34", 7.89, 1);
        order2.AddProduct("Pillow", "SLE99", 15.00, 4);
        order2.AddProduct("Lamp", "ROO11", 26.99, 2);

        Console.WriteLine(order1.ReturnPackingLabel());
        Console.WriteLine(order1.ReturnShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.ReturnPackingLabel());
        Console.WriteLine(order2.ReturnShippingLabel());


    }
}