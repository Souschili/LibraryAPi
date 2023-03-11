using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Entitys;
using MyTestEFCore.DAL.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestEFCore.DAL.Repository.Repositories
{
    internal class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
