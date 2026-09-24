public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _stateOrProvidence = "";
    private string _country = "";

    public Address(string streetAddress, string city, string stateOrProvidence, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvidence = stateOrProvidence;
        _country = country;
    }


    public bool IsInUs()
    {
        if (_country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public string GetCompleteAddress()
    {
        return $"{_streetAddress}\n{_city}\n{_stateOrProvidence}\n{_country}";
    }
}