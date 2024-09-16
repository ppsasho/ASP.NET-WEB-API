using Domain_Models;
using DTOs.Order;
using DTOs.OrderItem;

namespace Mappers
{
    public static class OrderMapper
    {
        public static OrderDto ToModel(this Order model)
        {
            return new OrderDto
            {
                OrderId = model.Id,
                UserId = model.UserId,
                User = model.User.ToModel(),
                OrderItems = model.OrderItems.Select(x => x.ToModel()).ToList() ?? new List<OrderItemDto>()
            };
        }
        public static OrderItemDto ToModel(this OrderItem model)
        {
            return new OrderItemDto
            {
                BeverageId = model.BeverageId,
                Beverage = model.Beverage.ToModel(),
                Quantity = model.Quantity,
            };
        }
    }
}