using Data_Access.Interfaces;
using DomainModels;

namespace Data_Access.Implementations
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(EcommerceDbContext context)
            : base(context) { }
    }
}
