public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost
    {
        get
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.TotalCost;
            }
            total += customer.IsInUSA() ? 5 : 35;
            return total;
        }
    }

    public string PackingLabel()
    {
        string label = "Order Contents:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.CustomerAddress}";
    }
}