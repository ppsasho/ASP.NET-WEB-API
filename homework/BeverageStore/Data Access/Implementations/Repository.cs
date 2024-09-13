using Data_Access.Interfaces;
using Domain_Models;
using Microsoft.EntityFrameworkCore;

namespace Data_Access.Implementations
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private readonly BeverageStoreDbContext _dbContext;
        private readonly DbSet<T> _table;
        public Repository(BeverageStoreDbContext context)
        {
            _dbContext = context;
            _table = context.Set<T>();
        }
        public bool Add(T entity)
        {
            _table.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Any(int id) => _table.Any(x => x.Id.Equals(id));

        public bool Delete(int id)
        {
            _table.Remove(GetById(id));
            return _dbContext.SaveChanges() > 0;
        }

        public List<T> GetAll() => _table.AsNoTracking().ToList();

        public T GetById(int id) => _table.AsNoTracking().FirstOrDefault(x => x.Id == id);

        public bool Update(T entity)
        {
            _table.Update(entity);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
