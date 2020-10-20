using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class TeamMember {

        public int Id { get; set; }

        public int UserId{ get; set; }

        public string Role { get; set; }

        public User User{ get; set; }

        public int TeamId { get; set; }

        public Team Team{ get; set; }

        public ICollection<Step> Steps{ get; set; }

        public TeamMember() {

        }

    }   
}
