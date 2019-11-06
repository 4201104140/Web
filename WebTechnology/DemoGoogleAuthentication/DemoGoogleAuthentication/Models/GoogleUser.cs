using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoGoogleAuthentication.Models
{
    public class GoogleUser
    {
        [Display(Name = "Id")]
        public string Id { get; set; } = "";
        [Display(Name = "Họ tên")]
        public string Username { get; set; } = "";
        public string Email { get; set; }
        public string AccessToken { get; set; } = "";
        [Display(Name = "Hình")]
        public string ImageUrl { get; set; } = "";
    }
}