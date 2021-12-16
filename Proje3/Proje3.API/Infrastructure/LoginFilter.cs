using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace Proje3.API.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {

        private readonly IMemoryCache memoryCache;

        public LoginFilter(IMemoryCache _memoryCache)
        {
            memoryCache = _memoryCache;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!memoryCache.TryGetValue("Loginuser", out Model.User.User response))
            {
                context.Result = new UnauthorizedObjectResult("Lütfen giriş yapınız.");
            }

            return;
        }
    }
}
