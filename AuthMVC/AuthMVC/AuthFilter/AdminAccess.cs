using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AuthMVC.AuthFilter
{
    public class AdminAccess : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var data = context.HttpContext.Session.GetString("Uname");
            var type = context.HttpContext.Session.GetInt32("UType");
            if (data == null || type != 1)
            {

                context.Result = new RedirectToActionResult("Login", "Auth", null);
            }
            
        }
    }
}
