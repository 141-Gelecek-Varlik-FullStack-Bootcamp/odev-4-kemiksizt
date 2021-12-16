using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Proje3.API.Infrastructure
{
    
    public class BaseController : ControllerBase
    {

        private readonly IMemoryCache memoryCache;
        public BaseController(IMemoryCache _memoryCache)
        {
            memoryCache = _memoryCache;
        }

        
        public Model.User.User CurrentUser
        {
            get
            {
                return GetCurrentUser();
            }
        }

      
        private Model.User.User GetCurrentUser()
        {
            var response = new Model.User.User();

            if (memoryCache.TryGetValue($"LoginUser", out Model.User.User loginUser))
            {
                response = loginUser;
            }

            return loginUser; //Gc muhabbeti twitter
        }

    }
}
