using Microsoft.EntityFrameworkCore;

namespace MyTestEFCore.DAL.Context
{
    internal class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        
    }
}
