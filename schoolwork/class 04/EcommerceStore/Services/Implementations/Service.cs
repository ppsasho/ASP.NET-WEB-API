using Data_Access.Interfaces;
using DomainModels;
using Services.Interfaces;

namespace Services.Implementations
{
    public class Service<T> : IService<T> where T : Base
    {
        protected virtual IRepository<T> _repository { get; set; }
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public bool DeleteById(int id)
        {
            bool found = _repository.Any(id);
            if (found) return _repository.DeleteById(id);
            return found;
        }
        public virtual List<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }
        public virtual bool Add(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual bool Update(T entity)
        {
            throw new NotImplementedException();
        }

    }
}
