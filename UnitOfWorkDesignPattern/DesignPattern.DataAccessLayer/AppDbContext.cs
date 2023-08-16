using Microsoft.EntityFrameworkCore;

namespace DesignPattern.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"ConnectionString");
        }
    }
}
