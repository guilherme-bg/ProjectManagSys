using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Data {
    public class ProjectContext : DbContext {
        public ProjectContext(DbContextOptions<ProjectContext> options)
           : base(options) {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Step> Step { get; set; }        
    }
}
