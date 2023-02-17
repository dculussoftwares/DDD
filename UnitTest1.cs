using Bank.domain;

namespace Bank;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var account1 = new Account();
        var account2 = new Account();
        Customer customer = new Customer(new List<Account>()
        {
            account1,account2
        });
        
        customer.UpdateAddress(new Address("some-city"));
        
        Assert.AreEqual("some-city", customer.Address.City);
        Assert.AreEqual("some-city", account1.Address.City);
        Assert.AreEqual("some-city", account2.Address.City);
    }
}