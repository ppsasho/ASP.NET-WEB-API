using Data_Access.Interfaces;
using DomainModels;

namespace Data_Access.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly EcommerceDbContext _context;
        public UserRepository(EcommerceDbContext context) : base(context)
        {
            _context = context;
        }

        public User Login(string username, string hashedPassword)
        {
            return _context.Users.SingleOrDefault(x => x.Username == username && x.Password == hashedPassword);
        }
    }
}
