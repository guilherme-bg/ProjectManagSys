using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class Team {
        public int Id { get; set; }

        public TeamMember ProjectLeaderId{ get; set; }

        public TeamMember ProjectLeader{ get; set; }

        public List<TeamMember> TeamMembers{ get; set; }
        
        public Team() { }
    }
}
