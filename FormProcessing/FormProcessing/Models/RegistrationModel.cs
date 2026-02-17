using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FormProcessing.Models
{
    public class RegistrationModel
    {
        [Required]
        [StringLength(100)]
        
        public string Name { get; set; }
        [StringLength(100)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Range(1,40)]
        public int Roll { get; set; }
    }
}
