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

        public void Add(T entity)
        {
            table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var found = GetById(entity.Id);
            if (found != null)
            {
                table.Remove(found);
                _context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            return table.AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return table.AsNoTracking().FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Update(T entity)
        {
            var found = GetById(entity.Id);
            table.Update(found);
            _context.SaveChanges();
        }
    }
}
