using PMS.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [UniqueUName]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [ConfPassValidate]
        public string ConfPass { get; set; }
    }
}