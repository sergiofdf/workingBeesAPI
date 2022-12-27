namespace WorkingBees.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> ListAll();
        List<T> ListAllByUserId(long Id);
        bool Insert(T entity);
        bool Update(long Id, T entity);
        bool Delete(long Id);
    }
}
