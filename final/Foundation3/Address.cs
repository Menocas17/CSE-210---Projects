public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private int _zipCode;

    public Address(string street, string city, string stateProvince, string country, int zipCode)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _zipCode = zipCode;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}, {_zipCode}";
    }
}