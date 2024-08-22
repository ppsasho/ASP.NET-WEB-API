using Data_Access.Interfaces;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data_Access.Implementations
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private readonly EcommerceDbContext _context;
        private readonly DbSet<T> table = null;
        public Repository(EcommerceDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public bool Add(T entity)
        {
            table.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public void AddList(List<T> entities)
        {
            table.AddRange(entities);
            _context.SaveChanges();
        }

        public bool Any(int id) => table.Any(x => x.Id.Equals(id));

        public bool DeleteById(int id)
        {
            var found = GetById(id);
            if (found != null)
            {
                table.Remove(found);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<T> GetAll()
        {
            return table.AsNoTracking().ToList();
        }

        public T? GetById(int id)
        {
            return table.AsNoTracking().FirstOrDefault(x => x.Id.Equals(id));
        }

        public bool Update(T entity)
        {
            table.Update(entity);
            return _context.SaveChanges() >= 1;
        }
    }
}
