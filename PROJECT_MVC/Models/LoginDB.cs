using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJECT_MVC.Models
{
    public class LoginDB
    {
        [Required(ErrorMessage ="This box is mandatory!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This box is mandatory!")]
        public string Password { get; set; }
        public string msg { get; set; }
    }
}