using Data_Access.Interfaces;
using Domain_Models;

namespace Data_Access.Implementations
{
    public class BeverageRepository : Repository<Beverage>, IBeverageRepository
    {
        public BeverageRepository(BeverageStoreDbContext context) : base(context)
        {
        }
    }
}
