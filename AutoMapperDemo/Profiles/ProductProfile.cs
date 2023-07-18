using AutoMapper;
using AutoMapperDemo.Data;
using AutoMapperDemo.DTO;

namespace AutoMapperDemo.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDTO, Product>().ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.ProductId, opt => opt.Ignore());
            CreateMap<Product, ProductDTO>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName));
        }
    }
}
