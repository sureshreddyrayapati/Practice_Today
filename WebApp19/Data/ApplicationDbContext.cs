
using Microsoft.EntityFrameworkCore;
using WebApp19.Models;

namespace WebApp19.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Mphasis> mphases { get; set; }
    }
}
