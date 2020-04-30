using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class User : IdentityUser {
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must have at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Last name must have at least 3 characters")]
        public string LastName { get; set; }

        public User() { }

    }
}
