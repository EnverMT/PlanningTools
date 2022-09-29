using Microsoft.EntityFrameworkCore;

namespace XerParser.Services.DataBase.SQLite
{
    public class ApplicationContext : DbContext
    {
        public DbSet<XerParser.Models.Classes.TASK> Tasks => Set<XerParser.Models.Classes.TASK>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}
