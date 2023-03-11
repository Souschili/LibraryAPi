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

        public async Task Add(T entity)
        {
            await _DbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           await _DbSet.ToListAsync();
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
