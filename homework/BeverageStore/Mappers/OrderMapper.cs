using Domain_Models;
using DTOs.Order;
using DTOs.OrderItem;

namespace Mappers
{
    public static class OrderMapper
    {
        public static OrderDto ToModel(this Order model)
        {
            var orderItems = new List<OrderItemDto>();
            if (model.OrderItems != null)
            {
                orderItems = model.OrderItems.Select(x => x.ToModel()).ToList();
            }
            return new OrderDto
            {
                OrderId = model.Id,
                UserId = model.UserId,
                //User = model.User.ToModel(),
                OrderItems = orderItems
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