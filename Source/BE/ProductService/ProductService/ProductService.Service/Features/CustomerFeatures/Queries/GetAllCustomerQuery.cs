using MediatR;
using Microsoft.EntityFrameworkCore;
using ProductService.Domain.Entities;
using ProductService.Persistence;

namespace ProductService.Service.Features.CustomerFeatures.Queries;

public class GetAllCustomerQuery : IRequest<IEnumerable<Customer>>
{
}

public class GetAllCustomerQueryHandler(IApplicationDbContext context)
        : IRequestHandler<GetAllCustomerQuery, IEnumerable<Customer>>
{
    public async Task<IEnumerable<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        var customerList = await context.Customers.ToListAsync(cancellationToken: cancellationToken);
        return customerList.AsReadOnly();
    }

}