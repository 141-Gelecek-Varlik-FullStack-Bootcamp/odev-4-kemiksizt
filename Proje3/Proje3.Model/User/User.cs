using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3.Model.User
{
    public class User
    {
        [Required(ErrorMessage = "Beklenmeyen bir hata oluştu")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime IDate = DateTime.Now;
    }
}
