using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("stringConexão");
        }
    }
}
