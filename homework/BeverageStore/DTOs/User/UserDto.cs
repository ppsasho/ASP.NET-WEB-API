using DTOs.Order;

namespace DTOs.User
{
    public class UserDto
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public List<OrderDto> Orders { get; set; }
    }
}
