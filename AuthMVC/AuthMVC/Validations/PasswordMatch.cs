using AuthMVC.DTOs;
using System.ComponentModel.DataAnnotations;

namespace AuthMVC.Validations
{
    public class PasswordMatch : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var obj = validationContext.ObjectInstance as RegistrationDTO;
            if (value != null && value.Equals(obj.Password)) { 
                return ValidationResult.Success;
            }

            return new ValidationResult("Password and Cofirm Password Mismatch");
        }
    }
}
