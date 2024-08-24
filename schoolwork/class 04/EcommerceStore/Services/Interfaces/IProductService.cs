using DomainModels;
using DTOs.Product;

namespace Services.Interfaces
{
    public interface IProductService
    {
        public bool Add(CreateProductDto entity);

        public bool DeleteById(int id);

        public IEnumerable<ProductDto> GetAll();

        public Product GetById(int id);

        public bool Update(CreateProductDto entity, Product found);
    }
}
