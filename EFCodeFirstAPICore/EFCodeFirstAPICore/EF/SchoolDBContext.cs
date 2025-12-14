using EFCodeFirstAPICore.EF.Tables;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EFCodeFirstAPICore.EF
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
           :base(options) { }
        public DbSet<Student> Students { get; set; }

    }
}
