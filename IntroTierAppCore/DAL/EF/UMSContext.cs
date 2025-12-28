using DAL.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class UMSContext : DbContext
    {
        public UMSContext(DbContextOptions<UMSContext>options)
        :base(options){ }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }

}
