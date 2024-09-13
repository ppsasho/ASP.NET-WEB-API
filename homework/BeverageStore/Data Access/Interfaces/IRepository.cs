using Domain_Models;

namespace Data_Access.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        public List<T> GetAll();
        public T GetById(int id);
        public bool Any(int id);
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(int id);
    }
}
