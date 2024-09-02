using DomainModels;
using DTOs.User;

namespace Services.Mappers
{
    public static class UserMapper
    {
        public static User ToModel(this RegisterUserDto user)
        {
            return new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
            };
        }
    }
}
