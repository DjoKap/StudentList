using Microsoft.EntityFrameworkCore;
using SpringFramework.Models;

namespace SpringFramework
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
