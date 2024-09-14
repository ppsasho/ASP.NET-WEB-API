using Data_Access.Interfaces;
using Domain_Models;

namespace Data_Access.Implementations
{
    public class BeverageRepository : Repository<Beverage>, IBeverageRepository
    {
        private readonly BeverageStoreDbContext _context;
        public BeverageRepository(BeverageStoreDbContext context) : base(context)
        {
            _context = context;
        }

        public bool Any(string name)
        {
            return _context.Set<Beverage>().Any(x => x.Name == name);
        }
    }
}
