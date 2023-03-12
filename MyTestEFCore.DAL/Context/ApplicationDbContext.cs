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
            modelBuilder.Entity<Book>()
                .HasOne(a => a.Author)
                .WithMany(c => c.Books)
                .HasForeignKey(a => a.AuthorName)
                .HasPrincipalKey(c => c.FullName);


            modelBuilder.Entity<AuthorInfo>()
            .HasOne(a => a.Author)
            .WithOne(i => i.AuthorInfo)
            .HasForeignKey<AuthorInfo>(i => i.AuthorName)
            .HasPrincipalKey<Author>(a => a.FullName);
                
                
           
        }
    }
}
