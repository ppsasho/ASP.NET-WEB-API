using DTOs.Beverage;
using DTOs.OrderItem;
using DTOs.User;
namespace DTOs.Order
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}
