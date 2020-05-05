using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementSystem.Models;
using ProjectManagementSystem.Models.ViewModels;
using ProjectManagementSystem.Services;

namespace ProjectManagementSystem.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> UserManager { get; set; }
        private UserService UserService { get; set; }
    
        public UserController(UserManager<User> userManager, UserService userService) {
            UserManager = userManager;
            UserService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await UserService.FindAllAsync();
            return View(list);
        }
             
        public async Task<IActionResult> Register() {
            var model = new UserRegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel model) {
            if (ModelState.IsValid) {
                await UserService.RegisterAsync(model);
                return (RedirectToAction("Index"));
            }
            return View(model);
        }

        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> IsEmailInUse(string email) {
            var user = await UserManager.FindByEmailAsync(email);
            if (user == null) {
                return Json(true);
            } else {
                return Json($"Email {email} is already in use!");
            }
        }

        public async Task<IActionResult> Login() {
            var model = new UserLoginViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model, string returnUrl) {
            if (ModelState.IsValid) {
                await UserService.LoginAsync(model);
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl)) {
                    return LocalRedirect(returnUrl);
                } else {
                    return RedirectToAction("Index");
                }                
            }
            ModelState.AddModelError(string.Empty, "Incorrect email or password!");
            return View(model);
        }
    }
}