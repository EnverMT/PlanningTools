using Microsoft.EntityFrameworkCore;

namespace DatabaseManager
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Models.TASK> Tasks => Set<Models.TASK>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}
