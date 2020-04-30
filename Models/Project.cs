using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class Project {
        public int ProjectId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The project name must have 50 or less characters!")]
        public string Name { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 30, ErrorMessage = "Your description must have at least 30 characters and a maximum of 500 characters!")]
        public string Description { get; set; }
        public List<Step> Steps{ get; set; }
        public int TeamId { get; set; }
        public Team Team{ get; set; }

        public Project() { }
    }
}
