using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Data {
    public class ProjectContext : IdentityDbContext<User> {
        public ProjectContext(DbContextOptions<ProjectContext> options)
           : base(options) {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Step> Step { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>().HasKey(m => m.Id);
            builder.Entity<Project>().HasKey(m => m.Id);
            builder.Entity<Team>().HasKey(m => m.Id);
            builder.Entity<Step>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
