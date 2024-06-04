public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private decimal _quantity;

    public Product (string name, string prodcutId, decimal price, decimal quantity)
    {
        _name = name;
        _productId = prodcutId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal ProductTotalCost()
    {
        return _price * _quantity;
    }
}