using Microsoft.CodeAnalysis;
using ProjectManagementSystem.Data;
using ProjectManagementSystem.Models;
using ProjectManagementSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Services {
    public class ProjectService {
        private readonly ProjectContext Context;

        public ProjectService(ProjectContext projectContext) {
            Context = projectContext;
        }

        public async Task<Models.Project> FindByIdAsync(int id) {
            return await Context.Project.FindAsync(id);
        }
        
        public async Task Create(ProjectCreateViewModel model) {
            var project = new Models.Project {
                Name = model.Name,
                Description = model.Description
            };
            Context.Add(project);
            Context.SaveChanges();
        }

        public async Task EditGet(int id) {
            var foundproject = await FindByIdAsync(id);
            var model = new ProjectEditViewModel {
                project = foundproject
            };
        }

        public async Task EditPost(ProjectEditViewModel model) {
            var foundproject = await FindByIdAsync(model.project.Id);
            foundproject.Name = model.project.Name;
            foundproject.Description = model.project.Description;
            Context.Project.Update(foundproject);
            Context.SaveChanges();
        }

        public async Task Remove(int id) {
            var foundproject = await FindByIdAsync(id);
            Context.Remove(foundproject);
            Context.SaveChanges();
        }       
    }
}
