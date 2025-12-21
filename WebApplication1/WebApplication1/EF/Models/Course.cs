using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.EF.Models
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]

        public string Name { get; set; }
        [ForeignKey("Dept")]
        public int DId { get; set; }
        public virtual Department Dept { get; set; }
    }
}
