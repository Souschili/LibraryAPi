using Microsoft.EntityFrameworkCore;
using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Repository.IRepositories;

namespace MyTestEFCore.DAL.Repository.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _Context;
        protected DbSet<T> _DbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
        }

        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
