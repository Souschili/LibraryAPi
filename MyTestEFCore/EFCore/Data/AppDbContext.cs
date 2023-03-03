using Microsoft.EntityFrameworkCore;

namespace MyTestEFCore.NewFolder.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        

    }
}
