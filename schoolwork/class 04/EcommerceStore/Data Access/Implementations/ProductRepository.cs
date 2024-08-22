using Data_Access.Interfaces;
using DomainModels;

namespace Data_Access.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceDbContext context)
            : base(context) { }
    }
}
