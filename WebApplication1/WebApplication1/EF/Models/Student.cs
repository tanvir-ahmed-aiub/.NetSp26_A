using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.EF.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="VARCHAR")]
        [StringLength(50)]
        public string Name { get; set; }
        [ForeignKey("Dept")]
        public int DId { get; set; }
        public virtual Department Dept { get; set; }
    }
}
