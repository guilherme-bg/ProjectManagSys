using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class Team {
        public int Id { get; set; }

        public int UserId{ get; set; }

        [Display(Name = "Project Leader")]
        public User User{ get; set; }
        
        public ICollection<TeamMember> TeamMembers{ get; set; }
        
        public Team() {            
        }
    }
}
