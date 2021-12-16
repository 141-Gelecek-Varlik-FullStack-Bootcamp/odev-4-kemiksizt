using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Proje3.API.Infrastructure;
using Proje3.Model;
using Proje3.Service.User;

namespace Proje3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;


        //İsimden bağımsız " base : " diye ayriyetten belirtmek "kalıtım aldığı yer" anlamındadır.


        public UserController(IUserService _UserService, IMapper _mapper, IMemoryCache _memoryCache) : base(_memoryCache)
        {
            userService = _UserService;
            mapper = _mapper;

        }


        [HttpPost]
        [ServiceFilter(typeof(LoginFilter))]
        //[LoginFilter]
        public General<Model.User.User> Insert([FromBody] Proje3.Model.User.User newUser)
        {
            General<Model.User.User> response = new();
            //if (CurrentUser is null)
            //{
            //    response.ExceptionMessage = "Lütfen Giriş yapın!";
            //    return response;
            //}
       
            return userService.Insert(newUser);


        }

        
    }
}
