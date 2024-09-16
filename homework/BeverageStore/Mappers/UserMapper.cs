using Domain_Models;
using DTOs.Order;
using DTOs.User;

namespace Mappers
{
    public static class UserMapper
    {
        public static UserDto ToModel(this User model) => new UserDto
        {
            Fullname = model.FullName,
            Email = model.Email,
            //Orders = model.Orders.Select(x => x.ToModel()).ToList() ?? new List<OrderDto>(),
        };

        public static UserLoginResponseDto ToModel(this User user, string token)
        {
            return new UserLoginResponseDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Token = token
            };
        }

        public static User ToModel(this UserCreateDto model, string hashedPassword) => new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Password = hashedPassword,
        };
        public static User ToModel(this UserCreateDto model) => new User()
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Password = model.Password
        };
    }
}
