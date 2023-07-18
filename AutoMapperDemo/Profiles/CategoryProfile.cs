using AutoMapperDemo.Data;
using AutoMapperDemo.DTO;
using AutoMapper;

namespace AutoMapperDemo.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDTO, Category>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.CategoryId, opt => opt.Ignore());
            CreateMap<Category, CategoryDTO>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));
        }
    }
}
