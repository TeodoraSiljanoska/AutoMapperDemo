namespace AutoMapperDemo.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO()
        {
            Products = new HashSet<ProductDTO>();
        }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}
