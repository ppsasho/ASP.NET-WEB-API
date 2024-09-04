using DTOs.User;

namespace Services.Interfaces
{
    public interface IUserService
    {
        bool RegisterUser(RegisterUserDto registerUserDto);
        UserLoginResponseDto LoginUser(string username, string password);
    }
}
