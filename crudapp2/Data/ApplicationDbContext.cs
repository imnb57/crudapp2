using Microsoft.EntityFrameworkCore;
using crudapp2.Models;

namespace crudapp2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student{ get; set; }
    }
}
