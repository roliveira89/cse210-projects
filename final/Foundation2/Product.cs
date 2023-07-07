public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public string Name
    {
        get { return _name; } // Return value of private member variable "name"
        set { _name = value; } // Set the value of the private member variable "name" to the value passed to it
    }

    public int ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public float Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public Product(string name, int productId, float price, int quantity)
    // Assign the values of the parameters to the corresponding member variables
    {
        // "this" refers to the current instance of the Product class
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public float CalculatePrice()
    {
        return _price * _quantity;
    }
}