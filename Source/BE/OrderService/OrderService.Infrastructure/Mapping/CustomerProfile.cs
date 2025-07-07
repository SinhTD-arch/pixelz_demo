using AutoMapper;
using OrderService.Domain.Entities;
using OrderService.Infrastructure.ViewModel;

namespace OrderService.Infrastructure.Mapping;

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