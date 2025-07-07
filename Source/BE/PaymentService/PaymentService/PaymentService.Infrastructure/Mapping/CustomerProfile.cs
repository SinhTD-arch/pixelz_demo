using AutoMapper;
using PaymentService.Domain.Entities;
using PaymentService.Infrastructure.ViewModel;

namespace PaymentService.Infrastructure.Mapping;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CustomerModel, Customer>()
            .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src => src.CustomerId))
            .ReverseMap();
    }
}