using DomainModels;
using DTOs;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public List<T> GetAll();
        public T GetById(int id);
        bool Update(T entity);
        public bool Create (T entity);
        public bool DeleteById(int id);
    }
}
