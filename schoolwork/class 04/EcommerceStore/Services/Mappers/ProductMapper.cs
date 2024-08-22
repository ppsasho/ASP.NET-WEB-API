using DomainModels;
using DTOs.Product;

namespace Services.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToModel(this Product product)
        {
            return new ProductDto()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
            };
        }
        public static Product ToModel(this CreateProductDto createDto) 
        {
            return new Product()
            {
                Name = createDto.Name,
                Description = createDto.Description,
                Price = createDto.Price,
                ImageUrl = createDto.ImageUrl,
                StockQuantity = createDto.StockQuantity,
                CategoryId = createDto.CategoryId,
            };
        }
    }
}
