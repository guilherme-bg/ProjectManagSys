using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class UserRegisterViewModel {
        [Required(ErrorMessage = "Enter your email address!")]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "User", ErrorMessage = "Email is already in use!")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password does not match!")]
        public string ConfirmPassword { get; set; }

        public User User{ get; set; }

    }
}
