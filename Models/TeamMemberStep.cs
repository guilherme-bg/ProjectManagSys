using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class TeamMemberStep {
        public string TeamMemberId { get; set; }
        public virtual TeamMember TeamMember { get; set; }
        public int StepId { get; set; }
        public virtual Step Step { get; set; }
    }
}
