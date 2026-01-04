using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
    }
}
