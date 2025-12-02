using PMS.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS.CustomValidation
{
    public class UniqueUName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) {
                var uname = value.ToString();
                var db = new PMS_Fall25_AEntities();
                var obj = (from u in db.Customers where u.Username.Equals(uname) select u).SingleOrDefault();
                if (obj == null)
                {
                    return ValidationResult.Success;
                }
                else {
                    return new ValidationResult("Username Exists");
                }
            }
            return new ValidationResult("Username Required");
        }
    }
}