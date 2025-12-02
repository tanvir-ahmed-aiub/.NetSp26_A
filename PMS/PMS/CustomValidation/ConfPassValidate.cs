using PMS.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS.CustomValidation
{
    public class ConfPassValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cus = validationContext.ObjectInstance as CustomerDTO;
            if (cus.Password != null && value != null)
            {
                if (cus.Password.Equals(value.ToString())) {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Confirm Password not Matched");
        }
    }
}