using AutoMapper;
using AutoMapperDemo.Data;
using AutoMapperDemo.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private IMapper Mapper { get; }
        public ConversionController(IMapper mapper)
        {
            this.Mapper = mapper;
        }

        [HttpPost("FromCategoryDtoToCategoryEntity")]
        public Category PostFromCategoryDtoToCategoryEntity([FromBody] CategoryDTO categoryDto)
        {
            return Mapper.Map<Category>(categoryDto);
        }
        [HttpPost("FromCategoryEntityToCategoryDto")]
        public CategoryDTO PostFromCategoryEntityToCategoryDto([FromBody] Category categoryEntity)
        {
            return Mapper.Map<CategoryDTO>(categoryEntity);
        }
        [HttpPost("FromProductDtoToProductEntity")]
        public Product PostFromProductDtoToProductEntity([FromBody] ProductDTO productDto)
        {
            return Mapper.Map<Product>(productDto);
        }
        [HttpPost("FromProductEntityToProductDto")]
        public ProductDTO PostFromProductEntityToProductDto([FromBody] Product productEntity)
        {
            return Mapper.Map<ProductDTO>(productEntity);
        }
    }
}
