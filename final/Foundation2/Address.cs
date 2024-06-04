public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }

    public bool IsFromUSA()
    {
        bool result;

        if(_country == "USA" || _country == "United States")
        {
            result = true;
        }

        else{
            result= false;
        }

        return result;
    }
}