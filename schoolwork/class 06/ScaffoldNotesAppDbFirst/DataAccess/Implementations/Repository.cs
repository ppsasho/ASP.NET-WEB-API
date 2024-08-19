using DataAccess.Interfaces;

namespace DataAccess.Implementations
{
    public class Repository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
