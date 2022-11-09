public class Person
{
    protected string? _name;
    protected string? _address;

    public Person(string name, string address)
    {
        _name = name;
        _address = address;
    }
    public string? getName()
    {
        return _name;
    }
    public string? getAddress()
    {
        return _address;
    }
    public void setAddress(string addrest)
    {
        _address = addrest;
    }

    public override string? ToString()
    {
        return base.ToString();
    }

    public string GetFullInfo()
    {
        return $"{_name} {_address}";
    }

}