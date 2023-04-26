using Microsoft.EntityFrameworkCore;
using WebAPI.Entity;
namespace WebAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}