using DomainModels;

namespace Data_Access.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        public List<T> GetAll();
        public T? GetById(int id);
        public bool Update(T entity);
        public bool DeleteById(int id);
        public bool Add(T entity);
        public void AddList(List<T> entities);
        public bool Any(int id);
    }
}
