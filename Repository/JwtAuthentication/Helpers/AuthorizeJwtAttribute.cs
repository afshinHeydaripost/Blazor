using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Repository.Class;
using Repository.Identity;
using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeJwtAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (ApplicationUser)context.HttpContext.Items["User"];
        if (user == null)
        {
            // not logged in
            context.Result = new JsonResult(new { message = "لطفا احراز هویت کنید" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
        if (user != null)
            if (!user.UserStatus)
                context.Result = new JsonResult(new { message =Message.UserIsNotActive }) { StatusCode = StatusCodes.Status401Unauthorized };
    }
}