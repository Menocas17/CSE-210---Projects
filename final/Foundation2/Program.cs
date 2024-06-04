using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123 street", "TestLandia", "Testaland", "USA");
        Customer customerTest1 = new Customer("Test1", address1);

        Address address2 = new Address("123 stree", "Testlandia1", "Testaland2", "Nicaragua");
        Customer customerTest2 = new Customer("Test2", address2);

        Product product1 = new Product("test1", "test12234", 34.55m, 2);
        Product product2 = new Product("test2", "test2345", 14.99m, 5);
        Product product3 = new Product("test3", "test3456", 9.99m, 1);
        Product product4 = new Product("test4", "test4567", 25.50m, 2);

        Order order1 = new Order(customerTest1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customerTest1);
        order2.AddProduct(product2);
        order2.AddProduct(product4);

        Order order3 = new Order(customerTest1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        Order order4 = new Order(customerTest2);
        order4.AddProduct(product1);
        order4.AddProduct(product4);

        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);
        orders.Add(order4);

        foreach(Order order in orders)
        {
            order.GetShippingLabel();
            Console.WriteLine();
            order.GetPackingLabel();
            Console.WriteLine();
            order.TotalCost();
            Console.WriteLine("--------------------\n");
        }
    
    }



}