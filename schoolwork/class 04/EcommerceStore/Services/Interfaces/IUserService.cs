using DTOs.User;

namespace Services.Interfaces
{
    public interface IUserService
    {
        bool Register(RegisterUserDto user);
        string LoginUser(string username, string password);
    }
}
