using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Repository.IRepositories;
using MyTestEFCore.DAL.Repository.Repositories;

namespace MyTestEFCore.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IAuthorRepository Authors { get; }

        public IBookRepository Books { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _dbContext = context;
            Authors = new AuthorRepository(context);
            Books = new BookRepository(context);
        }

        public Task CompleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
