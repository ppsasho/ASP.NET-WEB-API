using DomainModels;
using DTOs;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        bool Update(T entity);
        public bool Add (T entity);
        public bool DeleteById(int id);
    }
}
