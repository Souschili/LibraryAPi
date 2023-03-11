namespace MyTestEFCore.DAL.Repository.IRepositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetById(int id);
        Task Add(T entity);
        void Update(T entity);

    }
}
