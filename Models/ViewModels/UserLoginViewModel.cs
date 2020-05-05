using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models.ViewModels {
    public class UserLoginViewModel {
        [Required(ErrorMessage = "Please, insert a valid email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, insert your password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
