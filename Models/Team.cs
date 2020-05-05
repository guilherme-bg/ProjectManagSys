using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models {
    public class Team {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId{ get; set; }
        public List<User> Members{ get; set; }
        
        public Team() { }
    }
}
