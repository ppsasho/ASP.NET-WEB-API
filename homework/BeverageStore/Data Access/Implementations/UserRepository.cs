using Data_Access.Interfaces;
using Domain_Models;
using Microsoft.EntityFrameworkCore;

namespace Data_Access.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly BeverageStoreDbContext _context;
        private readonly DbSet<User> _users;
        public UserRepository(BeverageStoreDbContext context) : base(context)
        {
            _context = context;
            _users = _context.Set<User>();
        }
        public List<User> GetAllIncludingOrders() => _users.AsNoTracking().Include(x => x.Orders)
                                                                           .ThenInclude(x => x.OrderItems)
                                                                           .ThenInclude(x => x.Beverage)
                                                                           .ToList();

        public bool Any(string email) => _users.Any(x => x.Email == email);

        public User? Login(string email, string password) => _users.FirstOrDefault(x => x.Email == email && x.Password == password);

        public User? GetWithOrdersById(int id) => _users.Include(x => x.Orders)
                                                        .ThenInclude(x => x.OrderItems)
                                                        .ThenInclude(x => x.Beverage)
                                                        .FirstOrDefault(x => x.Id == id);
    }
}
