using Data_Access.Interfaces;
using DomainModels;

namespace Data_Access.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(EcommerceDbContext context) : base(context) { }
    }
}
