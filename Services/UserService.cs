using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Data;
using ProjectManagementSystem.Models;
using ProjectManagementSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Services {
    public class UserService {
        private readonly UserManager<User> UserManager;
        private readonly SignInManager<User> SigninManager;
        private readonly ProjectContext Context;
        
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, ProjectContext projectContext) {
            UserManager = userManager;
            SigninManager = signInManager;
            Context = projectContext;
        }

        public async Task<List<User>> FindAllAsync() {
            return await Context.User.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task RegisterAsync(UserRegisterViewModel model) {
            var user = new User {
                UserName = model.Email,
                Name = model.User.Name,
                LastName = model.User.LastName,
                Email = model.Email
            };
            await UserManager.CreateAsync(user, model.Password);
        }

        public async Task LoginAsync(UserLoginViewModel model) {
            await SigninManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);            
        }

    }
}
