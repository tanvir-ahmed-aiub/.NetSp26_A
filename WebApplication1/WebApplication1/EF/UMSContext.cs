using Microsoft.EntityFrameworkCore;
using WebApplication1.EF.Models;

namespace WebApplication1.EF
{
    public class UMSContext : DbContext
    {
        public UMSContext(DbContextOptions<UMSContext> options)
        : base(options)
        {
        }
      
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
