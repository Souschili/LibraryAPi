using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Entitys;
using MyTestEFCore.DAL.Repository.IRepositories;

namespace MyTestEFCore.DAL.Repository.Repositories
{
    internal class AuthorRepository :GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context) { }
        
       
    }
}
