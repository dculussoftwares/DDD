namespace Bank.domain;

public class Customer
{
    public Customer(List<Account> accounts)
    {
        Accounts = accounts;
    }

    public List<Account> Accounts { set; get; }
    public Address Address { set; get; }

    public void UpdateAddress(Address address)
    {
        Address = address;
        foreach (var account in Accounts)
        {
            account.UpdateAddress(address);
        }
    }
}