using DomainModels;

namespace Data_Access.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Update(T entity);
        public void Delete(T entity);
        public void Add(T entity);
    }
}
