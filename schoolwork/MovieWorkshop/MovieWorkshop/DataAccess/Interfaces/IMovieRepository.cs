using DomainModels;
using DTOs;

namespace DataAccess.Interfaces
{
    public interface IMovieRepository<T> where T : BaseEntity
    {
        public bool Create (T entity);
        public List<T> GetAll();
        public T GetById(int id);
        public bool DeleteById(int id);
    }
}
