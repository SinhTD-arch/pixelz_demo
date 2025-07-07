using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using OrderService.Domain.Entities;
using OrderService.Persistence;

namespace OrderService.Test.Unit.Persistence;

public class ApplicationDbContextTest
{
    [Test]
    public void CanInsertCustomerIntoDatabase()
    {

        using var context = new ApplicationDbContext();
        var customer = new Customer();
        context.Customers.Add(customer);
        Assert.That(context.Entry(customer).State, Is.EqualTo(EntityState.Added));
    }
}