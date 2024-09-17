using Data_Access.Interfaces;
using Domain_Models;
using DTOs.Order;
using Mappers;
using Services.Helpers;
using Services.Interfaces;
using System.Transactions;

namespace Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IBeverageRepository _beverageRepository;
        private readonly IUserRepository _userRepository;
        public OrderService(IOrderRepository repository, IBeverageRepository repo, IUserRepository repos)
        {
            _orderRepository = repository;
            _beverageRepository = repo;
            _userRepository = repos;
        }
        private bool ValidateOrderItems(OrderCreateDto orderDto, out List<Beverage> orderBeverages)
        {
            orderBeverages = new List<Beverage>();
            bool allIBeveragesValid = true;

            foreach (var item in orderDto.orderItems)
            {
                var validBeverage = _beverageRepository.GetById(item.BeverageId);
                if (validBeverage == null || item.Quantity > validBeverage.Quantity)
                {
                    allIBeveragesValid = false;
                    break;
                }

                orderBeverages.Add(validBeverage);
            }

            return allIBeveragesValid;
        }
        public OrderResult CreateOrder(OrderCreateDto orderDto)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    var user = _userRepository.GetById(orderDto.UserId);
                    if (user == null)
                        return new OrderResult { Success = false, ErrorMessage = "User not found!" };

                    if (!ValidateOrderItems(orderDto, out var orderBeverages))
                        return new OrderResult { Success = false, ErrorMessage = "Invalid beverages or quantities!" };

                    List<OrderItem> items = new();

                    for (int i = 0; i < orderBeverages.Count; i++)
                    {
                        orderBeverages[i].Quantity -= orderDto.orderItems[i].Quantity;
                        _beverageRepository.Update(orderBeverages[i]);

                        var orderItem = new OrderItem()
                        {
                            BeverageId = orderBeverages[i].Id,
                            Quantity = orderDto.orderItems[i].Quantity
                        };
                        items.Add(orderItem);
                    }

                    var newOrder = new Order()
                    {
                        UserId = orderDto.UserId,
                        OrderItems = items
                    };

                    _orderRepository.Add(newOrder);
                    scope.Complete();

                    return new OrderResult { Success = true, OrderId = newOrder.Id };
                }
                catch
                {
                    return new OrderResult { Success = false, ErrorMessage = "An error occurred while creating the order" };
                }
            }
        }

        public List<OrderDto> GetAll() => _orderRepository.GetAllIncludingItems()
                                                          .Select(x => x.ToModel())
                                                          .ToList();

        public OrderDto GetById(int id) {
            var found = _orderRepository.GetByIdIncludingItems(id);
            
            if (found is not null)
                return found.ToModel();

            return new OrderDto();
        }
    }
}
