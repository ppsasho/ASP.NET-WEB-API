using Data_Access.Interfaces;
using Domain_Models;
using Microsoft.EntityFrameworkCore;

namespace Data_Access.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly BeverageStoreDbContext _beverageStoreDbContext;
        private readonly DbSet<Order> _table;
        public OrderRepository(BeverageStoreDbContext context) : base(context)
        {
            _beverageStoreDbContext = context;
            _table = context.Set<Order>();
        }

        public List<Order> GetAllIncludingItems() => _table.AsNoTracking().Include(x => x.OrderItems)
                                                                          .ThenInclude(x => x.Beverage)
                                                                          .ToList();
        public Order? GetByIdIncludingItems(int id) => _table.AsNoTracking().Include(x => x.OrderItems)
                                                                            .ThenInclude(x => x.Beverage)
                                                                            .FirstOrDefault(x => x.Id == id);
    } 
}
