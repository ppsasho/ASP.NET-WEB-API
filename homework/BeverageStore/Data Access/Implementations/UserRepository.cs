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

        public bool Any(string email) => _users.Any(x => x.Email == email);

        public User Login(string email, string password) => _users.FirstOrDefault(x => x.Email == email && x.Password == password);
    }
}
