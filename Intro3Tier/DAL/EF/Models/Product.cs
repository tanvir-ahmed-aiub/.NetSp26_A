using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Column(TypeName ="VARCHAR")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        [ForeignKey("Category")]
        public int CId { get; set; }
        public virtual Category Category { get; set; }
    }
}
