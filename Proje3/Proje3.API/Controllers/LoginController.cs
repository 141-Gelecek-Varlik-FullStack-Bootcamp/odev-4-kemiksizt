using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Proje3.Model;
using Proje3.Service.User;
using System;

namespace Proje3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMemoryCache memoryCache;
        private readonly IUserService userService;
        public LoginController(IMemoryCache _memoryCache, IUserService _userService)
        {
            memoryCache = _memoryCache;
            userService = _userService;
        }


        [HttpPost]
        public General<bool> Login([FromBody] Proje3.Model.Login.Login loginUser)
        {
            General<bool> response = new() { Entity = false };
            General<Model.User.User> model = userService.Login(loginUser);

            if (model.IsSucces)
            {
                if (!memoryCache.TryGetValue($"LoginUser", out Model.User.User _loginUser))
                {
                    var cacheOptions = new MemoryCacheEntryOptions()
                    {
                        AbsoluteExpiration = DateTime.Now.AddHours(1),
                        Priority = CacheItemPriority.Normal
                    };


                    memoryCache.Set($"LoginUser", model.Entity);
                }
                response.Entity = true;
                response.IsSucces = true;
            }

            return response;

        }
    }
}

