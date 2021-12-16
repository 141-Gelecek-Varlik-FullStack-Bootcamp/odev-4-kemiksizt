using Proje3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3.Service.User
{
    public interface IUserService
    {   
        public General<Model.User.User> Login(Proje3.Model.Login.Login loginUser);
        public General<Proje3.Model.User.User> Insert(Proje3.Model.User.User newUser);
    }
}
