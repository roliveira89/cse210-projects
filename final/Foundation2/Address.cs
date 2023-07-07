public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateProvince = stateProvince;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA" || _country == "United States" || _country == "United States of America";
    }

    public string GetAddressString()
    {
        return $"Street Address: {_streetAddress}\nCity: {_city}\nState/Province: {_stateProvince}\nCountry: {_country}\n";
    }
}