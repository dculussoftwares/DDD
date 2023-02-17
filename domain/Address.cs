namespace Bank.domain;

public class Address
{
    public Address(string city)
    {
        City = city;
    }

    public string City { set; get; }
}