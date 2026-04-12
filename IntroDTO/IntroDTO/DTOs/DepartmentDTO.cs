using System.ComponentModel.DataAnnotations;

namespace IntroDTO.DTOs
{
    public class DepartmentDTO
    {
        
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
