using esport.Models;
using Microsoft.EntityFrameworkCore;

namespace esport.DB
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
