using System.Data.Common;
using System.Security.AccessControl;

public class Product
{

    private string _name = "";
    private string _id = "";
    private double _price = 0;
    private int _quantity = 0;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }

    public double ComputeTotalPrice()
    {
        return _quantity * _price;
    }
}