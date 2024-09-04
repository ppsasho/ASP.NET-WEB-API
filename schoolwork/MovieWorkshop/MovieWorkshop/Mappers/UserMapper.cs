using DTOs.User;
using DomainModels;

namespace Mappers
{
    public static class UserMapper
    {
        public static UserLoginResponseDto ToModel(this User user, string token)
        {
            return new UserLoginResponseDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Token = token
            };
        }
        public static User ToModel(this RegisterUserDto user) 
        {
            return new User()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password
            };
        }
    }
}
