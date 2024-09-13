using Domain_Models;

namespace Data_Access.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public bool Any(string email);
        public User Login(string email, string password);
    }
}
