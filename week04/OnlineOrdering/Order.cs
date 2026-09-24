using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalPrice = 0;
        double shippingCost = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.ComputeTotalPrice();
        }

        if (_customer.IsInUs())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return totalPrice + shippingCost;
    }

    public string ReturnPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetId()}\n";
        }
        label += $"${CalculateTotalCost():0.00}\n";
        return label;
    }
    
    public string ReturnShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}