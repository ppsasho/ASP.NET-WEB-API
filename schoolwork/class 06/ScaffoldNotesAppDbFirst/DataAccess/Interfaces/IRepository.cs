namespace DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void DeleteById(int id);
    }
}
