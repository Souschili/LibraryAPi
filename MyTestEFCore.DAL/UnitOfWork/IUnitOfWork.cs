using MyTestEFCore.DAL.Repository.IRepositories;

namespace MyTestEFCore.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }

        Task CompleteAsync();
        Task DisposeAsync();
        void Dispose();

    }
}
