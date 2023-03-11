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

        public async Task CompleteAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
