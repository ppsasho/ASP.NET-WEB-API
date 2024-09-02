using DomainModels;

namespace Data_Access.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Login(string username, string hashedPassword);

    }
}
