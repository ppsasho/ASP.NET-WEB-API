using DataAccess.Interfaces;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class DbRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MovieWorskshopDbContext _context;
        private  readonly DbSet<T> table;
        public DbRepository(MovieWorskshopDbContext context)
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

        public void AddList(IEnumerable<T> entities)
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
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public IEnumerable<T> GetAll()
        {
            return table.AsNoTracking().ToList();
        }

        public T? GetById(int id) => table.AsNoTracking().FirstOrDefault(x => x.Id.Equals(id));
        public bool Update(T entity)
        {
            table.Update(entity);
            return _context.SaveChanges() > 0;
        }
    }
}
