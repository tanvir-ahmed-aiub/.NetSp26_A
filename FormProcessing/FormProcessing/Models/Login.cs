using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormProcessing.Models
{
    public class Login
    {
        [Required (ErrorMessage ="Provide Username")]
        [StringLength(6,ErrorMessage ="Username must not exceed 6 ")]
        public string Username { get; set; }
        [Required]
        [StringLength (50,MinimumLength =8)]
        public string Password { get; set; }
    }
}