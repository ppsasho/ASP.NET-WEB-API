using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Interfaces
{
    public interface IUserDbRepository : IRepository<User>
    {
        public bool Any(string username);
        public bool Register(User user);
        public User Login(string username, string password);
    }
}
