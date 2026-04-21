using AuthMVC.Validations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthMVC.DTOs
{
    public class RegistrationDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [EmailUnique]
        public string Email { get; set; }
        [Required]
        [StringLength(10,MinimumLength =4)]
        public string Username { get; set; }
        [Required]
        [StringLength(8)]
        public string Password { get; set; }
        [Required]
        [StringLength(8)]
        [PasswordMatch]
        public string ConfPassword { get; set; }
        public int Type { get; set; }
    }
}
