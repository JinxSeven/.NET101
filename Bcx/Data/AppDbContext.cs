using Bcx.Models;
using Microsoft.EntityFrameworkCore;

namespace Bcx.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {       
        }

        public DbSet<Category> Categories { get; set; }
    }
}
