using Data_Access.Interfaces;
using Domain_Models;

namespace Data_Access.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(BeverageStoreDbContext context) : base(context)
        {
        }
    }
}
