public class Customer
{
    private string _name;
    private Address _address;

    public string Name
    {
        get { return _name; } // Return value of private member variable "name"
        set { _name = value; } // Set the value of the private member variable "name" to the value passed to it
    }

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        // Check if the customer's address is in the USA or not
        return _address.IsInUSA();
    }

    public string GetAddressString()
    {
        return _address.GetAddressString();
    }
}