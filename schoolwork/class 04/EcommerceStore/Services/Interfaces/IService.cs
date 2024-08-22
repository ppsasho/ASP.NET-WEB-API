using DomainModels;

namespace Services.Interfaces
{
    public interface IService<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public bool Add(T entity);
        public bool Update(T entity);
        public bool DeleteById(int id);

    }
}
