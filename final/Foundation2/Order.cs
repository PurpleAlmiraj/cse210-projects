using System.Collections.Generic;

public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public Customer Customer
    {
        get { return customer; }
    }

    public List<Product> Products
    {
        get { return products; }
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (customer.IsUSACustomer())
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
        foreach (Product product in products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Name: {customer.Name}\nAddress:\n{customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}
