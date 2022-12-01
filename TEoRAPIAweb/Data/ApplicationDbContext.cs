using Microsoft.EntityFrameworkCore;
using TEoRAPIAweb.Model;

namespace TEoRAPIAweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }

    }
}
