using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Entitys;
using MyTestEFCore.DAL.Repository.IRepositories;

namespace MyTestEFCore.DAL.Repository.Repositories
{
    internal class AuthorInfoRepository : GenericRepository<AuthorInfo>, IAuthorInfoRepository
    {
        public AuthorInfoRepository(ApplicationDbContext context) : base(context) { }
       
    }
}
