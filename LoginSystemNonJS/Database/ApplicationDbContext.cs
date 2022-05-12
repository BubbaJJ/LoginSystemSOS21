using LoginSystemNonJS.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginSystemNonJS.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}