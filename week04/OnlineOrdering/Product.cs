public class Product
{

    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double ProductTotalCost()
    {
        return _price * _quantity;
    }

    public string ProductDetails()
    {
        return $"x{_quantity} {_name} ID: {_productId}\n";
    }
}