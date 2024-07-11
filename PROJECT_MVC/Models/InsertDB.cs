using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJECT_MVC.Models
{
    public class InsertDB
    {
        [Required(ErrorMessage = "Name is manadaoty")]
        public string Name { get; set; }
        [Range(18, 50, ErrorMessage = "Age should be within the limit/Fill this field")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Name is manadatory")]
        public string Address { get; set; }
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }
        public string Photo { get; set; }
        [Required(ErrorMessage = "Username is mandatory")]
        public string Username { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password mismatch")]
        public string CPassword { get; set; }
        public string msg { get; set; }
    }
}