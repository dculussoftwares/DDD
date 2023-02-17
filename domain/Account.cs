namespace Bank.domain;

public class Account
{
    public Address Address { set; get; }

    public void UpdateAddress(Address address)
    {
        Address = address;
    }
}