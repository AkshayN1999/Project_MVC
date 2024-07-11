using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJECT_MVC.Models
{
    public class ChangePwd
    {
        [Required(ErrorMessage = "Enter the old password")]
        public string OldPassword { set; get; }
        [Required(ErrorMessage = "Enter the new password")]
        public string NewPassword { set; get; }
        [Compare("NewPassword", ErrorMessage = "Password mismatch!")]
        public string ConfirmPassword { set; get; }
        public string msg { set; get; }
    }
}