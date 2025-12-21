using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
