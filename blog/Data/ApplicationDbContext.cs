using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }
        public DbSet<User> Users { get; set; }
    }
}
