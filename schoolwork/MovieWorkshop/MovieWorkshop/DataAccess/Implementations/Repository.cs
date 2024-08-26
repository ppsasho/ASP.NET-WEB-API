using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly List<T> _entities;
        public Repository(List<T> entities)
        {
            _entities = entities;
        }

        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Create(T entity)
        {
            _entities.Add(entity);
            return true;
        }

        public bool DeleteById(int id)
        {
            return _entities.Remove(GetById(id));
        }

        public List<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id.Equals(id));
        }

        public bool Update(T entity)
        {
            var foundIndex = _entities.FindIndex(x => x.Id.Equals(entity.Id));
            if (foundIndex >= 0)
            {
                _entities[foundIndex] = entity;
                return true;
            }
            return false;
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
