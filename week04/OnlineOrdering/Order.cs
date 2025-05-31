using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public string PackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += product.ProductDetails();
        }

        return $"{packingLabel}\n";
    }

    public string ShippingLabel()
    {
        return $"{_customer.CustomerInformation()}\n";
    }

    public double TotalPrice()
    {
        double totalOrderPrice;

        if (_customer.IsInUSA() == true)
        {
            totalOrderPrice = 5;
        }
        else
        {
            totalOrderPrice = 35;
        }

        foreach (Product product in _products)
        {
            totalOrderPrice += product.ProductTotalCost();
        }

        return Math.Round(totalOrderPrice, 2);
    }
}