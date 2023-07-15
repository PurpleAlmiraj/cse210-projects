using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public Customer Customer
    {
        get { return _customer; }
    }

    public List<Product> Products
    {
        get { return _products; }
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (_customer.IsUSACustomer())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Name: {_customer.Name}\nAddress:\n{_customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}
