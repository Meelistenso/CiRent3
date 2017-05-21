using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CiRent.WebUi.Models
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }
       
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}