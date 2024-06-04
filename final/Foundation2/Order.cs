using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

public class Order
{
    private List<Product> _prodcuts = new List<Product>();
    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct (Product product)
    {
        _prodcuts.Add(product);
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label:");

        foreach(Product product in _prodcuts)
        {
            Console.WriteLine($"Name: {product.GetProductName()}  -  Product ID: {product.GetProductId()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customer.GetCustomerName()}");
        Console.WriteLine($"Address: {_customer.GetCustomerAddress()}");
    }

    public void TotalCost()
    {

        decimal totalToPay = 0;
        foreach(Product product in _prodcuts)
        {
            totalToPay += product.ProductTotalCost();
        }

        if(_customer.IsFromUSA() == true)
        {
            totalToPay += 5;
        }

        else
        {
            totalToPay += 35;
        }

        Console.WriteLine($"Total Cost: ${totalToPay}");
    }

}