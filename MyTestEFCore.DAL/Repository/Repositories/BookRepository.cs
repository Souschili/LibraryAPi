using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Entitys;
using MyTestEFCore.DAL.Repository.IRepositories;

namespace MyTestEFCore.DAL.Repository.Repositories
{
    internal class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
