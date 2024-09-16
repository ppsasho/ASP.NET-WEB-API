using DTOs.Order;
using Services.Helpers;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        public List<OrderDto> GetAll();
        public OrderDto GetById(int id);
        public OrderResult CreateOrder(OrderCreateDto order);
    }
}
