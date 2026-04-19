using AuthMVC.EF;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AuthMVC.Validations
{
    public class EmailUnique : ValidationAttribute
    {
        
        
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var db = (AuthASp26Context) validationContext.GetService(typeof(AuthASp26Context));
            
            var res = (from u in db.Users where u.Email.Equals(value) select u).SingleOrDefault();
            if (res == null) {
                return ValidationResult.Success;
            }
            return new ValidationResult("Email Exists");
        }
    }
}
