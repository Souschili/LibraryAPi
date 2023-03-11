namespace MyTestEFCore.DAL.Repository.IRepositories
{
    internal interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);

    }
}
