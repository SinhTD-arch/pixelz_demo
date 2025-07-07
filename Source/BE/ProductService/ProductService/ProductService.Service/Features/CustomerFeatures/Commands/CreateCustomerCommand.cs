using MediatR;
using ProductService.Domain.Entities;
using ProductService.Persistence;

namespace ProductService.Service.Features.CustomerFeatures.Commands;

public class CreateCustomerCommand : IRequest<int>
{
    public string CustomerName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }

}

public class CreateCustomerCommandHandler(IApplicationDbContext context)
    : IRequestHandler<CreateCustomerCommand, int>
{
    public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer
        {
            CustomerName = request.CustomerName,
            ContactName = request.ContactName,
            Address = request.Address,
            City = request.City,
            Region = request.Region,
            PostalCode = request.PostalCode,
            Country = request.Country,
            Phone = request.Phone,
            Fax = request.Fax,
            ContactTitle = request.ContactTitle
        };

        context.Customers.Add(customer);
        await context.SaveChangesAsync();
        return customer.Id;
    }
}
