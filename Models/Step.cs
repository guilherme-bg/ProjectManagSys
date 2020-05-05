using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class Step {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The step name must have between 3 and 30 characters!")]
        public string Name { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 50, ErrorMessage = "The step description must have between 50 and 500 characters!")]
        public string Description { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public Step() { }
    }
}
