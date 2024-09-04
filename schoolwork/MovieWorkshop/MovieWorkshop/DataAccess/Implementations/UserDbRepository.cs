using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class UserDbRepository : DbRepository<User>, IUserDbRepository
    {
        private readonly MovieWorskshopDbContext _context;
        public UserDbRepository(MovieWorskshopDbContext context) : base(context)
        {
            _context = context;
        }
        public bool Any(string username) => _context.Users.Any(x => x.Username == username);

        public bool Register(User user)
        {
            _context.Users.Add(user);
            var value = _context.SaveChanges() > 0;
            return value;
        }
        public User Login(string username, string password) => 
            _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
        
    }
}
