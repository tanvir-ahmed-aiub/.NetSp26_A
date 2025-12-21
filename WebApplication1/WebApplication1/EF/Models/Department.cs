using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.EF.Models
{
    public class Department
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }
    }
}
