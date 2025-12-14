using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstAPICore.EF.Tables
{
    public class Student
    {
        [Key]
        public int Id { get; set; } //primary key, auto inc

        [Required]
        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
