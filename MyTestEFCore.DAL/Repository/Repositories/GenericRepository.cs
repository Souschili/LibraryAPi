using Microsoft.EntityFrameworkCore;
using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Repository.IRepositories;

namespace MyTestEFCore.DAL.Repository.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        
        protected DbSet<T> _DbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            
            _DbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _DbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await _DbSet.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            _DbSet.Update(entity);
        }

      
    }
}
