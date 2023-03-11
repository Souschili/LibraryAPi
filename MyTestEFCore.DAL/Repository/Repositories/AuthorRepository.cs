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
    internal class AuthorRepository :GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context) { }
        
        public Task Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
