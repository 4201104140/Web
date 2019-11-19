using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tai.Models.UserModel
{
    public class SignInModel
    {
        [Required(ErrorMessage ="Email không được trống.")]
        [EmailAddress(ErrorMessage ="Vui lòng nhập email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Mật khẩu không được trống.")]
        [MinLength(6,ErrorMessage ="Mật khẩu trên 6 ký tự")]
        public string Password { get; set; }
    }
}
