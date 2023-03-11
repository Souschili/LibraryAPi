using Microsoft.EntityFrameworkCore;
using MyTestEFCore.DAL.Entitys;

namespace MyTestEFCore.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Author
            modelBuilder.
        }
    }
}
