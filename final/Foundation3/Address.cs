using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        // Assigning values of the parameter to the members variable of the class
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}