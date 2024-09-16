using Domain_Models;

namespace Data_Access.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetAllIncludingUserAndItems();
    }
}
