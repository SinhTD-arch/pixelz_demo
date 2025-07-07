using AutoMapper;
using ProductService.Domain.Entities;
using ProductService.Infrastructure.ViewModel;

namespace ProductService.Infrastructure.Mapping;

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