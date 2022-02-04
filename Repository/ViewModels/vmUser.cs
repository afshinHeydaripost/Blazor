using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class vmUser
    {
    }
    public class vmLogin
    {
        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage = "{0} را وارد کنید")]
        public string Username { get; set; }

        [Display(Name = "کلمه عبور")]

        [Required(ErrorMessage = "{0} را وارد کنید")]
        public string Password { get; set; }
    }
}
