using AutoMapper;
using Proje3.DB.Entities.DataContext;
using Proje3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3.Service.User
{
    public class UserService : IUserService
    {

        private readonly IMapper mapper;

        public UserService(IMapper _mapper)
        {
            mapper = _mapper;
        }

        public General<Model.User.User> Login(Proje3.Model.Login.Login loginUser)
        {
            General <Model.User.User> result = new();

            using (var srv = new Proje3Context())
            {
                var _data = srv.User.FirstOrDefault(a=> !a.IsDeleted && a.IsActive 
                && a.UserName == loginUser.UserName && a.Password == loginUser.Password);

                if (_data is not null)
                {
                    result.IsSucces = true;
                    result.Entity = mapper.Map<Proje3.Model.User.User>(_data);
                }

            }


            return result;
        }

        

        public General<Model.User.User> Insert(Proje3.Model.User.User newUser)
        {
            var result = new General<Model.User.User>() { IsSucces = false };
            var model = mapper.Map<Proje3.DB.Entities.User>(newUser);

            using (var srv = new Proje3Context())
            {
                model.Idatetime = System.DateTime.Now;
                srv.User.Add(model);
                srv.SaveChanges();
                result.Entity = mapper.Map<Proje3.Model.User.User>(model);
                result.IsSucces = true;
            }
            return result;
        }

        
    }
}
