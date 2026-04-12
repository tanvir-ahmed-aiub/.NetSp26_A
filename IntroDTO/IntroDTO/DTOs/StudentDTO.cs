using System.ComponentModel.DataAnnotations;

namespace IntroDTO.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int DeptId { get; set; }

    }
}
